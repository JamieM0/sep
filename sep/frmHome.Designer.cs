namespace sep
{
    partial class frmHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            tmrTick = new System.Windows.Forms.Timer(components);
            encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            encryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            encryptStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            decryptStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            automaticTakeoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lockersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            githubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            removeFromContextMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            passwordLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownMenu();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            wipeFileSecureDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnEncryptFile = new System.Windows.Forms.Button();
            btnDecryptFile = new System.Windows.Forms.Button();
            btnPWLib = new System.Windows.Forms.Button();
            btnLockers = new System.Windows.Forms.Button();
            pbGithub = new System.Windows.Forms.PictureBox();
            btnSecureDelete = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGithub).BeginInit();
            SuspendLayout();
            // 
            // tmrTick
            // 
            tmrTick.Tick += tmrTick_Tick;
            // 
            // encryptToolStripMenuItem
            // 
            encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encryptFileToolStripMenuItem, encryptStringToolStripMenuItem });
            encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            encryptToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            encryptToolStripMenuItem.Text = "Encrypt";
            encryptToolStripMenuItem.Click += encryptToolStripMenuItem_Click;
            // 
            // encryptFileToolStripMenuItem
            // 
            encryptFileToolStripMenuItem.Name = "encryptFileToolStripMenuItem";
            encryptFileToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            encryptFileToolStripMenuItem.Text = "Encrypt File";
            encryptFileToolStripMenuItem.Click += encryptFileToolStripMenuItem_Click;
            // 
            // encryptStringToolStripMenuItem
            // 
            encryptStringToolStripMenuItem.Name = "encryptStringToolStripMenuItem";
            encryptStringToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            encryptStringToolStripMenuItem.Text = "Encrypt String";
            encryptStringToolStripMenuItem.Click += encryptStringToolStripMenuItem_Click;
            // 
            // decryptToolStripMenuItem
            // 
            decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { decryptFileToolStripMenuItem, decryptStringToolStripMenuItem });
            decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            decryptToolStripMenuItem.Size = new System.Drawing.Size(97, 34);
            decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // decryptFileToolStripMenuItem
            // 
            decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            decryptFileToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            decryptFileToolStripMenuItem.Text = "Decrypt File";
            decryptFileToolStripMenuItem.Click += decryptFileToolStripMenuItem_Click;
            // 
            // decryptStringToolStripMenuItem
            // 
            decryptStringToolStripMenuItem.Name = "decryptStringToolStripMenuItem";
            decryptStringToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            decryptStringToolStripMenuItem.Text = "Decrypt String";
            decryptStringToolStripMenuItem.Click += decryptStringToolStripMenuItem_Click;
            // 
            // automaticTakeoverToolStripMenuItem
            // 
            automaticTakeoverToolStripMenuItem.Name = "automaticTakeoverToolStripMenuItem";
            automaticTakeoverToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            automaticTakeoverToolStripMenuItem.Text = "Add to Context Menu";
            automaticTakeoverToolStripMenuItem.Click += automaticTakeoverToolStripMenuItem_Click;
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { lockersToolStripMenuItem, githubPageToolStripMenuItem, removeFromContextMenuToolStripMenuItem });
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new System.Drawing.Size(89, 34);
            moreToolStripMenuItem.Text = "More...";
            // 
            // lockersToolStripMenuItem
            // 
            lockersToolStripMenuItem.Name = "lockersToolStripMenuItem";
            lockersToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            lockersToolStripMenuItem.Text = "Lockers";
            lockersToolStripMenuItem.Click += lockersToolStripMenuItem_Click;
            // 
            // githubPageToolStripMenuItem
            // 
            githubPageToolStripMenuItem.Name = "githubPageToolStripMenuItem";
            githubPageToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            githubPageToolStripMenuItem.Text = "Github Page";
            githubPageToolStripMenuItem.Click += githubPageToolStripMenuItem_Click;
            // 
            // removeFromContextMenuToolStripMenuItem
            // 
            removeFromContextMenuToolStripMenuItem.Name = "removeFromContextMenuToolStripMenuItem";
            removeFromContextMenuToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            removeFromContextMenuToolStripMenuItem.Text = "Remove from Context Menu";
            removeFromContextMenuToolStripMenuItem.Click += removeFromContextMenuToolStripMenuItem_Click;
            // 
            // passwordLibraryToolStripMenuItem
            // 
            passwordLibraryToolStripMenuItem.AutoClose = false;
            passwordLibraryToolStripMenuItem.Name = "passwordLibraryToolStripMenuItem";
            passwordLibraryToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { encryptToolStripMenuItem, decryptToolStripMenuItem, automaticTakeoverToolStripMenuItem, wipeFileSecureDeleteToolStripMenuItem, moreToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 38);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // wipeFileSecureDeleteToolStripMenuItem
            // 
            wipeFileSecureDeleteToolStripMenuItem.Name = "wipeFileSecureDeleteToolStripMenuItem";
            wipeFileSecureDeleteToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            wipeFileSecureDeleteToolStripMenuItem.Text = "Wipe File (Secure Delete)";
            wipeFileSecureDeleteToolStripMenuItem.Click += wipeFileSecureDeleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(597, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Simple Encryption Program!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(343, 37);
            label2.TabIndex = 1;
            label2.Text = "What would you like to do?";
            // 
            // btnEncryptFile
            // 
            btnEncryptFile.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEncryptFile.ForeColor = System.Drawing.Color.Black;
            btnEncryptFile.Image = Properties.Resources.noun_encrypt_33883351;
            btnEncryptFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEncryptFile.Location = new System.Drawing.Point(98, 186);
            btnEncryptFile.Name = "btnEncryptFile";
            btnEncryptFile.Size = new System.Drawing.Size(230, 78);
            btnEncryptFile.TabIndex = 6;
            btnEncryptFile.Text = "Encrypt";
            btnEncryptFile.UseVisualStyleBackColor = true;
            btnEncryptFile.Click += btnEncryptFile_Click;
            // 
            // btnDecryptFile
            // 
            btnDecryptFile.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDecryptFile.ForeColor = System.Drawing.Color.Black;
            btnDecryptFile.Image = Properties.Resources.noun_unlock_50913241;
            btnDecryptFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDecryptFile.Location = new System.Drawing.Point(464, 186);
            btnDecryptFile.Name = "btnDecryptFile";
            btnDecryptFile.Size = new System.Drawing.Size(230, 78);
            btnDecryptFile.TabIndex = 7;
            btnDecryptFile.Text = "Decrypt";
            btnDecryptFile.UseVisualStyleBackColor = true;
            btnDecryptFile.Click += btnDecryptFile_Click;
            // 
            // btnPWLib
            // 
            btnPWLib.Enabled = false;
            btnPWLib.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPWLib.Location = new System.Drawing.Point(270, 372);
            btnPWLib.Name = "btnPWLib";
            btnPWLib.Size = new System.Drawing.Size(253, 54);
            btnPWLib.TabIndex = 8;
            btnPWLib.Text = "Password Library";
            btnPWLib.UseVisualStyleBackColor = true;
            btnPWLib.Visible = false;
            btnPWLib.Click += btnPWLib_Click;
            // 
            // btnLockers
            // 
            btnLockers.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnLockers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLockers.Image = Properties.Resources.noun_folder_lock_56684341;
            btnLockers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLockers.Location = new System.Drawing.Point(270, 302);
            btnLockers.Name = "btnLockers";
            btnLockers.Size = new System.Drawing.Size(253, 54);
            btnLockers.TabIndex = 9;
            btnLockers.Text = "Lockers";
            btnLockers.UseVisualStyleBackColor = true;
            btnLockers.Click += btnLockers_Click;
            // 
            // pbGithub
            // 
            pbGithub.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pbGithub.Image = (System.Drawing.Image)resources.GetObject("pbGithub.Image");
            pbGithub.Location = new System.Drawing.Point(690, 54);
            pbGithub.Name = "pbGithub";
            pbGithub.Size = new System.Drawing.Size(80, 80);
            pbGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbGithub.TabIndex = 5;
            pbGithub.TabStop = false;
            pbGithub.Click += pbGithub_Click;
            // 
            // btnSecureDelete
            // 
            btnSecureDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSecureDelete.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSecureDelete.Image = Properties.Resources.noun_burn_file_43239321;
            btnSecureDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSecureDelete.Location = new System.Drawing.Point(270, 372);
            btnSecureDelete.Name = "btnSecureDelete";
            btnSecureDelete.Size = new System.Drawing.Size(253, 54);
            btnSecureDelete.TabIndex = 11;
            btnSecureDelete.Text = "Wipe File";
            btnSecureDelete.UseVisualStyleBackColor = true;
            btnSecureDelete.Click += btnSecureDelete_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 460);
            Controls.Add(btnSecureDelete);
            Controls.Add(btnLockers);
            Controls.Add(btnPWLib);
            Controls.Add(btnDecryptFile);
            Controls.Add(btnEncryptFile);
            Controls.Add(pbGithub);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmHome";
            Text = "Simple Encryption Program (SEP) - Home";
            Load += frmHome_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGithub).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticTakeoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownMenu passwordLibraryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnPWLib;
        private System.Windows.Forms.Button btnLockers;
        private System.Windows.Forms.PictureBox pbGithub;
        private System.Windows.Forms.ToolStripMenuItem removeFromContextMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnSecureDelete;
        private System.Windows.Forms.ToolStripMenuItem wipeFileSecureDeleteToolStripMenuItem;
    }
}