using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Steam_Update_Creator {
    public partial class MainForm : Form {
        private SteamManager _steamManager;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            try {
                _steamManager = new SteamManager();
            } catch (DirectoryNotFoundException ex) {
                MessageBox.Show(ex.Message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            UpdateGameList();
        }

        private void lbGames_SelectedIndexChanged(object sender, EventArgs e) {
            Game game = _steamManager.SteamGameList.First(temp => temp.Name.Equals(lbGames.SelectedItem));
            if (game != null) {
                bCreateUpdate.Enabled = true;
                lGameName.Text = game.Name;
                tbGameFolder.Text = game.InstallDir;
                tbGameManifest.Text = game.Manifest;
                tbGameAppid.Text = game.Appid;
                lSizeOnDiskValue.Text = Tools.SizeViewOptimize(game.SizeOnDisk);
                lLastUpdatedValue.Text = game.LastUpdated.ToString();
                lbDepotcache.Items.Clear();
                foreach (var depot in game.MountedDepots) {
                    lbDepotcache.Items.Add(depot);
                }
            } else {
                bCreateUpdate.Enabled = false;
            }
        }

        private void tbGameFolder_MouseDoubleClick(object sender, MouseEventArgs e) {
            string path = ((TextBox) sender).Text;
            Process.Start(path);
        }

        private void tbGameManifest_MouseDoubleClick(object sender, MouseEventArgs e) {
            string file = ((TextBox) sender).Text;
            Process.Start("explorer.exe", @"/select, " + file);
        }

        private void tbGameAppid_MouseDoubleClick(object sender, MouseEventArgs e) {
            string url = _steamManager.GetSteamUrl(((TextBox) sender).Text);
            Process.Start(url);
        }

        private void lbDepotcache_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (((ListBox) sender).SelectedIndex >= 0) {
                string path = ((ListBox) sender).SelectedItem.ToString();
                Process.Start("explorer.exe", @"/select, " + path);
            }
        }

        private void bCreateUpdate_Click(object sender, EventArgs e) {
            Game game = _steamManager.SteamGameList.First(temp => temp.Name.Equals(lbGames.SelectedItem));
            if (game != null) {
                new CreatorForm(game).ShowDialog();
            }
        }

        private void bRefresh_Click(object sender, EventArgs e) {
            var current = lbGames.SelectedIndex;
            UpdateGameList();
            if (current < lbGames.Items.Count) {
                lbGames.SelectedIndex = current;
            }
        }

        private void UpdateGameList() {
            if (_steamManager != null) {
                lbGames.Items.Clear();
                foreach (Game game in _steamManager.SteamGameList) {
                    lbGames.Items.Add(game.Name);
                }
                if (lbGames.Items.Count > 0) {
                    lbGames.SelectedIndex = 0;
                }
            }
        }
    }
}
