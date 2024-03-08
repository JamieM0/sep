
namespace sep
{
    partial class frmEncryptString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncryptString));
            lbHeading = new System.Windows.Forms.Label();
            gbAbout = new System.Windows.Forms.GroupBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnQuitFromAbout = new System.Windows.Forms.Button();
            btnContinueFromAbout = new System.Windows.Forms.Button();
            lbAbout1 = new System.Windows.Forms.Label();
            gbMain = new System.Windows.Forms.GroupBox();
            btnCopy = new System.Windows.Forms.Button();
            btnSaveEncryptedText = new System.Windows.Forms.Button();
            lbPasswordLengthWarn = new System.Windows.Forms.Label();
            btnSavePass = new System.Windows.Forms.Button();
            lbEncryptOutput = new System.Windows.Forms.Label();
            lbIns3 = new System.Windows.Forms.Label();
            btnConfirmInputEncrypt = new System.Windows.Forms.Button();
            txtEncryptInput = new System.Windows.Forms.TextBox();
            btnGenPass = new System.Windows.Forms.Button();
            lbIns2 = new System.Windows.Forms.Label();
            btnConfirmPassword = new System.Windows.Forms.Button();
            txtPasswordInput = new System.Windows.Forms.TextBox();
            lbIns1 = new System.Windows.Forms.Label();
            gbConfirmPasswordSave = new System.Windows.Forms.GroupBox();
            btnSavePasswordConfirmNo = new System.Windows.Forms.Button();
            btnSavePasswordConfirmYes = new System.Windows.Forms.Button();
            lbSavePasswordConfirmTitle = new System.Windows.Forms.Label();
            lbSavePasswordConfirmMessage = new System.Windows.Forms.Label();
            gbSaveETextConfirm = new System.Windows.Forms.GroupBox();
            btnSaveETextConfirmNo = new System.Windows.Forms.Button();
            btnSaveETextConfirmYes = new System.Windows.Forms.Button();
            lbSaveETextConfirmTitle = new System.Windows.Forms.Label();
            lbSaveETextConfirmMessage = new System.Windows.Forms.Label();
            btnGoToMainMenu = new System.Windows.Forms.Button();
            gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbMain.SuspendLayout();
            gbConfirmPasswordSave.SuspendLayout();
            gbSaveETextConfirm.SuspendLayout();
            SuspendLayout();
            // 
            // lbHeading
            // 
            lbHeading.AutoSize = true;
            lbHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbHeading.Location = new System.Drawing.Point(12, 9);
            lbHeading.Name = "lbHeading";
            lbHeading.Size = new System.Drawing.Size(487, 45);
            lbHeading.TabIndex = 0;
            lbHeading.Text = "Simple Encryption Program (SEP)";
            // 
            // gbAbout
            // 
            gbAbout.Controls.Add(pictureBox1);
            gbAbout.Controls.Add(btnQuitFromAbout);
            gbAbout.Controls.Add(btnContinueFromAbout);
            gbAbout.Controls.Add(lbAbout1);
            gbAbout.Location = new System.Drawing.Point(12, 66);
            gbAbout.Name = "gbAbout";
            gbAbout.Size = new System.Drawing.Size(734, 319);
            gbAbout.TabIndex = 1;
            gbAbout.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnQuitFromAbout
            // 
            btnQuitFromAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuitFromAbout.Location = new System.Drawing.Point(28, 253);
            btnQuitFromAbout.Name = "btnQuitFromAbout";
            btnQuitFromAbout.Size = new System.Drawing.Size(90, 47);
            btnQuitFromAbout.TabIndex = 2;
            btnQuitFromAbout.Text = "Quit TEPP";
            btnQuitFromAbout.UseVisualStyleBackColor = true;
            // 
            // btnContinueFromAbout
            // 
            btnContinueFromAbout.BackColor = System.Drawing.Color.Yellow;
            btnContinueFromAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnContinueFromAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnContinueFromAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            btnContinueFromAbout.Location = new System.Drawing.Point(565, 253);
            btnContinueFromAbout.Name = "btnContinueFromAbout";
            btnContinueFromAbout.Size = new System.Drawing.Size(147, 47);
            btnContinueFromAbout.TabIndex = 1;
            btnContinueFromAbout.Text = "Continue ->";
            btnContinueFromAbout.UseVisualStyleBackColor = false;
            btnContinueFromAbout.Click += btnContinueFromAbout_Click;
            // 
            // lbAbout1
            // 
            lbAbout1.AutoSize = true;
            lbAbout1.Location = new System.Drawing.Point(6, 19);
            lbAbout1.Name = "lbAbout1";
            lbAbout1.Size = new System.Drawing.Size(723, 195);
            lbAbout1.TabIndex = 0;
            lbAbout1.Text = resources.GetString("lbAbout1.Text");
            // 
            // gbMain
            // 
            gbMain.Controls.Add(btnCopy);
            gbMain.Controls.Add(btnSaveEncryptedText);
            gbMain.Controls.Add(lbPasswordLengthWarn);
            gbMain.Controls.Add(btnSavePass);
            gbMain.Controls.Add(lbEncryptOutput);
            gbMain.Controls.Add(lbIns3);
            gbMain.Controls.Add(btnConfirmInputEncrypt);
            gbMain.Controls.Add(txtEncryptInput);
            gbMain.Controls.Add(btnGenPass);
            gbMain.Controls.Add(lbIns2);
            gbMain.Controls.Add(btnConfirmPassword);
            gbMain.Controls.Add(txtPasswordInput);
            gbMain.Controls.Add(lbIns1);
            gbMain.Controls.Add(gbConfirmPasswordSave);
            gbMain.Controls.Add(gbSaveETextConfirm);
            gbMain.Location = new System.Drawing.Point(12, 66);
            gbMain.Name = "gbMain";
            gbMain.Size = new System.Drawing.Size(734, 319);
            gbMain.TabIndex = 3;
            gbMain.TabStop = false;
            // 
            // btnCopy
            // 
            btnCopy.Location = new System.Drawing.Point(424, 65);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(45, 23);
            btnCopy.TabIndex = 11;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Visible = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnSaveEncryptedText
            // 
            btnSaveEncryptedText.Location = new System.Drawing.Point(322, 229);
            btnSaveEncryptedText.Name = "btnSaveEncryptedText";
            btnSaveEncryptedText.Size = new System.Drawing.Size(45, 23);
            btnSaveEncryptedText.TabIndex = 11;
            btnSaveEncryptedText.Text = "Copy";
            btnSaveEncryptedText.UseVisualStyleBackColor = true;
            btnSaveEncryptedText.Click += btnSaveEncryptedText_Click;
            // 
            // lbPasswordLengthWarn
            // 
            lbPasswordLengthWarn.AutoSize = true;
            lbPasswordLengthWarn.Location = new System.Drawing.Point(615, 55);
            lbPasswordLengthWarn.Name = "lbPasswordLengthWarn";
            lbPasswordLengthWarn.Size = new System.Drawing.Size(119, 30);
            lbPasswordLengthWarn.TabIndex = 9;
            lbPasswordLengthWarn.Text = "Password must be \r\nexactly 16 characters.";
            lbPasswordLengthWarn.Visible = false;
            // 
            // btnSavePass
            // 
            btnSavePass.Location = new System.Drawing.Point(373, 65);
            btnSavePass.Name = "btnSavePass";
            btnSavePass.Size = new System.Drawing.Size(45, 23);
            btnSavePass.TabIndex = 10;
            btnSavePass.Text = "Save";
            btnSavePass.UseVisualStyleBackColor = true;
            btnSavePass.Visible = false;
            btnSavePass.Click += btnSavePass_Click;
            // 
            // lbEncryptOutput
            // 
            lbEncryptOutput.AutoSize = true;
            lbEncryptOutput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbEncryptOutput.Location = new System.Drawing.Point(52, 265);
            lbEncryptOutput.Name = "lbEncryptOutput";
            lbEncryptOutput.Size = new System.Drawing.Size(143, 25);
            lbEncryptOutput.TabIndex = 8;
            lbEncryptOutput.Text = "abcimherehehe";
            // 
            // lbIns3
            // 
            lbIns3.AutoSize = true;
            lbIns3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns3.Location = new System.Drawing.Point(38, 225);
            lbIns3.Name = "lbIns3";
            lbIns3.Size = new System.Drawing.Size(270, 25);
            lbIns3.TabIndex = 7;
            lbIns3.Text = "3. Here's the encrypted phrase.";
            // 
            // btnConfirmInputEncrypt
            // 
            btnConfirmInputEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmInputEncrypt.ForeColor = System.Drawing.Color.Black;
            btnConfirmInputEncrypt.Location = new System.Drawing.Point(517, 160);
            btnConfirmInputEncrypt.Name = "btnConfirmInputEncrypt";
            btnConfirmInputEncrypt.Size = new System.Drawing.Size(101, 32);
            btnConfirmInputEncrypt.TabIndex = 6;
            btnConfirmInputEncrypt.Text = "Confirm";
            btnConfirmInputEncrypt.UseVisualStyleBackColor = true;
            btnConfirmInputEncrypt.Click += btnConfirmInputEncrypt_Click;
            // 
            // txtEncryptInput
            // 
            txtEncryptInput.Location = new System.Drawing.Point(52, 169);
            txtEncryptInput.Name = "txtEncryptInput";
            txtEncryptInput.Size = new System.Drawing.Size(366, 23);
            txtEncryptInput.TabIndex = 5;
            // 
            // btnGenPass
            // 
            btnGenPass.Location = new System.Drawing.Point(240, 64);
            btnGenPass.Name = "btnGenPass";
            btnGenPass.Size = new System.Drawing.Size(127, 23);
            btnGenPass.TabIndex = 2;
            btnGenPass.Text = "Generate a Password";
            btnGenPass.UseVisualStyleBackColor = true;
            btnGenPass.Click += btnGenPass_Click;
            // 
            // lbIns2
            // 
            lbIns2.AutoSize = true;
            lbIns2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns2.Location = new System.Drawing.Point(38, 128);
            lbIns2.Name = "lbIns2";
            lbIns2.Size = new System.Drawing.Size(406, 25);
            lbIns2.TabIndex = 4;
            lbIns2.Text = "2. Enter a string to encrypt with your password.";
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            btnConfirmPassword.Location = new System.Drawing.Point(517, 55);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new System.Drawing.Size(101, 32);
            btnConfirmPassword.TabIndex = 3;
            btnConfirmPassword.Text = "Confirm";
            btnConfirmPassword.UseVisualStyleBackColor = true;
            btnConfirmPassword.Click += btnConfirmPass_Click;
            // 
            // txtPasswordInput
            // 
            txtPasswordInput.Location = new System.Drawing.Point(52, 64);
            txtPasswordInput.Name = "txtPasswordInput";
            txtPasswordInput.PasswordChar = '*';
            txtPasswordInput.Size = new System.Drawing.Size(182, 23);
            txtPasswordInput.TabIndex = 1;
            // 
            // lbIns1
            // 
            lbIns1.AutoSize = true;
            lbIns1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns1.Location = new System.Drawing.Point(38, 24);
            lbIns1.Name = "lbIns1";
            lbIns1.Size = new System.Drawing.Size(395, 25);
            lbIns1.TabIndex = 0;
            lbIns1.Text = "1. Enter a password to encrypt the string with.";
            // 
            // gbConfirmPasswordSave
            // 
            gbConfirmPasswordSave.Controls.Add(btnSavePasswordConfirmNo);
            gbConfirmPasswordSave.Controls.Add(btnSavePasswordConfirmYes);
            gbConfirmPasswordSave.Controls.Add(lbSavePasswordConfirmTitle);
            gbConfirmPasswordSave.Controls.Add(lbSavePasswordConfirmMessage);
            gbConfirmPasswordSave.Location = new System.Drawing.Point(197, 52);
            gbConfirmPasswordSave.Name = "gbConfirmPasswordSave";
            gbConfirmPasswordSave.Size = new System.Drawing.Size(306, 197);
            gbConfirmPasswordSave.TabIndex = 4;
            gbConfirmPasswordSave.TabStop = false;
            // 
            // btnSavePasswordConfirmNo
            // 
            btnSavePasswordConfirmNo.Location = new System.Drawing.Point(18, 144);
            btnSavePasswordConfirmNo.Name = "btnSavePasswordConfirmNo";
            btnSavePasswordConfirmNo.Size = new System.Drawing.Size(93, 35);
            btnSavePasswordConfirmNo.TabIndex = 3;
            btnSavePasswordConfirmNo.Text = "Cancel";
            btnSavePasswordConfirmNo.UseVisualStyleBackColor = true;
            btnSavePasswordConfirmNo.Click += btnSavePasswordConfirmNo_Click;
            // 
            // btnSavePasswordConfirmYes
            // 
            btnSavePasswordConfirmYes.Location = new System.Drawing.Point(202, 144);
            btnSavePasswordConfirmYes.Name = "btnSavePasswordConfirmYes";
            btnSavePasswordConfirmYes.Size = new System.Drawing.Size(86, 35);
            btnSavePasswordConfirmYes.TabIndex = 2;
            btnSavePasswordConfirmYes.Text = "Ok";
            btnSavePasswordConfirmYes.UseVisualStyleBackColor = true;
            btnSavePasswordConfirmYes.Click += btnSavePasswordConfirmYes_Click;
            // 
            // lbSavePasswordConfirmTitle
            // 
            lbSavePasswordConfirmTitle.AutoSize = true;
            lbSavePasswordConfirmTitle.Location = new System.Drawing.Point(1, 24);
            lbSavePasswordConfirmTitle.Name = "lbSavePasswordConfirmTitle";
            lbSavePasswordConfirmTitle.Size = new System.Drawing.Size(89, 15);
            lbSavePasswordConfirmTitle.TabIndex = 1;
            lbSavePasswordConfirmTitle.Text = "Save Password?";
            // 
            // lbSavePasswordConfirmMessage
            // 
            lbSavePasswordConfirmMessage.AutoSize = true;
            lbSavePasswordConfirmMessage.Location = new System.Drawing.Point(1, 58);
            lbSavePasswordConfirmMessage.Name = "lbSavePasswordConfirmMessage";
            lbSavePasswordConfirmMessage.Size = new System.Drawing.Size(305, 45);
            lbSavePasswordConfirmMessage.TabIndex = 0;
            lbSavePasswordConfirmMessage.Text = "You are about to save a text (.txt) file in your documents \r\nfolder which is called your password and contains your \r\npassword.";
            // 
            // gbSaveETextConfirm
            // 
            gbSaveETextConfirm.Controls.Add(btnSaveETextConfirmNo);
            gbSaveETextConfirm.Controls.Add(btnSaveETextConfirmYes);
            gbSaveETextConfirm.Controls.Add(lbSaveETextConfirmTitle);
            gbSaveETextConfirm.Controls.Add(lbSaveETextConfirmMessage);
            gbSaveETextConfirm.Location = new System.Drawing.Point(215, 116);
            gbSaveETextConfirm.Name = "gbSaveETextConfirm";
            gbSaveETextConfirm.Size = new System.Drawing.Size(306, 197);
            gbSaveETextConfirm.TabIndex = 5;
            gbSaveETextConfirm.TabStop = false;
            // 
            // btnSaveETextConfirmNo
            // 
            btnSaveETextConfirmNo.Location = new System.Drawing.Point(18, 144);
            btnSaveETextConfirmNo.Name = "btnSaveETextConfirmNo";
            btnSaveETextConfirmNo.Size = new System.Drawing.Size(93, 35);
            btnSaveETextConfirmNo.TabIndex = 3;
            btnSaveETextConfirmNo.Text = "Cancel";
            btnSaveETextConfirmNo.UseVisualStyleBackColor = true;
            btnSaveETextConfirmNo.Click += btnSaveETextConfirmNo_Click;
            // 
            // btnSaveETextConfirmYes
            // 
            btnSaveETextConfirmYes.Location = new System.Drawing.Point(202, 144);
            btnSaveETextConfirmYes.Name = "btnSaveETextConfirmYes";
            btnSaveETextConfirmYes.Size = new System.Drawing.Size(86, 35);
            btnSaveETextConfirmYes.TabIndex = 2;
            btnSaveETextConfirmYes.Text = "Ok";
            btnSaveETextConfirmYes.UseVisualStyleBackColor = true;
            btnSaveETextConfirmYes.Click += btnSaveETextConfirmYes_Click;
            // 
            // lbSaveETextConfirmTitle
            // 
            lbSaveETextConfirmTitle.AutoSize = true;
            lbSaveETextConfirmTitle.Location = new System.Drawing.Point(1, 24);
            lbSaveETextConfirmTitle.Name = "lbSaveETextConfirmTitle";
            lbSaveETextConfirmTitle.Size = new System.Drawing.Size(116, 15);
            lbSaveETextConfirmTitle.TabIndex = 1;
            lbSaveETextConfirmTitle.Text = "Save Encrypted Text?";
            // 
            // lbSaveETextConfirmMessage
            // 
            lbSaveETextConfirmMessage.AutoSize = true;
            lbSaveETextConfirmMessage.Location = new System.Drawing.Point(1, 58);
            lbSaveETextConfirmMessage.Name = "lbSaveETextConfirmMessage";
            lbSaveETextConfirmMessage.Size = new System.Drawing.Size(305, 45);
            lbSaveETextConfirmMessage.TabIndex = 0;
            lbSaveETextConfirmMessage.Text = "You are about to save a text (.txt) file in your documents \r\nfolder which is called TEPPEText and contains your \r\nencrypted text.";
            // 
            // btnGoToMainMenu
            // 
            btnGoToMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGoToMainMenu.Location = new System.Drawing.Point(543, 402);
            btnGoToMainMenu.Name = "btnGoToMainMenu";
            btnGoToMainMenu.Size = new System.Drawing.Size(168, 36);
            btnGoToMainMenu.TabIndex = 4;
            btnGoToMainMenu.Text = "Back to main menu";
            btnGoToMainMenu.UseVisualStyleBackColor = true;
            btnGoToMainMenu.Click += btnGoToMainMenu_Click;
            // 
            // frmEncryptString
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnGoToMainMenu);
            Controls.Add(lbHeading);
            Controls.Add(gbMain);
            Controls.Add(gbAbout);
            Name = "frmEncryptString";
            Text = "TEPP- Prototype";
            Load += Form1_Load;
            gbAbout.ResumeLayout(false);
            gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbMain.ResumeLayout(false);
            gbMain.PerformLayout();
            gbConfirmPasswordSave.ResumeLayout(false);
            gbConfirmPasswordSave.PerformLayout();
            gbSaveETextConfirm.ResumeLayout(false);
            gbSaveETextConfirm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnCopy;
    }
}

