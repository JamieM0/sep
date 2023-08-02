namespace sep
{
    partial class frmEncryptFile
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
            this.lbHeading = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnAuthenticator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKeepOriginal = new System.Windows.Forms.CheckBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.btnGenPass = new System.Windows.Forms.Button();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAuthApp = new System.Windows.Forms.Panel();
            this.btnConfirmAuthSetup = new System.Windows.Forms.Button();
            this.txtAuthSetupVerify = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbS1 = new System.Windows.Forms.Label();
            this.pbQRAuthSetup = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAuthApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRAuthSetup)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeading.Location = new System.Drawing.Point(12, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(487, 45);
            this.lbHeading.TabIndex = 1;
            this.lbHeading.Text = "Simple Encryption Program (SEP)";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnAuthenticator);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.cbKeepOriginal);
            this.gbMain.Controls.Add(this.lbFilePath);
            this.gbMain.Controls.Add(this.btnOpen);
            this.gbMain.Controls.Add(this.btnSavePass);
            this.gbMain.Controls.Add(this.btnGo);
            this.gbMain.Controls.Add(this.lbIns2);
            this.gbMain.Controls.Add(this.btnConfirmPassword);
            this.gbMain.Controls.Add(this.btnGenPass);
            this.gbMain.Controls.Add(this.txtPasswordInput);
            this.gbMain.Controls.Add(this.lbIns1);
            this.gbMain.Controls.Add(this.pictureBox1);
            this.gbMain.Controls.Add(this.pictureBox2);
            this.gbMain.Location = new System.Drawing.Point(33, 66);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(734, 372);
            this.gbMain.TabIndex = 4;
            this.gbMain.TabStop = false;
            this.gbMain.Enter += new System.EventHandler(this.gbMain_Enter);
            // 
            // btnAuthenticator
            // 
            this.btnAuthenticator.Enabled = false;
            this.btnAuthenticator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuthenticator.Location = new System.Drawing.Point(6, 278);
            this.btnAuthenticator.Name = "btnAuthenticator";
            this.btnAuthenticator.Size = new System.Drawing.Size(217, 30);
            this.btnAuthenticator.TabIndex = 18;
            this.btnAuthenticator.Text = "Use Authenticator";
            this.btnAuthenticator.UseVisualStyleBackColor = true;
            this.btnAuthenticator.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Also use authenticator (MFA) app.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbKeepOriginal
            // 
            this.cbKeepOriginal.AutoSize = true;
            this.cbKeepOriginal.Checked = true;
            this.cbKeepOriginal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeepOriginal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbKeepOriginal.Location = new System.Drawing.Point(84, 332);
            this.cbKeepOriginal.Name = "cbKeepOriginal";
            this.cbKeepOriginal.Size = new System.Drawing.Size(427, 29);
            this.cbKeepOriginal.TabIndex = 14;
            this.cbKeepOriginal.Text = "Would you like to keep the original file as well?";
            this.cbKeepOriginal.UseVisualStyleBackColor = true;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFilePath.Location = new System.Drawing.Point(274, 61);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(0, 21);
            this.lbFilePath.TabIndex = 13;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(126, 56);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(133, 30);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnSavePasswordOpen_Click);
            // 
            // btnSavePass
            // 
            this.btnSavePass.Enabled = false;
            this.btnSavePass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSavePass.Location = new System.Drawing.Point(349, 187);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(95, 30);
            this.btnSavePass.TabIndex = 10;
            this.btnSavePass.Text = "Save";
            this.btnSavePass.UseVisualStyleBackColor = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(542, 323);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(186, 43);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Encrypt it!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnConfirmInputEncrypt_Click);
            // 
            // lbIns2
            // 
            this.lbIns2.AutoSize = true;
            this.lbIns2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns2.Location = new System.Drawing.Point(126, 29);
            this.lbIns2.Name = "lbIns2";
            this.lbIns2.Size = new System.Drawing.Size(331, 25);
            this.lbIns2.TabIndex = 4;
            this.lbIns2.Text = "Find file to encrypt with the password.";
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPassword.Location = new System.Drawing.Point(627, 22);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(101, 32);
            this.btnConfirmPassword.TabIndex = 3;
            this.btnConfirmPassword.Text = "Confirm";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            this.btnConfirmPassword.Visible = false;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPassword_Click);
            // 
            // btnGenPass
            // 
            this.btnGenPass.Enabled = false;
            this.btnGenPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenPass.Location = new System.Drawing.Point(125, 187);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(218, 30);
            this.btnGenPass.TabIndex = 2;
            this.btnGenPass.Text = "Generate a Password";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Click += new System.EventHandler(this.btnGenPass_Click);
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.Enabled = false;
            this.txtPasswordInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordInput.Location = new System.Drawing.Point(125, 156);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.PasswordChar = '*';
            this.txtPasswordInput.Size = new System.Drawing.Size(319, 25);
            this.txtPasswordInput.TabIndex = 1;
            this.txtPasswordInput.TextChanged += new System.EventHandler(this.txtPasswordInput_TextChanged);
            // 
            // lbIns1
            // 
            this.lbIns1.AutoSize = true;
            this.lbIns1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns1.Location = new System.Drawing.Point(125, 128);
            this.lbIns1.Name = "lbIns1";
            this.lbIns1.Size = new System.Drawing.Size(354, 25);
            this.lbIns1.TabIndex = 0;
            this.lbIns1.Text = "Enter a password to encrypt the file with.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sep.Properties.Resources._1_fixed;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sep.Properties.Resources._2_fixed;
            this.pictureBox2.Location = new System.Drawing.Point(-21, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(635, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 45);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlAuthApp
            // 
            this.pnlAuthApp.Controls.Add(this.btnConfirmAuthSetup);
            this.pnlAuthApp.Controls.Add(this.txtAuthSetupVerify);
            this.pnlAuthApp.Controls.Add(this.label3);
            this.pnlAuthApp.Controls.Add(this.lbS1);
            this.pnlAuthApp.Controls.Add(this.pbQRAuthSetup);
            this.pnlAuthApp.Controls.Add(this.label2);
            this.pnlAuthApp.Location = new System.Drawing.Point(17, 66);
            this.pnlAuthApp.Name = "pnlAuthApp";
            this.pnlAuthApp.Size = new System.Drawing.Size(763, 382);
            this.pnlAuthApp.TabIndex = 6;
            // 
            // btnConfirmAuthSetup
            // 
            this.btnConfirmAuthSetup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmAuthSetup.Location = new System.Drawing.Point(365, 269);
            this.btnConfirmAuthSetup.Name = "btnConfirmAuthSetup";
            this.btnConfirmAuthSetup.Size = new System.Drawing.Size(379, 39);
            this.btnConfirmAuthSetup.TabIndex = 5;
            this.btnConfirmAuthSetup.Text = "Confirm";
            this.btnConfirmAuthSetup.UseVisualStyleBackColor = true;
            this.btnConfirmAuthSetup.Click += new System.EventHandler(this.btnConfirmAuthSetup_Click);
            // 
            // txtAuthSetupVerify
            // 
            this.txtAuthSetupVerify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthSetupVerify.Location = new System.Drawing.Point(618, 201);
            this.txtAuthSetupVerify.Name = "txtAuthSetupVerify";
            this.txtAuthSetupVerify.Size = new System.Drawing.Size(108, 33);
            this.txtAuthSetupVerify.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "2. Enter the current code:";
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbS1.Location = new System.Drawing.Point(365, 121);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(310, 60);
            this.lbS1.TabIndex = 2;
            this.lbS1.Text = "1. Scan the QR code using your \r\nauthenticator app.";
            // 
            // pbQRAuthSetup
            // 
            this.pbQRAuthSetup.Location = new System.Drawing.Point(22, 61);
            this.pbQRAuthSetup.Name = "pbQRAuthSetup";
            this.pbQRAuthSetup.Size = new System.Drawing.Size(331, 294);
            this.pbQRAuthSetup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQRAuthSetup.TabIndex = 1;
            this.pbQRAuthSetup.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add an authenticator (MFA) app.";
            // 
            // frmEncryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAuthApp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.lbHeading);
            this.Name = "frmEncryptFile";
            this.Text = "Encrypt File";
            this.Load += new System.EventHandler(this.frmEncryptFile_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAuthApp.ResumeLayout(false);
            this.pnlAuthApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRAuthSetup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lbIns2;
        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.CheckBox cbKeepOriginal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAuthenticator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAuthApp;
        private System.Windows.Forms.Button btnConfirmAuthSetup;
        private System.Windows.Forms.TextBox txtAuthSetupVerify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbS1;
        private System.Windows.Forms.PictureBox pbQRAuthSetup;
        private System.Windows.Forms.Label label2;
    }
}