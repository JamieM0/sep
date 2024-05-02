namespace sep
{
    partial class frmOptions
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
            btnSaveAndReturn = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            cbDebugMode = new System.Windows.Forms.CheckBox();
            cbEncryptFileNames = new System.Windows.Forms.CheckBox();
            cbRemoveDirectoryStructure = new System.Windows.Forms.CheckBox();
            lbDebugModeInfo = new System.Windows.Forms.Label();
            lbEncryptFileNamesInfo = new System.Windows.Forms.Label();
            lbRemoveDirectoryStructureInLockersInfo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnSaveAndReturn
            // 
            btnSaveAndReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSaveAndReturn.Image = Properties.Resources.save_icon_small__Custom_;
            btnSaveAndReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaveAndReturn.Location = new System.Drawing.Point(95, 226);
            btnSaveAndReturn.Name = "btnSaveAndReturn";
            btnSaveAndReturn.Size = new System.Drawing.Size(216, 47);
            btnSaveAndReturn.TabIndex = 0;
            btnSaveAndReturn.Text = "Save and Return";
            btnSaveAndReturn.UseVisualStyleBackColor = true;
            btnSaveAndReturn.Click += btnSaveAndReturn_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = System.Drawing.Color.Transparent;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(151, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(98, 32);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Options";
            // 
            // cbDebugMode
            // 
            cbDebugMode.AutoSize = true;
            cbDebugMode.BackColor = System.Drawing.Color.Transparent;
            cbDebugMode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbDebugMode.Location = new System.Drawing.Point(12, 45);
            cbDebugMode.Name = "cbDebugMode";
            cbDebugMode.Size = new System.Drawing.Size(141, 29);
            cbDebugMode.TabIndex = 2;
            cbDebugMode.Text = "Debug Mode";
            cbDebugMode.UseVisualStyleBackColor = false;
            // 
            // cbEncryptFileNames
            // 
            cbEncryptFileNames.AutoSize = true;
            cbEncryptFileNames.BackColor = System.Drawing.Color.Transparent;
            cbEncryptFileNames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbEncryptFileNames.Location = new System.Drawing.Point(12, 105);
            cbEncryptFileNames.Name = "cbEncryptFileNames";
            cbEncryptFileNames.Size = new System.Drawing.Size(191, 29);
            cbEncryptFileNames.TabIndex = 3;
            cbEncryptFileNames.Text = "Encrypt File Names";
            cbEncryptFileNames.UseVisualStyleBackColor = false;
            cbEncryptFileNames.CheckedChanged += cbEncryptFileNames_CheckedChanged;
            // 
            // cbRemoveDirectoryStructure
            // 
            cbRemoveDirectoryStructure.AutoSize = true;
            cbRemoveDirectoryStructure.BackColor = System.Drawing.Color.Transparent;
            cbRemoveDirectoryStructure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbRemoveDirectoryStructure.Location = new System.Drawing.Point(12, 166);
            cbRemoveDirectoryStructure.Name = "cbRemoveDirectoryStructure";
            cbRemoveDirectoryStructure.Size = new System.Drawing.Size(349, 29);
            cbRemoveDirectoryStructure.TabIndex = 4;
            cbRemoveDirectoryStructure.Text = "Remove Directory Structure in Lockers";
            cbRemoveDirectoryStructure.UseVisualStyleBackColor = false;
            // 
            // lbDebugModeInfo
            // 
            lbDebugModeInfo.AutoSize = true;
            lbDebugModeInfo.BackColor = System.Drawing.Color.Transparent;
            lbDebugModeInfo.Location = new System.Drawing.Point(32, 72);
            lbDebugModeInfo.Name = "lbDebugModeInfo";
            lbDebugModeInfo.Size = new System.Drawing.Size(119, 15);
            lbDebugModeInfo.TabIndex = 5;
            lbDebugModeInfo.Text = "Enable Debug Mode?";
            // 
            // lbEncryptFileNamesInfo
            // 
            lbEncryptFileNamesInfo.AutoSize = true;
            lbEncryptFileNamesInfo.BackColor = System.Drawing.Color.Transparent;
            lbEncryptFileNamesInfo.Location = new System.Drawing.Point(32, 132);
            lbEncryptFileNamesInfo.Name = "lbEncryptFileNamesInfo";
            lbEncryptFileNamesInfo.Size = new System.Drawing.Size(366, 15);
            lbEncryptFileNamesInfo.TabIndex = 6;
            lbEncryptFileNamesInfo.Text = "When this is enabled, you won't be able to use the Password Library.";
            // 
            // lbRemoveDirectoryStructureInLockersInfo
            // 
            lbRemoveDirectoryStructureInLockersInfo.AutoSize = true;
            lbRemoveDirectoryStructureInLockersInfo.BackColor = System.Drawing.Color.Transparent;
            lbRemoveDirectoryStructureInLockersInfo.Location = new System.Drawing.Point(32, 193);
            lbRemoveDirectoryStructureInLockersInfo.Name = "lbRemoveDirectoryStructureInLockersInfo";
            lbRemoveDirectoryStructureInLockersInfo.Size = new System.Drawing.Size(270, 15);
            lbRemoveDirectoryStructureInLockersInfo.TabIndex = 7;
            lbRemoveDirectoryStructureInLockersInfo.Text = "Remove the directory structure in a locked locker?";
            // 
            // frmOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_Options;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(403, 285);
            Controls.Add(lbDebugModeInfo);
            Controls.Add(lbRemoveDirectoryStructureInLockersInfo);
            Controls.Add(lbEncryptFileNamesInfo);
            Controls.Add(cbRemoveDirectoryStructure);
            Controls.Add(cbEncryptFileNames);
            Controls.Add(cbDebugMode);
            Controls.Add(lbTitle);
            Controls.Add(btnSaveAndReturn);
            Name = "frmOptions";
            Text = "SEP - Options";
            Load += frmOptions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSaveAndReturn;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.CheckBox cbEncryptFileNames;
        private System.Windows.Forms.CheckBox cbRemoveDirectoryStructure;
        private System.Windows.Forms.Label lbDebugModeInfo;
        private System.Windows.Forms.Label lbEncryptFileNamesInfo;
        private System.Windows.Forms.Label lbRemoveDirectoryStructureInLockersInfo;
    }
}