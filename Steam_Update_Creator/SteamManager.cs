using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Steam_Update_Creator.Properties;

namespace Steam_Update_Creator {
    internal class SteamManager {
        public IList<Game> SteamGameList { get; private set; }

        private IList<string> _steamAppsFolderList;
        private string _steamPath;

        public SteamManager() {
            UpdateInfo();
        }

        public void UpdateInfo() {
            _steamPath = CheckSteamPath();
            if (string.IsNullOrEmpty(_steamPath)) {
                throw new DirectoryNotFoundException("Steam not found!");
            }
            _steamAppsFolderList = ReadSteamAppsFolderList();
            if (!_steamAppsFolderList.Any()) {
                throw new DirectoryNotFoundException("SteamApps not found!");
            }
            SteamGameList = ReadGameList();
        }

        public string CheckSteamPath() {
            string path = OSBitChecker.Is64Bit() ? Resources.SoftwareRegPathX64 : Resources.SoftwareRegPathX32;
            path += string.Concat('\\', Resources.SteamRegPath);
            string name = Resources.SteamRegKeyName;
            return RegReader.ReadValue(path, name);
        }

        public IList<string> ReadSteamAppsFolderList() {
            IList<string> resultList = new List<string>();
            string path = string.Concat(_steamPath, '\\', Resources.SteamSteamAppsDefaultPath);
            if (Directory.Exists(path)) {
                resultList.Add(path);
            }

            path = Path.Combine(_steamPath, Resources.SteamConfigPath, Resources.SteamConfigFile);

            if (File.Exists(path)) {
                string text = File.ReadAllText(path);

                var matches = Regex.Matches(text, Resources.RegexBaseInstallFolderAll);

                foreach (var match in matches) {
                    string temp =
                        Regex.Match(match.ToString(),
                            Resources.RegexBaseInstallFolderSingle).Value.Replace("\\\\", "\\");
                    if (Directory.Exists(temp)) {
                        temp += "\\steamapps\\";
                        if (Directory.Exists(temp)) {
                            resultList.Add(temp);
                        }
                    }
                }
            }
            return resultList;
        }

        public IList<Game> ReadGameList() {
            var resultList = new List<Game>();

            foreach (var steamapps in _steamAppsFolderList) {
                if (Directory.Exists(steamapps)) {
                    string[] files = Directory.GetFiles(steamapps, "appmanifest_*.acf");
                    foreach (var file in files) {
                        string text = File.ReadAllText(file);

                        string appid =
                            Regex.Match(text, Resources.RegexGameAppId).Value;
                        appid = appid.Substring(appid.LastIndexOf('\"') + 1);

                        string name = Regex.Match(text, Resources.RegexGameName).Value;
                        name = name.Substring(name.LastIndexOf('\"') + 1);

                        string installDir =
                            Regex.Match(text, Resources.RegexGameInstallDir).Value;
                        installDir = installDir.Substring(installDir.LastIndexOf('\"') + 1);
                        installDir = Path.Combine(steamapps, Resources.SteamCommonPath, installDir);

                        string lastUpdatedStr =
                            Regex.Match(text, Resources.RegexGameLastUpdated).Value;
                        lastUpdatedStr = lastUpdatedStr.Substring(lastUpdatedStr.LastIndexOf('\"') + 1);

                        string sizeOnDisk =
                            Regex.Match(text, Resources.RegexGameSizeOnDisk).Value;
                        sizeOnDisk = sizeOnDisk.Substring(sizeOnDisk.LastIndexOf('\"') + 1);

                        IList<string> mountedDepots = new List<string>();
                        var matches = Regex.Matches(text, Resources.RegexGameMountedDepotsBlock);
                        foreach (var match in matches) {
                            var tempMatches = Regex.Matches(match.ToString(), Resources.RegexGameMountedDepotsAll);
                            foreach (var tempMatch in tempMatches) {
                                var temp = Regex.Matches(tempMatch.ToString(), "\\d+");
                                if (temp.Count > 1) {
                                    mountedDepots.Add(Path.Combine(_steamPath, Resources.SteamDepotcachePath,
                                        (string.Concat(temp[0], '_', temp[1], '.', "manifest"))));
                                }
                            }
                        }

                        long lastUpdated = 0;
                        long.TryParse(lastUpdatedStr, out lastUpdated);

                        var game = new Game {
                            Manifest = file,
                            Appid = appid,
                            Name = name,
                            InstallDir = installDir,
                            LastUpdated = Tools.UnixTimeStampToDateTime(lastUpdated),
                            SizeOnDisk = sizeOnDisk,
                            MountedDepots = mountedDepots
                        };
                        resultList.Add(game);
                    }
                }
            }

            resultList.Sort((a, b) => a.Name.CompareTo(b.Name));
            return resultList;
        }

        public string GetSteamUrl(string appid) {
            return string.Concat(Resources.SteamGameUrl, appid);
        }
    }
}
