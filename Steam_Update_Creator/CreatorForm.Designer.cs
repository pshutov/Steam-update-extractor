namespace Steam_Update_Creator
{
    partial class CreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pGameName = new System.Windows.Forms.Panel();
            this.lGameName = new System.Windows.Forms.Label();
            this.pSettings = new System.Windows.Forms.Panel();
            this.gbDateSetting = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lToDate = new System.Windows.Forms.Label();
            this.lFromDate = new System.Windows.Forms.Label();
            this.gbFolder = new System.Windows.Forms.GroupBox();
            this.bOutFolder = new System.Windows.Forms.Button();
            this.tbOutFolder = new System.Windows.Forms.TextBox();
            this.pButton = new System.Windows.Forms.Panel();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.bCreate = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pGameName.SuspendLayout();
            this.pSettings.SuspendLayout();
            this.gbDateSetting.SuspendLayout();
            this.gbFolder.SuspendLayout();
            this.pButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGameName
            // 
            this.pGameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGameName.Controls.Add(this.lGameName);
            this.pGameName.Location = new System.Drawing.Point(12, 12);
            this.pGameName.Name = "pGameName";
            this.pGameName.Size = new System.Drawing.Size(388, 19);
            this.pGameName.TabIndex = 0;
            // 
            // lGameName
            // 
            this.lGameName.AutoSize = true;
            this.lGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGameName.Location = new System.Drawing.Point(8, 0);
            this.lGameName.Name = "lGameName";
            this.lGameName.Size = new System.Drawing.Size(83, 17);
            this.lGameName.TabIndex = 0;
            this.lGameName.Text = "GameName";
            // 
            // pSettings
            // 
            this.pSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSettings.Controls.Add(this.gbDateSetting);
            this.pSettings.Controls.Add(this.gbFolder);
            this.pSettings.Location = new System.Drawing.Point(13, 37);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(387, 120);
            this.pSettings.TabIndex = 4;
            // 
            // gbDateSetting
            // 
            this.gbDateSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateSetting.Controls.Add(this.dtpToDate);
            this.gbDateSetting.Controls.Add(this.dtpFromDate);
            this.gbDateSetting.Controls.Add(this.lToDate);
            this.gbDateSetting.Controls.Add(this.lFromDate);
            this.gbDateSetting.Location = new System.Drawing.Point(4, 56);
            this.gbDateSetting.Name = "gbDateSetting";
            this.gbDateSetting.Size = new System.Drawing.Size(380, 61);
            this.gbDateSetting.TabIndex = 2;
            this.gbDateSetting.TabStop = false;
            this.gbDateSetting.Text = "DateSetting";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(233, 36);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(141, 20);
            this.dtpToDate.TabIndex = 3;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(6, 36);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(141, 20);
            this.dtpFromDate.TabIndex = 2;
            // 
            // lToDate
            // 
            this.lToDate.AutoSize = true;
            this.lToDate.Location = new System.Drawing.Point(230, 20);
            this.lToDate.Name = "lToDate";
            this.lToDate.Size = new System.Drawing.Size(20, 13);
            this.lToDate.TabIndex = 1;
            this.lToDate.Text = "To";
            // 
            // lFromDate
            // 
            this.lFromDate.AutoSize = true;
            this.lFromDate.Location = new System.Drawing.Point(6, 20);
            this.lFromDate.Name = "lFromDate";
            this.lFromDate.Size = new System.Drawing.Size(30, 13);
            this.lFromDate.TabIndex = 0;
            this.lFromDate.Text = "From";
            // 
            // gbFolder
            // 
            this.gbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFolder.Controls.Add(this.bOutFolder);
            this.gbFolder.Controls.Add(this.tbOutFolder);
            this.gbFolder.Location = new System.Drawing.Point(4, 4);
            this.gbFolder.Name = "gbFolder";
            this.gbFolder.Size = new System.Drawing.Size(380, 46);
            this.gbFolder.TabIndex = 1;
            this.gbFolder.TabStop = false;
            this.gbFolder.Text = "OutFolder";
            // 
            // bOutFolder
            // 
            this.bOutFolder.Location = new System.Drawing.Point(344, 17);
            this.bOutFolder.Name = "bOutFolder";
            this.bOutFolder.Size = new System.Drawing.Size(30, 23);
            this.bOutFolder.TabIndex = 1;
            this.bOutFolder.Text = "...";
            this.bOutFolder.UseVisualStyleBackColor = true;
            this.bOutFolder.Click += new System.EventHandler(this.bOutFolder_Click);
            // 
            // tbOutFolder
            // 
            this.tbOutFolder.Location = new System.Drawing.Point(6, 19);
            this.tbOutFolder.Name = "tbOutFolder";
            this.tbOutFolder.Size = new System.Drawing.Size(332, 20);
            this.tbOutFolder.TabIndex = 0;
            // 
            // pButton
            // 
            this.pButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pButton.Controls.Add(this.pbProgress);
            this.pButton.Controls.Add(this.bCreate);
            this.pButton.Controls.Add(this.bCancel);
            this.pButton.Location = new System.Drawing.Point(13, 163);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(387, 29);
            this.pButton.TabIndex = 3;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(3, 3);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(219, 23);
            this.pbProgress.TabIndex = 2;
            // 
            // bCreate
            // 
            this.bCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreate.Location = new System.Drawing.Point(228, 3);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 5;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(309, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 204);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.pSettings);
            this.Controls.Add(this.pGameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Steam Game Updater";
            this.Shown += new System.EventHandler(this.CreatorForm_Shown);
            this.pGameName.ResumeLayout(false);
            this.pGameName.PerformLayout();
            this.pSettings.ResumeLayout(false);
            this.gbDateSetting.ResumeLayout(false);
            this.gbDateSetting.PerformLayout();
            this.gbFolder.ResumeLayout(false);
            this.gbFolder.PerformLayout();
            this.pButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGameName;
        private System.Windows.Forms.Label lGameName;
        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.GroupBox gbFolder;
        private System.Windows.Forms.Button bOutFolder;
        private System.Windows.Forms.TextBox tbOutFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox gbDateSetting;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lToDate;
        private System.Windows.Forms.Label lFromDate;
    }
}