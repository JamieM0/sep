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
            oldEncryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            decryptStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            oldDecryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            automaticTakeoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            passwordLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownMenu();
            lockersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            githubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnEncryptFile = new System.Windows.Forms.Button();
            btnDecryptFile = new System.Windows.Forms.Button();
            btnPWLib = new System.Windows.Forms.Button();
            btnLockers = new System.Windows.Forms.Button();
            pbGithub = new System.Windows.Forms.PictureBox();
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
            encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encryptFileToolStripMenuItem, encryptStringToolStripMenuItem, oldEncryptFileToolStripMenuItem });
            encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            encryptToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            encryptToolStripMenuItem.Text = "Encrypt";
            encryptToolStripMenuItem.Click += encryptToolStripMenuItem_Click;
            // 
            // encryptFileToolStripMenuItem
            // 
            encryptFileToolStripMenuItem.Name = "encryptFileToolStripMenuItem";
            encryptFileToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            encryptFileToolStripMenuItem.Text = "Encrypt File";
            encryptFileToolStripMenuItem.Click += encryptFileToolStripMenuItem_Click;
            // 
            // encryptStringToolStripMenuItem
            // 
            encryptStringToolStripMenuItem.Name = "encryptStringToolStripMenuItem";
            encryptStringToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            encryptStringToolStripMenuItem.Text = "Encrypt String";
            encryptStringToolStripMenuItem.Click += encryptStringToolStripMenuItem_Click;
            // 
            // oldEncryptFileToolStripMenuItem
            // 
            oldEncryptFileToolStripMenuItem.Name = "oldEncryptFileToolStripMenuItem";
            oldEncryptFileToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            oldEncryptFileToolStripMenuItem.Text = "Old Encrypt File";
            oldEncryptFileToolStripMenuItem.Click += oldEncryptFileToolStripMenuItem_Click;
            // 
            // decryptToolStripMenuItem
            // 
            decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { decryptFileToolStripMenuItem, decryptStringToolStripMenuItem, oldDecryptFileToolStripMenuItem });
            decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            decryptToolStripMenuItem.Size = new System.Drawing.Size(97, 34);
            decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // decryptFileToolStripMenuItem
            // 
            decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            decryptFileToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            decryptFileToolStripMenuItem.Text = "Decrypt File";
            decryptFileToolStripMenuItem.Click += decryptFileToolStripMenuItem_Click;
            // 
            // decryptStringToolStripMenuItem
            // 
            decryptStringToolStripMenuItem.Name = "decryptStringToolStripMenuItem";
            decryptStringToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            decryptStringToolStripMenuItem.Text = "Decrypt String";
            decryptStringToolStripMenuItem.Click += decryptStringToolStripMenuItem_Click;
            // 
            // oldDecryptFileToolStripMenuItem
            // 
            oldDecryptFileToolStripMenuItem.Name = "oldDecryptFileToolStripMenuItem";
            oldDecryptFileToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            oldDecryptFileToolStripMenuItem.Text = "Old Decrypt File";
            oldDecryptFileToolStripMenuItem.Click += oldDecryptFileToolStripMenuItem_Click;
            // 
            // automaticTakeoverToolStripMenuItem
            // 
            automaticTakeoverToolStripMenuItem.Name = "automaticTakeoverToolStripMenuItem";
            automaticTakeoverToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            automaticTakeoverToolStripMenuItem.Text = "Automatic Takeover";
            automaticTakeoverToolStripMenuItem.Click += automaticTakeoverToolStripMenuItem_Click;
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { lockersToolStripMenuItem, githubPageToolStripMenuItem });
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new System.Drawing.Size(93, 34);
            moreToolStripMenuItem.Text = "Other...";
            // 
            // passwordLibraryToolStripMenuItem
            // 
            passwordLibraryToolStripMenuItem.AutoClose = false;
            passwordLibraryToolStripMenuItem.Name = "passwordLibraryToolStripMenuItem";
            passwordLibraryToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
            // 
            // lockersToolStripMenuItem
            // 
            lockersToolStripMenuItem.Name = "lockersToolStripMenuItem";
            lockersToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            lockersToolStripMenuItem.Text = "Lockers";
            lockersToolStripMenuItem.Click += lockersToolStripMenuItem_Click;
            // 
            // githubPageToolStripMenuItem
            // 
            githubPageToolStripMenuItem.Name = "githubPageToolStripMenuItem";
            githubPageToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            githubPageToolStripMenuItem.Text = "Github Page";
            githubPageToolStripMenuItem.Click += githubPageToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { encryptToolStripMenuItem, decryptToolStripMenuItem, automaticTakeoverToolStripMenuItem, moreToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 38);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(261, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome to SEP!";
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
            btnPWLib.Location = new System.Drawing.Point(271, 367);
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
            btnLockers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLockers.Location = new System.Drawing.Point(271, 307);
            btnLockers.Name = "btnLockers";
            btnLockers.Size = new System.Drawing.Size(253, 54);
            btnLockers.TabIndex = 9;
            btnLockers.Text = "Lockers";
            btnLockers.UseVisualStyleBackColor = true;
            btnLockers.Click += btnLockers_Click;
            // 
            // pbGithub
            // 
            pbGithub.Image = (System.Drawing.Image)resources.GetObject("pbGithub.Image");
            pbGithub.Location = new System.Drawing.Point(690, 54);
            pbGithub.Name = "pbGithub";
            pbGithub.Size = new System.Drawing.Size(80, 80);
            pbGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbGithub.TabIndex = 5;
            pbGithub.TabStop = false;
            pbGithub.Click += pbGithub_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem oldEncryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldDecryptFileToolStripMenuItem;
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
    }
}