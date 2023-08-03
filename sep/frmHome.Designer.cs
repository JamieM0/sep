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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbGithub = new System.Windows.Forms.PictureBox();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnPWLib = new System.Windows.Forms.Button();
            this.btnLockers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldEncryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldDecryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticTakeoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGithub)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to SEP!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do today?";
            // 
            // pbGithub
            // 
            this.pbGithub.Image = ((System.Drawing.Image)(resources.GetObject("pbGithub.Image")));
            this.pbGithub.Location = new System.Drawing.Point(690, 54);
            this.pbGithub.Name = "pbGithub";
            this.pbGithub.Size = new System.Drawing.Size(80, 80);
            this.pbGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGithub.TabIndex = 5;
            this.pbGithub.TabStop = false;
            this.pbGithub.Click += new System.EventHandler(this.pbGithub_Click);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnEncryptFile.Location = new System.Drawing.Point(119, 174);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(230, 78);
            this.btnEncryptFile.TabIndex = 6;
            this.btnEncryptFile.Text = "Encrypt";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptFile.Location = new System.Drawing.Point(449, 174);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(230, 78);
            this.btnDecryptFile.TabIndex = 7;
            this.btnDecryptFile.Text = "Decrypt";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnPWLib
            // 
            this.btnPWLib.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPWLib.Location = new System.Drawing.Point(271, 367);
            this.btnPWLib.Name = "btnPWLib";
            this.btnPWLib.Size = new System.Drawing.Size(253, 54);
            this.btnPWLib.TabIndex = 8;
            this.btnPWLib.Text = "Password Library";
            this.btnPWLib.UseVisualStyleBackColor = true;
            this.btnPWLib.Click += new System.EventHandler(this.btnPWLib_Click);
            // 
            // btnLockers
            // 
            this.btnLockers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLockers.Location = new System.Drawing.Point(271, 307);
            this.btnLockers.Name = "btnLockers";
            this.btnLockers.Size = new System.Drawing.Size(253, 54);
            this.btnLockers.TabIndex = 9;
            this.btnLockers.Text = "Lockers";
            this.btnLockers.UseVisualStyleBackColor = true;
            this.btnLockers.Click += new System.EventHandler(this.btnLockers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem,
            this.automaticTakeoverToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptFileToolStripMenuItem,
            this.encryptStringToolStripMenuItem,
            this.oldEncryptFileToolStripMenuItem});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // encryptFileToolStripMenuItem
            // 
            this.encryptFileToolStripMenuItem.Name = "encryptFileToolStripMenuItem";
            this.encryptFileToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.encryptFileToolStripMenuItem.Text = "Encrypt File";
            this.encryptFileToolStripMenuItem.Click += new System.EventHandler(this.encryptFileToolStripMenuItem_Click);
            // 
            // encryptStringToolStripMenuItem
            // 
            this.encryptStringToolStripMenuItem.Name = "encryptStringToolStripMenuItem";
            this.encryptStringToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.encryptStringToolStripMenuItem.Text = "Encrypt String";
            this.encryptStringToolStripMenuItem.Click += new System.EventHandler(this.encryptStringToolStripMenuItem_Click);
            // 
            // oldEncryptFileToolStripMenuItem
            // 
            this.oldEncryptFileToolStripMenuItem.Name = "oldEncryptFileToolStripMenuItem";
            this.oldEncryptFileToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.oldEncryptFileToolStripMenuItem.Text = "Old Encrypt File";
            this.oldEncryptFileToolStripMenuItem.Click += new System.EventHandler(this.oldEncryptFileToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptFileToolStripMenuItem,
            this.decryptStringToolStripMenuItem,
            this.oldDecryptFileToolStripMenuItem});
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(97, 34);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // decryptFileToolStripMenuItem
            // 
            this.decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            this.decryptFileToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.decryptFileToolStripMenuItem.Text = "Decrypt File";
            this.decryptFileToolStripMenuItem.Click += new System.EventHandler(this.decryptFileToolStripMenuItem_Click);
            // 
            // decryptStringToolStripMenuItem
            // 
            this.decryptStringToolStripMenuItem.Name = "decryptStringToolStripMenuItem";
            this.decryptStringToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.decryptStringToolStripMenuItem.Text = "Decrypt String";
            this.decryptStringToolStripMenuItem.Click += new System.EventHandler(this.decryptStringToolStripMenuItem_Click);
            // 
            // oldDecryptFileToolStripMenuItem
            // 
            this.oldDecryptFileToolStripMenuItem.Name = "oldDecryptFileToolStripMenuItem";
            this.oldDecryptFileToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.oldDecryptFileToolStripMenuItem.Text = "Old Decrypt File";
            this.oldDecryptFileToolStripMenuItem.Click += new System.EventHandler(this.oldDecryptFileToolStripMenuItem_Click);
            // 
            // automaticTakeoverToolStripMenuItem
            // 
            this.automaticTakeoverToolStripMenuItem.Name = "automaticTakeoverToolStripMenuItem";
            this.automaticTakeoverToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.automaticTakeoverToolStripMenuItem.Text = "Automatic Takeover";
            this.automaticTakeoverToolStripMenuItem.Click += new System.EventHandler(this.automaticTakeoverToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockersToolStripMenuItem,
            this.passwordLibraryToolStripMenuItem,
            this.githubPageToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // lockersToolStripMenuItem
            // 
            this.lockersToolStripMenuItem.Name = "lockersToolStripMenuItem";
            this.lockersToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.lockersToolStripMenuItem.Text = "Lockers";
            this.lockersToolStripMenuItem.Click += new System.EventHandler(this.lockersToolStripMenuItem_Click);
            // 
            // passwordLibraryToolStripMenuItem
            // 
            this.passwordLibraryToolStripMenuItem.Name = "passwordLibraryToolStripMenuItem";
            this.passwordLibraryToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.passwordLibraryToolStripMenuItem.Text = "Password Library";
            this.passwordLibraryToolStripMenuItem.Click += new System.EventHandler(this.passwordLibraryToolStripMenuItem_Click);
            // 
            // githubPageToolStripMenuItem
            // 
            this.githubPageToolStripMenuItem.Name = "githubPageToolStripMenuItem";
            this.githubPageToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.githubPageToolStripMenuItem.Text = "Github Page";
            this.githubPageToolStripMenuItem.Click += new System.EventHandler(this.githubPageToolStripMenuItem_Click);
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLockers);
            this.Controls.Add(this.btnPWLib);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.pbGithub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Simple Encryption Program (SEP) - Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGithub)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbGithub;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnPWLib;
        private System.Windows.Forms.Button btnLockers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubPageToolStripMenuItem;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ToolStripMenuItem automaticTakeoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldEncryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldDecryptFileToolStripMenuItem;
    }
}