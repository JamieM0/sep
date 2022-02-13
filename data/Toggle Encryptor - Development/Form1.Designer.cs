
namespace Toggle_Encryptor___Development
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbHeading = new System.Windows.Forms.Label();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitFromAbout = new System.Windows.Forms.Button();
            this.btnContinueFromAbout = new System.Windows.Forms.Button();
            this.lbAbout1 = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbSaveETextConfirm = new System.Windows.Forms.GroupBox();
            this.btnSaveETextConfirmNo = new System.Windows.Forms.Button();
            this.btnSaveETextConfirmYes = new System.Windows.Forms.Button();
            this.lbSaveETextConfirmTitle = new System.Windows.Forms.Label();
            this.lbSaveETextConfirmMessage = new System.Windows.Forms.Label();
            this.gbConfirmPasswordSave = new System.Windows.Forms.GroupBox();
            this.btnSavePasswordConfirmNo = new System.Windows.Forms.Button();
            this.btnSavePasswordConfirmYes = new System.Windows.Forms.Button();
            this.lbSavePasswordConfirmTitle = new System.Windows.Forms.Label();
            this.lbSavePasswordConfirmMessage = new System.Windows.Forms.Label();
            this.btnSaveEncryptedText = new System.Windows.Forms.Button();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.lbPasswordLengthWarn = new System.Windows.Forms.Label();
            this.lbEncryptOutput = new System.Windows.Forms.Label();
            this.lbIns3 = new System.Windows.Forms.Label();
            this.btnConfirmInputEncrypt = new System.Windows.Forms.Button();
            this.txtEncryptInput = new System.Windows.Forms.TextBox();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.btnGenPass = new System.Windows.Forms.Button();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.btnGoToMainMenu = new System.Windows.Forms.Button();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMain.SuspendLayout();
            this.gbSaveETextConfirm.SuspendLayout();
            this.gbConfirmPasswordSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeading.Location = new System.Drawing.Point(12, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(699, 45);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Encryption Program Protocol (TEPP) - Prototype";
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.pictureBox1);
            this.gbAbout.Controls.Add(this.btnQuitFromAbout);
            this.gbAbout.Controls.Add(this.btnContinueFromAbout);
            this.gbAbout.Controls.Add(this.lbAbout1);
            this.gbAbout.Location = new System.Drawing.Point(12, 66);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(734, 319);
            this.gbAbout.TabIndex = 1;
            this.gbAbout.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitFromAbout
            // 
            this.btnQuitFromAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitFromAbout.Location = new System.Drawing.Point(28, 253);
            this.btnQuitFromAbout.Name = "btnQuitFromAbout";
            this.btnQuitFromAbout.Size = new System.Drawing.Size(90, 47);
            this.btnQuitFromAbout.TabIndex = 2;
            this.btnQuitFromAbout.Text = "Quit TEPP";
            this.btnQuitFromAbout.UseVisualStyleBackColor = true;
            // 
            // btnContinueFromAbout
            // 
            this.btnContinueFromAbout.BackColor = System.Drawing.Color.Yellow;
            this.btnContinueFromAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnContinueFromAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinueFromAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinueFromAbout.Location = new System.Drawing.Point(565, 253);
            this.btnContinueFromAbout.Name = "btnContinueFromAbout";
            this.btnContinueFromAbout.Size = new System.Drawing.Size(147, 47);
            this.btnContinueFromAbout.TabIndex = 1;
            this.btnContinueFromAbout.Text = "Continue ->";
            this.btnContinueFromAbout.UseVisualStyleBackColor = false;
            this.btnContinueFromAbout.Click += new System.EventHandler(this.btnContinueFromAbout_Click);
            // 
            // lbAbout1
            // 
            this.lbAbout1.AutoSize = true;
            this.lbAbout1.Location = new System.Drawing.Point(6, 19);
            this.lbAbout1.Name = "lbAbout1";
            this.lbAbout1.Size = new System.Drawing.Size(723, 195);
            this.lbAbout1.TabIndex = 0;
            this.lbAbout1.Text = resources.GetString("lbAbout1.Text");
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.gbSaveETextConfirm);
            this.gbMain.Controls.Add(this.gbConfirmPasswordSave);
            this.gbMain.Controls.Add(this.btnSaveEncryptedText);
            this.gbMain.Controls.Add(this.btnSavePass);
            this.gbMain.Controls.Add(this.lbPasswordLengthWarn);
            this.gbMain.Controls.Add(this.lbEncryptOutput);
            this.gbMain.Controls.Add(this.lbIns3);
            this.gbMain.Controls.Add(this.btnConfirmInputEncrypt);
            this.gbMain.Controls.Add(this.txtEncryptInput);
            this.gbMain.Controls.Add(this.lbIns2);
            this.gbMain.Controls.Add(this.btnConfirmPassword);
            this.gbMain.Controls.Add(this.btnGenPass);
            this.gbMain.Controls.Add(this.txtPasswordInput);
            this.gbMain.Controls.Add(this.lbIns1);
            this.gbMain.Location = new System.Drawing.Point(12, 66);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(734, 319);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            // 
            // gbSaveETextConfirm
            // 
            this.gbSaveETextConfirm.Controls.Add(this.btnSaveETextConfirmNo);
            this.gbSaveETextConfirm.Controls.Add(this.btnSaveETextConfirmYes);
            this.gbSaveETextConfirm.Controls.Add(this.lbSaveETextConfirmTitle);
            this.gbSaveETextConfirm.Controls.Add(this.lbSaveETextConfirmMessage);
            this.gbSaveETextConfirm.Location = new System.Drawing.Point(215, 116);
            this.gbSaveETextConfirm.Name = "gbSaveETextConfirm";
            this.gbSaveETextConfirm.Size = new System.Drawing.Size(306, 197);
            this.gbSaveETextConfirm.TabIndex = 5;
            this.gbSaveETextConfirm.TabStop = false;
            // 
            // btnSaveETextConfirmNo
            // 
            this.btnSaveETextConfirmNo.Location = new System.Drawing.Point(18, 144);
            this.btnSaveETextConfirmNo.Name = "btnSaveETextConfirmNo";
            this.btnSaveETextConfirmNo.Size = new System.Drawing.Size(93, 35);
            this.btnSaveETextConfirmNo.TabIndex = 3;
            this.btnSaveETextConfirmNo.Text = "Cancel";
            this.btnSaveETextConfirmNo.UseVisualStyleBackColor = true;
            this.btnSaveETextConfirmNo.Click += new System.EventHandler(this.btnSaveETextConfirmNo_Click);
            // 
            // btnSaveETextConfirmYes
            // 
            this.btnSaveETextConfirmYes.Location = new System.Drawing.Point(202, 144);
            this.btnSaveETextConfirmYes.Name = "btnSaveETextConfirmYes";
            this.btnSaveETextConfirmYes.Size = new System.Drawing.Size(86, 35);
            this.btnSaveETextConfirmYes.TabIndex = 2;
            this.btnSaveETextConfirmYes.Text = "Ok";
            this.btnSaveETextConfirmYes.UseVisualStyleBackColor = true;
            this.btnSaveETextConfirmYes.Click += new System.EventHandler(this.btnSaveETextConfirmYes_Click);
            // 
            // lbSaveETextConfirmTitle
            // 
            this.lbSaveETextConfirmTitle.AutoSize = true;
            this.lbSaveETextConfirmTitle.Location = new System.Drawing.Point(1, 24);
            this.lbSaveETextConfirmTitle.Name = "lbSaveETextConfirmTitle";
            this.lbSaveETextConfirmTitle.Size = new System.Drawing.Size(116, 15);
            this.lbSaveETextConfirmTitle.TabIndex = 1;
            this.lbSaveETextConfirmTitle.Text = "Save Encrypted Text?";
            // 
            // lbSaveETextConfirmMessage
            // 
            this.lbSaveETextConfirmMessage.AutoSize = true;
            this.lbSaveETextConfirmMessage.Location = new System.Drawing.Point(1, 58);
            this.lbSaveETextConfirmMessage.Name = "lbSaveETextConfirmMessage";
            this.lbSaveETextConfirmMessage.Size = new System.Drawing.Size(305, 45);
            this.lbSaveETextConfirmMessage.TabIndex = 0;
            this.lbSaveETextConfirmMessage.Text = "You are about to save a text (.txt) file in your documents \r\nfolder which is call" +
    "ed TEPPEText and contains your \r\nencrypted text.";
            // 
            // gbConfirmPasswordSave
            // 
            this.gbConfirmPasswordSave.Controls.Add(this.btnSavePasswordConfirmNo);
            this.gbConfirmPasswordSave.Controls.Add(this.btnSavePasswordConfirmYes);
            this.gbConfirmPasswordSave.Controls.Add(this.lbSavePasswordConfirmTitle);
            this.gbConfirmPasswordSave.Controls.Add(this.lbSavePasswordConfirmMessage);
            this.gbConfirmPasswordSave.Location = new System.Drawing.Point(233, 25);
            this.gbConfirmPasswordSave.Name = "gbConfirmPasswordSave";
            this.gbConfirmPasswordSave.Size = new System.Drawing.Size(306, 197);
            this.gbConfirmPasswordSave.TabIndex = 4;
            this.gbConfirmPasswordSave.TabStop = false;
            // 
            // btnSavePasswordConfirmNo
            // 
            this.btnSavePasswordConfirmNo.Location = new System.Drawing.Point(18, 144);
            this.btnSavePasswordConfirmNo.Name = "btnSavePasswordConfirmNo";
            this.btnSavePasswordConfirmNo.Size = new System.Drawing.Size(93, 35);
            this.btnSavePasswordConfirmNo.TabIndex = 3;
            this.btnSavePasswordConfirmNo.Text = "Cancel";
            this.btnSavePasswordConfirmNo.UseVisualStyleBackColor = true;
            this.btnSavePasswordConfirmNo.Click += new System.EventHandler(this.btnSavePasswordConfirmNo_Click);
            // 
            // btnSavePasswordConfirmYes
            // 
            this.btnSavePasswordConfirmYes.Location = new System.Drawing.Point(202, 144);
            this.btnSavePasswordConfirmYes.Name = "btnSavePasswordConfirmYes";
            this.btnSavePasswordConfirmYes.Size = new System.Drawing.Size(86, 35);
            this.btnSavePasswordConfirmYes.TabIndex = 2;
            this.btnSavePasswordConfirmYes.Text = "Ok";
            this.btnSavePasswordConfirmYes.UseVisualStyleBackColor = true;
            this.btnSavePasswordConfirmYes.Click += new System.EventHandler(this.btnSavePasswordConfirmYes_Click);
            // 
            // lbSavePasswordConfirmTitle
            // 
            this.lbSavePasswordConfirmTitle.AutoSize = true;
            this.lbSavePasswordConfirmTitle.Location = new System.Drawing.Point(1, 24);
            this.lbSavePasswordConfirmTitle.Name = "lbSavePasswordConfirmTitle";
            this.lbSavePasswordConfirmTitle.Size = new System.Drawing.Size(89, 15);
            this.lbSavePasswordConfirmTitle.TabIndex = 1;
            this.lbSavePasswordConfirmTitle.Text = "Save Password?";
            // 
            // lbSavePasswordConfirmMessage
            // 
            this.lbSavePasswordConfirmMessage.AutoSize = true;
            this.lbSavePasswordConfirmMessage.Location = new System.Drawing.Point(1, 58);
            this.lbSavePasswordConfirmMessage.Name = "lbSavePasswordConfirmMessage";
            this.lbSavePasswordConfirmMessage.Size = new System.Drawing.Size(305, 45);
            this.lbSavePasswordConfirmMessage.TabIndex = 0;
            this.lbSavePasswordConfirmMessage.Text = "You are about to save a text (.txt) file in your documents \r\nfolder which is call" +
    "ed your password and contains your \r\npassword.";
            // 
            // btnSaveEncryptedText
            // 
            this.btnSaveEncryptedText.Location = new System.Drawing.Point(322, 229);
            this.btnSaveEncryptedText.Name = "btnSaveEncryptedText";
            this.btnSaveEncryptedText.Size = new System.Drawing.Size(45, 23);
            this.btnSaveEncryptedText.TabIndex = 11;
            this.btnSaveEncryptedText.Text = "Save";
            this.btnSaveEncryptedText.UseVisualStyleBackColor = true;
            this.btnSaveEncryptedText.Click += new System.EventHandler(this.btnSaveEncryptedText_Click);
            // 
            // btnSavePass
            // 
            this.btnSavePass.Location = new System.Drawing.Point(373, 64);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(45, 23);
            this.btnSavePass.TabIndex = 10;
            this.btnSavePass.Text = "Save";
            this.btnSavePass.UseVisualStyleBackColor = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // lbPasswordLengthWarn
            // 
            this.lbPasswordLengthWarn.AutoSize = true;
            this.lbPasswordLengthWarn.Location = new System.Drawing.Point(615, 55);
            this.lbPasswordLengthWarn.Name = "lbPasswordLengthWarn";
            this.lbPasswordLengthWarn.Size = new System.Drawing.Size(119, 30);
            this.lbPasswordLengthWarn.TabIndex = 9;
            this.lbPasswordLengthWarn.Text = "Password must be \r\nexactly 16 characters.";
            // 
            // lbEncryptOutput
            // 
            this.lbEncryptOutput.AutoSize = true;
            this.lbEncryptOutput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEncryptOutput.Location = new System.Drawing.Point(52, 265);
            this.lbEncryptOutput.Name = "lbEncryptOutput";
            this.lbEncryptOutput.Size = new System.Drawing.Size(143, 25);
            this.lbEncryptOutput.TabIndex = 8;
            this.lbEncryptOutput.Text = "abcimherehehe";
            // 
            // lbIns3
            // 
            this.lbIns3.AutoSize = true;
            this.lbIns3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns3.Location = new System.Drawing.Point(38, 225);
            this.lbIns3.Name = "lbIns3";
            this.lbIns3.Size = new System.Drawing.Size(270, 25);
            this.lbIns3.TabIndex = 7;
            this.lbIns3.Text = "3. Here\'s the encrypted phrase.";
            // 
            // btnConfirmInputEncrypt
            // 
            this.btnConfirmInputEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmInputEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmInputEncrypt.Location = new System.Drawing.Point(517, 160);
            this.btnConfirmInputEncrypt.Name = "btnConfirmInputEncrypt";
            this.btnConfirmInputEncrypt.Size = new System.Drawing.Size(101, 32);
            this.btnConfirmInputEncrypt.TabIndex = 6;
            this.btnConfirmInputEncrypt.Text = "Confirm";
            this.btnConfirmInputEncrypt.UseVisualStyleBackColor = true;
            this.btnConfirmInputEncrypt.Click += new System.EventHandler(this.btnConfirmInputEncrypt_Click);
            // 
            // txtEncryptInput
            // 
            this.txtEncryptInput.Location = new System.Drawing.Point(52, 169);
            this.txtEncryptInput.Name = "txtEncryptInput";
            this.txtEncryptInput.Size = new System.Drawing.Size(366, 23);
            this.txtEncryptInput.TabIndex = 5;
            // 
            // lbIns2
            // 
            this.lbIns2.AutoSize = true;
            this.lbIns2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns2.Location = new System.Drawing.Point(38, 128);
            this.lbIns2.Name = "lbIns2";
            this.lbIns2.Size = new System.Drawing.Size(406, 25);
            this.lbIns2.TabIndex = 4;
            this.lbIns2.Text = "2. Enter a string to encrypt with your password.";
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPassword.Location = new System.Drawing.Point(517, 55);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(101, 32);
            this.btnConfirmPassword.TabIndex = 3;
            this.btnConfirmPassword.Text = "Confirm";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPass_Click);
            // 
            // btnGenPass
            // 
            this.btnGenPass.Location = new System.Drawing.Point(240, 64);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(127, 23);
            this.btnGenPass.TabIndex = 2;
            this.btnGenPass.Text = "Generate a Password";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Click += new System.EventHandler(this.btnGenPass_Click);
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.Location = new System.Drawing.Point(52, 64);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.PasswordChar = '*';
            this.txtPasswordInput.Size = new System.Drawing.Size(182, 23);
            this.txtPasswordInput.TabIndex = 1;
            // 
            // lbIns1
            // 
            this.lbIns1.AutoSize = true;
            this.lbIns1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns1.Location = new System.Drawing.Point(38, 24);
            this.lbIns1.Name = "lbIns1";
            this.lbIns1.Size = new System.Drawing.Size(395, 25);
            this.lbIns1.TabIndex = 0;
            this.lbIns1.Text = "1. Enter a password to encrypt the string with.";
            // 
            // btnGoToMainMenu
            // 
            this.btnGoToMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToMainMenu.Location = new System.Drawing.Point(543, 402);
            this.btnGoToMainMenu.Name = "btnGoToMainMenu";
            this.btnGoToMainMenu.Size = new System.Drawing.Size(168, 36);
            this.btnGoToMainMenu.TabIndex = 4;
            this.btnGoToMainMenu.Text = "Back to main menu";
            this.btnGoToMainMenu.UseVisualStyleBackColor = true;
            this.btnGoToMainMenu.Click += new System.EventHandler(this.btnGoToMainMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToMainMenu);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbAbout);
            this.Name = "Form1";
            this.Text = "TEPP- Prototype";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbSaveETextConfirm.ResumeLayout(false);
            this.gbSaveETextConfirm.PerformLayout();
            this.gbConfirmPasswordSave.ResumeLayout(false);
            this.gbConfirmPasswordSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.Label lbAbout1;
        private System.Windows.Forms.Button btnQuitFromAbout;
        private System.Windows.Forms.Button btnContinueFromAbout;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEncryptInput;
        private System.Windows.Forms.Label lbIns2;
        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.Button btnConfirmInputEncrypt;
        private System.Windows.Forms.Label lbEncryptOutput;
        private System.Windows.Forms.Label lbIns3;
        private System.Windows.Forms.Label lbPasswordLengthWarn;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.Button btnSaveEncryptedText;
        private System.Windows.Forms.GroupBox gbConfirmPasswordSave;
        private System.Windows.Forms.Label lbSavePasswordConfirmMessage;
        private System.Windows.Forms.Button btnSavePasswordConfirmNo;
        private System.Windows.Forms.Button btnSavePasswordConfirmYes;
        private System.Windows.Forms.Label lbSavePasswordConfirmTitle;
        private System.Windows.Forms.GroupBox gbSaveETextConfirm;
        private System.Windows.Forms.Button btnSaveETextConfirmNo;
        private System.Windows.Forms.Button btnSaveETextConfirmYes;
        private System.Windows.Forms.Label lbSaveETextConfirmTitle;
        private System.Windows.Forms.Label lbSaveETextConfirmMessage;
        private System.Windows.Forms.Button btnGoToMainMenu;
    }
}

