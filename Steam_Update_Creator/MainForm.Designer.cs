namespace Steam_Update_Creator {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bRefresh = new System.Windows.Forms.Button();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.bCreateUpdate = new System.Windows.Forms.Button();
            this.lDepotcache = new System.Windows.Forms.Label();
            this.lbDepotcache = new System.Windows.Forms.ListBox();
            this.lLastUpdatedValue = new System.Windows.Forms.Label();
            this.lSizeOnDiskValue = new System.Windows.Forms.Label();
            this.tbGameManifest = new System.Windows.Forms.TextBox();
            this.lGameName = new System.Windows.Forms.Label();
            this.lGameManifest = new System.Windows.Forms.Label();
            this.lSizeOnDisk = new System.Windows.Forms.Label();
            this.tbGameFolder = new System.Windows.Forms.TextBox();
            this.lLastUpdated = new System.Windows.Forms.Label();
            this.tbGameAppid = new System.Windows.Forms.TextBox();
            this.lGameFolder = new System.Windows.Forms.Label();
            this.lGameAppid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bRefresh
            // 
            this.bRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bRefresh.Location = new System.Drawing.Point(12, 293);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 23);
            this.bRefresh.TabIndex = 7;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.Location = new System.Drawing.Point(12, 12);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(218, 277);
            this.lbGames.TabIndex = 0;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.lbGames_SelectedIndexChanged);
            // 
            // bCreateUpdate
            // 
            this.bCreateUpdate.Enabled = false;
            this.bCreateUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCreateUpdate.Location = new System.Drawing.Point(566, 293);
            this.bCreateUpdate.Name = "bCreateUpdate";
            this.bCreateUpdate.Size = new System.Drawing.Size(87, 23);
            this.bCreateUpdate.TabIndex = 6;
            this.bCreateUpdate.Text = "Create Update";
            this.bCreateUpdate.UseVisualStyleBackColor = true;
            this.bCreateUpdate.Click += new System.EventHandler(this.bCreateUpdate_Click);
            // 
            // lDepotcache
            // 
            this.lDepotcache.AutoSize = true;
            this.lDepotcache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lDepotcache.Location = new System.Drawing.Point(241, 165);
            this.lDepotcache.Name = "lDepotcache";
            this.lDepotcache.Size = new System.Drawing.Size(69, 13);
            this.lDepotcache.TabIndex = 5;
            this.lDepotcache.Text = "Depotcache:";
            // 
            // lbDepotcache
            // 
            this.lbDepotcache.FormattingEnabled = true;
            this.lbDepotcache.Location = new System.Drawing.Point(244, 181);
            this.lbDepotcache.Name = "lbDepotcache";
            this.lbDepotcache.Size = new System.Drawing.Size(409, 108);
            this.lbDepotcache.TabIndex = 5;
            this.lbDepotcache.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbDepotcache_MouseDoubleClick);
            // 
            // lLastUpdatedValue
            // 
            this.lLastUpdatedValue.AutoSize = true;
            this.lLastUpdatedValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLastUpdatedValue.Location = new System.Drawing.Point(318, 139);
            this.lLastUpdatedValue.Name = "lLastUpdatedValue";
            this.lLastUpdatedValue.Size = new System.Drawing.Size(13, 13);
            this.lLastUpdatedValue.TabIndex = 4;
            this.lLastUpdatedValue.Text = "0";
            // 
            // lSizeOnDiskValue
            // 
            this.lSizeOnDiskValue.AutoSize = true;
            this.lSizeOnDiskValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lSizeOnDiskValue.Location = new System.Drawing.Point(312, 116);
            this.lSizeOnDiskValue.Name = "lSizeOnDiskValue";
            this.lSizeOnDiskValue.Size = new System.Drawing.Size(13, 13);
            this.lSizeOnDiskValue.TabIndex = 3;
            this.lSizeOnDiskValue.Text = "0";
            // 
            // tbGameManifest
            // 
            this.tbGameManifest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGameManifest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbGameManifest.Location = new System.Drawing.Point(295, 62);
            this.tbGameManifest.Name = "tbGameManifest";
            this.tbGameManifest.Size = new System.Drawing.Size(301, 20);
            this.tbGameManifest.TabIndex = 1;
            this.tbGameManifest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbGameManifest_MouseDoubleClick);
            // 
            // lGameName
            // 
            this.lGameName.AutoSize = true;
            this.lGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lGameName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lGameName.Location = new System.Drawing.Point(240, 11);
            this.lGameName.Name = "lGameName";
            this.lGameName.Size = new System.Drawing.Size(83, 17);
            this.lGameName.TabIndex = 0;
            this.lGameName.Text = "GameName";
            // 
            // lGameManifest
            // 
            this.lGameManifest.AutoSize = true;
            this.lGameManifest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lGameManifest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lGameManifest.Location = new System.Drawing.Point(242, 65);
            this.lGameManifest.Name = "lGameManifest";
            this.lGameManifest.Size = new System.Drawing.Size(47, 13);
            this.lGameManifest.TabIndex = 1;
            this.lGameManifest.Text = "Manifest";
            // 
            // lSizeOnDisk
            // 
            this.lSizeOnDisk.AutoSize = true;
            this.lSizeOnDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lSizeOnDisk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lSizeOnDisk.Location = new System.Drawing.Point(241, 116);
            this.lSizeOnDisk.Name = "lSizeOnDisk";
            this.lSizeOnDisk.Size = new System.Drawing.Size(65, 13);
            this.lSizeOnDisk.TabIndex = 3;
            this.lSizeOnDisk.Text = "SizeOnDisk:";
            // 
            // tbGameFolder
            // 
            this.tbGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbGameFolder.Location = new System.Drawing.Point(295, 36);
            this.tbGameFolder.Name = "tbGameFolder";
            this.tbGameFolder.Size = new System.Drawing.Size(301, 20);
            this.tbGameFolder.TabIndex = 0;
            this.tbGameFolder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbGameFolder_MouseDoubleClick);
            // 
            // lLastUpdated
            // 
            this.lLastUpdated.AutoSize = true;
            this.lLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lLastUpdated.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLastUpdated.Location = new System.Drawing.Point(241, 139);
            this.lLastUpdated.Name = "lLastUpdated";
            this.lLastUpdated.Size = new System.Drawing.Size(71, 13);
            this.lLastUpdated.TabIndex = 4;
            this.lLastUpdated.Text = "LastUpdated:";
            // 
            // tbGameAppid
            // 
            this.tbGameAppid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGameAppid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbGameAppid.Location = new System.Drawing.Point(295, 88);
            this.tbGameAppid.Name = "tbGameAppid";
            this.tbGameAppid.Size = new System.Drawing.Size(301, 20);
            this.tbGameAppid.TabIndex = 2;
            this.tbGameAppid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbGameAppid_MouseDoubleClick);
            // 
            // lGameFolder
            // 
            this.lGameFolder.AutoSize = true;
            this.lGameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lGameFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lGameFolder.Location = new System.Drawing.Point(242, 39);
            this.lGameFolder.Name = "lGameFolder";
            this.lGameFolder.Size = new System.Drawing.Size(47, 13);
            this.lGameFolder.TabIndex = 0;
            this.lGameFolder.Text = "InstallDir";
            // 
            // lGameAppid
            // 
            this.lGameAppid.AutoSize = true;
            this.lGameAppid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lGameAppid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lGameAppid.Location = new System.Drawing.Point(242, 87);
            this.lGameAppid.Name = "lGameAppid";
            this.lGameAppid.Size = new System.Drawing.Size(34, 13);
            this.lGameAppid.TabIndex = 2;
            this.lGameAppid.Text = "Appid";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 328);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.bCreateUpdate);
            this.Controls.Add(this.lGameName);
            this.Controls.Add(this.lDepotcache);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.lbDepotcache);
            this.Controls.Add(this.lLastUpdatedValue);
            this.Controls.Add(this.lSizeOnDiskValue);
            this.Controls.Add(this.tbGameManifest);
            this.Controls.Add(this.lGameFolder);
            this.Controls.Add(this.lGameManifest);
            this.Controls.Add(this.lGameAppid);
            this.Controls.Add(this.lSizeOnDisk);
            this.Controls.Add(this.tbGameAppid);
            this.Controls.Add(this.tbGameFolder);
            this.Controls.Add(this.lLastUpdated);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Steam Update Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Button bCreateUpdate;
        private System.Windows.Forms.Label lDepotcache;
        private System.Windows.Forms.ListBox lbDepotcache;
        private System.Windows.Forms.Label lLastUpdatedValue;
        private System.Windows.Forms.Label lSizeOnDiskValue;
        private System.Windows.Forms.TextBox tbGameManifest;
        private System.Windows.Forms.Label lGameName;
        private System.Windows.Forms.Label lGameManifest;
        private System.Windows.Forms.Label lSizeOnDisk;
        private System.Windows.Forms.TextBox tbGameFolder;
        private System.Windows.Forms.Label lLastUpdated;
        private System.Windows.Forms.TextBox tbGameAppid;
        private System.Windows.Forms.Label lGameFolder;
        private System.Windows.Forms.Label lGameAppid;
    }
}