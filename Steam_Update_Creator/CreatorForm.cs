using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Steam_Update_Creator.Properties;

namespace Steam_Update_Creator {
    public partial class CreatorForm : Form {
        private readonly Game _game;
        private bool _working;

        private struct CreateUpdateStruct {
            public string InFolder;
            public string OutFolder;
            public DateTime FromDate;
            public DateTime ToDate;
        }

        private struct CopySteamFilesStruct {
            public string OutFolder;
            public string ManifestFile;
            public string ManifestOutPath;
            public IList<string> Depotcache;
            public string DepotcacheOutPath;
            public DateTime FromDate;
            public DateTime ToDate;
        }

        private CreatorForm() {
            InitializeComponent();
            _working = false;
        }

        public CreatorForm(Game game) : this() {
            _game = game;
        }

        private void CreatorForm_Shown(object sender, EventArgs e) {
            lGameName.Text = _game.Name;
            dtpFromDate.Value = _game.LastUpdated.Date;
            dtpFromDate.MaxDate = DateTime.Today;
            tbOutFolder.Text = Settings.Default.OutFolder;
        }

        private void bCreate_Click(object sender, EventArgs e) {
            if (_working) return;
            try {
                string outputFolder = tbOutFolder.Text;
                DateTime fromDate = dtpFromDate.Value;
                DateTime toDate = dtpToDate.Value;

                if (string.IsNullOrEmpty(outputFolder)) {
                    throw new InvalidDataException("The output folder specified not true.");
                }
                if (fromDate > toDate) {
                    throw new InvalidTimeZoneException("The time period specified is not true.");
                }
                if (!Directory.Exists(_game.InstallDir)) {
                    throw new DirectoryNotFoundException("The original game folder not found.");
                }

                if (!Directory.Exists(outputFolder)) {
                    Directory.CreateDirectory(outputFolder);
                }
                Settings.Default.OutFolder = outputFolder;
                Settings.Default.Save();

                _working = true;
                bCreate.Enabled = false;

                pbProgress.Value = 0;
                pbProgress.Maximum = FilesCount(_game.InstallDir) + _game.MountedDepots.Count + 1;

                string outFolder = Path.Combine(outputFolder, string.Concat("Update_",
                    new DirectoryInfo(_game.InstallDir).Name.Replace(' ', '_'), "_SteamRip"));
                if (!Directory.Exists(outFolder)) {
                    Directory.CreateDirectory(outFolder);
                }
                string gameFolder = Path.Combine(outFolder, new DirectoryInfo(_game.InstallDir).Name);
                if (!Directory.Exists(gameFolder)) {
                    Directory.CreateDirectory(gameFolder);
                }

                var createUpdateState = new CreateUpdateStruct() {
                    InFolder = _game.InstallDir,
                    OutFolder = gameFolder,
                    FromDate = fromDate,
                    ToDate = toDate,
                };

                ThreadPool.QueueUserWorkItem(CreateUpdate, createUpdateState);

                var copySteamFilesState = new CopySteamFilesStruct() {
                    OutFolder = Path.Combine(outFolder, "Steam"),
                    ManifestFile = _game.Manifest,
                    ManifestOutPath = Resources.SteamSteamAppsDefaultPath,
                    Depotcache = _game.MountedDepots,
                    DepotcacheOutPath = Resources.SteamDepotcachePath,
                    FromDate = fromDate,
                    ToDate = toDate
                };
                ThreadPool.QueueUserWorkItem(CopySteamFiles, copySteamFilesState);
            } catch (DirectoryNotFoundException ex) {
                MessageBox.Show(ex.Message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } catch (InvalidTimeZoneException ex) {
                MessageBox.Show(ex.Message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } catch (InvalidDataException ex) {
                MessageBox.Show(ex.Message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void CreateUpdate(object state) {
            if (!_working) return;

            if (!(state is CreateUpdateStruct)) return;

            var stateList = (CreateUpdateStruct) state;

            string[] directories = Directory.GetDirectories(stateList.InFolder);
            foreach (string dir in directories) {
                if (CheckFolder(dir, stateList.FromDate, stateList.ToDate)) {
                    var dirInfo = new DirectoryInfo(dir);
                    string path = Path.Combine(stateList.OutFolder, dirInfo.Name);
                    if (!Directory.Exists(path)) {
                        Directory.CreateDirectory(path);
                    }

                    var tempState = new CreateUpdateStruct {
                        InFolder = dirInfo.FullName,
                        OutFolder = path,
                        FromDate = stateList.FromDate,
                        ToDate = stateList.ToDate
                    };
                    ThreadPool.QueueUserWorkItem(CreateUpdate, tempState);
                } else {
                    UpdateProgress(FilesCount(dir));
                }
            }

            string[] files = Directory.GetFiles(stateList.InFolder);
            foreach (string file in files) {
                var fileInfo = new FileInfo(file);
                if ((fileInfo.LastWriteTime >= stateList.FromDate) && (fileInfo.LastWriteTime <= stateList.ToDate)) {
                    File.Copy(file, Path.Combine(stateList.OutFolder, fileInfo.Name), true);
                }
                UpdateProgress(1);
            }
        }

        private void CopySteamFiles(object state) {
            if (!_working) return;

            if (!(state is CopySteamFilesStruct)) return;

            var stateList = (CopySteamFilesStruct) state;

            if (!Directory.Exists(stateList.OutFolder)) {
                Directory.CreateDirectory(stateList.OutFolder);
            }
            string path = Path.Combine(stateList.OutFolder, stateList.ManifestOutPath);
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            if (File.Exists(stateList.ManifestFile)) {
                string fileName = new FileInfo(stateList.ManifestFile).Name;
                File.Copy(stateList.ManifestFile, Path.Combine(path, fileName), true);
                UpdateProgress(1);
            }
            path = Path.Combine(stateList.OutFolder, stateList.DepotcacheOutPath);
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            foreach (var depot in stateList.Depotcache) {
                if (File.Exists(depot)) {
                    var fileInfo = new FileInfo(depot);
                    if ((fileInfo.LastWriteTime >= stateList.FromDate) && (fileInfo.LastWriteTime <= stateList.ToDate)) {
                        File.Copy(stateList.ManifestFile, Path.Combine(path, fileInfo.Name), true);
                    }
                    UpdateProgress(1);
                }
            }
        }

        private int FilesCount(string dirPath) {
            int result = 0;
            var directoryInfo = new DirectoryInfo(dirPath);
            if (directoryInfo.Exists) {
                result = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories).Length;
            }
            return result;
        }

        private bool CheckFolder(string dirPath, DateTime fromDate, DateTime toDate) {
            if (!_working) return false;
            bool result = false;

            string[] files = Directory.GetFiles(dirPath);
            foreach (string file in files) {
                var fileInfo = new FileInfo(file);
                result = (fileInfo.LastWriteTime >= fromDate) && (fileInfo.LastWriteTime <= toDate);
                if (result) {
                    break;
                }
            }
            if (!result) {
                var dirInfo = new DirectoryInfo(dirPath);
                result = (dirInfo.LastWriteTime >= fromDate) && (dirInfo.LastWriteTime <= toDate);
                if (!result) {
                    string[] directories = Directory.GetDirectories(dirPath);
                    foreach (string dir in directories) {
                        result = CheckFolder(dir, fromDate, toDate.Date);
                        if (result) {
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private void UpdateProgress(int value) {
            if (InvokeRequired) {
                Invoke(new Action<int>(UpdateProgress), value);
            } else {
                pbProgress.Value += value;
                if (pbProgress.Value >= pbProgress.Maximum) {
                    MessageBox.Show(@"Done!");
                    bCreate.Enabled = true;
                    _working = false;
                }
            }
        }

        private void bOutFolder_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                tbOutFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
