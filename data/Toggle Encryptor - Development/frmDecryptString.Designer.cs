namespace Toggle_Encryptor___Development
{
    partial class frmDecryptString
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnOpenEncrypt = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lbPasswordLengthWarn = new System.Windows.Forms.Label();
            this.btnSavePasswordOpen = new System.Windows.Forms.Button();
            this.lbCleartext = new System.Windows.Forms.Label();
            this.lbIns3 = new System.Windows.Forms.Label();
            this.btnConfirmInputEncrypt = new System.Windows.Forms.Button();
            this.gbConfirmPasswordSave = new System.Windows.Forms.GroupBox();
            this.btnSavePasswordConfirmNo = new System.Windows.Forms.Button();
            this.btnSavePasswordConfirmYes = new System.Windows.Forms.Button();
            this.lbSavePasswordConfirmTitle = new System.Windows.Forms.Label();
            this.lbSavePasswordConfirmMessage = new System.Windows.Forms.Label();
            this.txtEncryptInput = new System.Windows.Forms.TextBox();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.gbSaveETextConfirm = new System.Windows.Forms.GroupBox();
            this.btnSaveEncryptedText = new System.Windows.Forms.Button();
            this.btnSaveETextConfirmNo = new System.Windows.Forms.Button();
            this.btnSaveETextConfirmYes = new System.Windows.Forms.Button();
            this.lbSaveETextConfirmTitle = new System.Windows.Forms.Label();
            this.lbSaveETextConfirmMessage = new System.Windows.Forms.Label();
            this.btnGenPass = new System.Windows.Forms.Button();
            this.btnGoToMainMenu = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.gbConfirmPasswordSave.SuspendLayout();
            this.gbSaveETextConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption Program Protocol (TEPP) - Prototype";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnOpenEncrypt);
            this.gbMain.Controls.Add(this.btnCopy);
            this.gbMain.Controls.Add(this.lbPasswordLengthWarn);
            this.gbMain.Controls.Add(this.btnSavePasswordOpen);
            this.gbMain.Controls.Add(this.lbCleartext);
            this.gbMain.Controls.Add(this.lbIns3);
            this.gbMain.Controls.Add(this.btnConfirmInputEncrypt);
            this.gbMain.Controls.Add(this.gbConfirmPasswordSave);
            this.gbMain.Controls.Add(this.txtEncryptInput);
            this.gbMain.Controls.Add(this.lbIns2);
            this.gbMain.Controls.Add(this.btnConfirmPassword);
            this.gbMain.Controls.Add(this.txtPasswordInput);
            this.gbMain.Controls.Add(this.lbIns1);
            this.gbMain.Controls.Add(this.gbSaveETextConfirm);
            this.gbMain.Controls.Add(this.btnGenPass);
            this.gbMain.Location = new System.Drawing.Point(12, 57);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(734, 319);
            this.gbMain.TabIndex = 4;
            this.gbMain.TabStop = false;
            // 
            // btnOpenEncrypt
            // 
            this.btnOpenEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenEncrypt.Location = new System.Drawing.Point(373, 158);
            this.btnOpenEncrypt.Name = "btnOpenEncrypt";
            this.btnOpenEncrypt.Size = new System.Drawing.Size(133, 31);
            this.btnOpenEncrypt.TabIndex = 11;
            this.btnOpenEncrypt.Text = "Open Saved";
            this.btnOpenEncrypt.UseVisualStyleBackColor = true;
            this.btnOpenEncrypt.Click += new System.EventHandler(this.btnOpenEncrypt_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.Location = new System.Drawing.Point(566, 252);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(168, 61);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy Non-Encrypted Text";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lbPasswordLengthWarn
            // 
            this.lbPasswordLengthWarn.AutoSize = true;
            this.lbPasswordLengthWarn.Location = new System.Drawing.Point(615, 62);
            this.lbPasswordLengthWarn.Name = "lbPasswordLengthWarn";
            this.lbPasswordLengthWarn.Size = new System.Drawing.Size(119, 30);
            this.lbPasswordLengthWarn.TabIndex = 9;
            this.lbPasswordLengthWarn.Text = "Password must be \r\nexactly 16 characters.";
            this.lbPasswordLengthWarn.Visible = false;
            // 
            // btnSavePasswordOpen
            // 
            this.btnSavePasswordOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSavePasswordOpen.Location = new System.Drawing.Point(240, 64);
            this.btnSavePasswordOpen.Name = "btnSavePasswordOpen";
            this.btnSavePasswordOpen.Size = new System.Drawing.Size(133, 29);
            this.btnSavePasswordOpen.TabIndex = 10;
            this.btnSavePasswordOpen.Text = "Open Saved";
            this.btnSavePasswordOpen.UseVisualStyleBackColor = true;
            this.btnSavePasswordOpen.Click += new System.EventHandler(this.btnSavePasswordOpen_Click);
            // 
            // lbCleartext
            // 
            this.lbCleartext.AutoSize = true;
            this.lbCleartext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCleartext.Location = new System.Drawing.Point(52, 265);
            this.lbCleartext.Name = "lbCleartext";
            this.lbCleartext.Size = new System.Drawing.Size(143, 25);
            this.lbCleartext.TabIndex = 8;
            this.lbCleartext.Text = "abcimherehehe";
            // 
            // lbIns3
            // 
            this.lbIns3.AutoSize = true;
            this.lbIns3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns3.Location = new System.Drawing.Point(38, 225);
            this.lbIns3.Name = "lbIns3";
            this.lbIns3.Size = new System.Drawing.Size(311, 25);
            this.lbIns3.TabIndex = 7;
            this.lbIns3.Text = "3. Here\'s the non-encrypted phrase.";
            // 
            // btnConfirmInputEncrypt
            // 
            this.btnConfirmInputEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmInputEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmInputEncrypt.Location = new System.Drawing.Point(508, 157);
            this.btnConfirmInputEncrypt.Name = "btnConfirmInputEncrypt";
            this.btnConfirmInputEncrypt.Size = new System.Drawing.Size(101, 32);
            this.btnConfirmInputEncrypt.TabIndex = 6;
            this.btnConfirmInputEncrypt.Text = "Confirm";
            this.btnConfirmInputEncrypt.UseVisualStyleBackColor = true;
            this.btnConfirmInputEncrypt.Click += new System.EventHandler(this.btnConfirmInputEncrypt_Click);
            // 
            // gbConfirmPasswordSave
            // 
            this.gbConfirmPasswordSave.Controls.Add(this.btnSavePasswordConfirmNo);
            this.gbConfirmPasswordSave.Controls.Add(this.btnSavePasswordConfirmYes);
            this.gbConfirmPasswordSave.Controls.Add(this.lbSavePasswordConfirmTitle);
            this.gbConfirmPasswordSave.Controls.Add(this.lbSavePasswordConfirmMessage);
            this.gbConfirmPasswordSave.Enabled = false;
            this.gbConfirmPasswordSave.Location = new System.Drawing.Point(162, 293);
            this.gbConfirmPasswordSave.Name = "gbConfirmPasswordSave";
            this.gbConfirmPasswordSave.Size = new System.Drawing.Size(306, 197);
            this.gbConfirmPasswordSave.TabIndex = 4;
            this.gbConfirmPasswordSave.TabStop = false;
            this.gbConfirmPasswordSave.Visible = false;
            // 
            // btnSavePasswordConfirmNo
            // 
            this.btnSavePasswordConfirmNo.Location = new System.Drawing.Point(18, 144);
            this.btnSavePasswordConfirmNo.Name = "btnSavePasswordConfirmNo";
            this.btnSavePasswordConfirmNo.Size = new System.Drawing.Size(93, 35);
            this.btnSavePasswordConfirmNo.TabIndex = 3;
            this.btnSavePasswordConfirmNo.Text = "Cancel";
            this.btnSavePasswordConfirmNo.UseVisualStyleBackColor = true;
            // 
            // btnSavePasswordConfirmYes
            // 
            this.btnSavePasswordConfirmYes.Location = new System.Drawing.Point(202, 144);
            this.btnSavePasswordConfirmYes.Name = "btnSavePasswordConfirmYes";
            this.btnSavePasswordConfirmYes.Size = new System.Drawing.Size(86, 35);
            this.btnSavePasswordConfirmYes.TabIndex = 2;
            this.btnSavePasswordConfirmYes.Text = "Ok";
            this.btnSavePasswordConfirmYes.UseVisualStyleBackColor = true;
            // 
            // lbSavePasswordConfirmTitle
            // 
            this.lbSavePasswordConfirmTitle.AutoSize = true;
            this.lbSavePasswordConfirmTitle.Location = new System.Drawing.Point(1, 24);
            this.lbSavePasswordConfirmTitle.Name = "lbSavePasswordConfirmTitle";
            this.lbSavePasswordConfirmTitle.Size = new System.Drawing.Size(128, 15);
            this.lbSavePasswordConfirmTitle.TabIndex = 1;
            this.lbSavePasswordConfirmTitle.Text = "Open Saved Password?";
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
            this.lbSavePasswordConfirmMessage.Visible = false;
            // 
            // txtEncryptInput
            // 
            this.txtEncryptInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEncryptInput.Location = new System.Drawing.Point(52, 160);
            this.txtEncryptInput.Name = "txtEncryptInput";
            this.txtEncryptInput.Size = new System.Drawing.Size(315, 29);
            this.txtEncryptInput.TabIndex = 5;
            // 
            // lbIns2
            // 
            this.lbIns2.AutoSize = true;
            this.lbIns2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns2.Location = new System.Drawing.Point(38, 128);
            this.lbIns2.Name = "lbIns2";
            this.lbIns2.Size = new System.Drawing.Size(586, 25);
            this.lbIns2.TabIndex = 4;
            this.lbIns2.Text = "2. Enter the encrypted string that was encrypted with your password.";
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPassword.Location = new System.Drawing.Point(508, 60);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(101, 32);
            this.btnConfirmPassword.TabIndex = 3;
            this.btnConfirmPassword.Text = "Confirm";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPass_Click);
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordInput.Location = new System.Drawing.Point(52, 64);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.Size = new System.Drawing.Size(182, 29);
            this.txtPasswordInput.TabIndex = 1;
            // 
            // lbIns1
            // 
            this.lbIns1.AutoSize = true;
            this.lbIns1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns1.Location = new System.Drawing.Point(38, 24);
            this.lbIns1.Name = "lbIns1";
            this.lbIns1.Size = new System.Drawing.Size(485, 25);
            this.lbIns1.TabIndex = 0;
            this.lbIns1.Text = "1. Enter the password that you encrypted the string with.";
            // 
            // gbSaveETextConfirm
            // 
            this.gbSaveETextConfirm.Controls.Add(this.btnSaveEncryptedText);
            this.gbSaveETextConfirm.Controls.Add(this.btnSaveETextConfirmNo);
            this.gbSaveETextConfirm.Controls.Add(this.btnSaveETextConfirmYes);
            this.gbSaveETextConfirm.Controls.Add(this.lbSaveETextConfirmTitle);
            this.gbSaveETextConfirm.Controls.Add(this.lbSaveETextConfirmMessage);
            this.gbSaveETextConfirm.Enabled = false;
            this.gbSaveETextConfirm.Location = new System.Drawing.Point(28, 293);
            this.gbSaveETextConfirm.Name = "gbSaveETextConfirm";
            this.gbSaveETextConfirm.Size = new System.Drawing.Size(306, 197);
            this.gbSaveETextConfirm.TabIndex = 5;
            this.gbSaveETextConfirm.TabStop = false;
            this.gbSaveETextConfirm.Visible = false;
            // 
            // btnSaveEncryptedText
            // 
            this.btnSaveEncryptedText.Location = new System.Drawing.Point(322, 229);
            this.btnSaveEncryptedText.Name = "btnSaveEncryptedText";
            this.btnSaveEncryptedText.Size = new System.Drawing.Size(45, 23);
            this.btnSaveEncryptedText.TabIndex = 11;
            this.btnSaveEncryptedText.Text = "Save";
            this.btnSaveEncryptedText.UseVisualStyleBackColor = true;
            // 
            // btnSaveETextConfirmNo
            // 
            this.btnSaveETextConfirmNo.Location = new System.Drawing.Point(18, 144);
            this.btnSaveETextConfirmNo.Name = "btnSaveETextConfirmNo";
            this.btnSaveETextConfirmNo.Size = new System.Drawing.Size(93, 35);
            this.btnSaveETextConfirmNo.TabIndex = 3;
            this.btnSaveETextConfirmNo.Text = "Cancel";
            this.btnSaveETextConfirmNo.UseVisualStyleBackColor = true;
            // 
            // btnSaveETextConfirmYes
            // 
            this.btnSaveETextConfirmYes.Location = new System.Drawing.Point(202, 144);
            this.btnSaveETextConfirmYes.Name = "btnSaveETextConfirmYes";
            this.btnSaveETextConfirmYes.Size = new System.Drawing.Size(86, 35);
            this.btnSaveETextConfirmYes.TabIndex = 2;
            this.btnSaveETextConfirmYes.Text = "Ok";
            this.btnSaveETextConfirmYes.UseVisualStyleBackColor = true;
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
            // btnGenPass
            // 
            this.btnGenPass.Location = new System.Drawing.Point(240, 64);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(127, 23);
            this.btnGenPass.TabIndex = 2;
            this.btnGenPass.Text = "Generate a Password";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Visible = false;
            // 
            // btnGoToMainMenu
            // 
            this.btnGoToMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToMainMenu.Location = new System.Drawing.Point(578, 389);
            this.btnGoToMainMenu.Name = "btnGoToMainMenu";
            this.btnGoToMainMenu.Size = new System.Drawing.Size(168, 36);
            this.btnGoToMainMenu.TabIndex = 5;
            this.btnGoToMainMenu.Text = "Back to main menu";
            this.btnGoToMainMenu.UseVisualStyleBackColor = true;
            this.btnGoToMainMenu.Click += new System.EventHandler(this.btnGoToMainMenu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToMainMenu);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "TEPP: Decrpytion";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbConfirmPasswordSave.ResumeLayout(false);
            this.gbConfirmPasswordSave.PerformLayout();
            this.gbSaveETextConfirm.ResumeLayout(false);
            this.gbSaveETextConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbSaveETextConfirm;
        private System.Windows.Forms.Button btnSaveETextConfirmNo;
        private System.Windows.Forms.Button btnSaveETextConfirmYes;
        private System.Windows.Forms.Label lbSaveETextConfirmTitle;
        private System.Windows.Forms.Label lbSaveETextConfirmMessage;
        private System.Windows.Forms.GroupBox gbConfirmPasswordSave;
        private System.Windows.Forms.Button btnSavePasswordConfirmNo;
        private System.Windows.Forms.Button btnSavePasswordConfirmYes;
        private System.Windows.Forms.Label lbSavePasswordConfirmTitle;
        private System.Windows.Forms.Label lbSavePasswordConfirmMessage;
        private System.Windows.Forms.Button btnSaveEncryptedText;
        private System.Windows.Forms.Button btnSavePasswordOpen;
        private System.Windows.Forms.Label lbPasswordLengthWarn;
        private System.Windows.Forms.Label lbCleartext;
        private System.Windows.Forms.Label lbIns3;
        private System.Windows.Forms.Button btnConfirmInputEncrypt;
        private System.Windows.Forms.TextBox txtEncryptInput;
        private System.Windows.Forms.Label lbIns2;
        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.Button btnOpenEncrypt;
        private System.Windows.Forms.Button btnGoToMainMenu;
        private System.Windows.Forms.Button btnCopy;
    }
}