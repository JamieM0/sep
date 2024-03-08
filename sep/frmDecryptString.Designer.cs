namespace sep
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
            label1 = new System.Windows.Forms.Label();
            gbMain = new System.Windows.Forms.GroupBox();
            btnOpenEncrypt = new System.Windows.Forms.Button();
            btnCopy = new System.Windows.Forms.Button();
            lbPasswordLengthWarn = new System.Windows.Forms.Label();
            btnSavePasswordOpen = new System.Windows.Forms.Button();
            lbCleartext = new System.Windows.Forms.Label();
            lbIns3 = new System.Windows.Forms.Label();
            btnConfirmInputEncrypt = new System.Windows.Forms.Button();
            gbConfirmPasswordSave = new System.Windows.Forms.GroupBox();
            btnSavePasswordConfirmNo = new System.Windows.Forms.Button();
            btnSavePasswordConfirmYes = new System.Windows.Forms.Button();
            lbSavePasswordConfirmTitle = new System.Windows.Forms.Label();
            lbSavePasswordConfirmMessage = new System.Windows.Forms.Label();
            txtEncryptInput = new System.Windows.Forms.TextBox();
            lbIns2 = new System.Windows.Forms.Label();
            btnConfirmPassword = new System.Windows.Forms.Button();
            txtPasswordInput = new System.Windows.Forms.TextBox();
            lbIns1 = new System.Windows.Forms.Label();
            gbSaveETextConfirm = new System.Windows.Forms.GroupBox();
            btnSaveEncryptedText = new System.Windows.Forms.Button();
            btnSaveETextConfirmNo = new System.Windows.Forms.Button();
            btnSaveETextConfirmYes = new System.Windows.Forms.Button();
            lbSaveETextConfirmTitle = new System.Windows.Forms.Label();
            lbSaveETextConfirmMessage = new System.Windows.Forms.Label();
            btnGenPass = new System.Windows.Forms.Button();
            btnGoToMainMenu = new System.Windows.Forms.Button();
            gbMain.SuspendLayout();
            gbConfirmPasswordSave.SuspendLayout();
            gbSaveETextConfirm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(487, 45);
            label1.TabIndex = 0;
            label1.Text = "Simple Encryption Program (SEP)";
            // 
            // gbMain
            // 
            gbMain.Controls.Add(btnOpenEncrypt);
            gbMain.Controls.Add(btnCopy);
            gbMain.Controls.Add(lbPasswordLengthWarn);
            gbMain.Controls.Add(btnSavePasswordOpen);
            gbMain.Controls.Add(lbCleartext);
            gbMain.Controls.Add(lbIns3);
            gbMain.Controls.Add(btnConfirmInputEncrypt);
            gbMain.Controls.Add(gbConfirmPasswordSave);
            gbMain.Controls.Add(txtEncryptInput);
            gbMain.Controls.Add(lbIns2);
            gbMain.Controls.Add(btnConfirmPassword);
            gbMain.Controls.Add(txtPasswordInput);
            gbMain.Controls.Add(lbIns1);
            gbMain.Controls.Add(gbSaveETextConfirm);
            gbMain.Controls.Add(btnGenPass);
            gbMain.Location = new System.Drawing.Point(12, 57);
            gbMain.Name = "gbMain";
            gbMain.Size = new System.Drawing.Size(734, 319);
            gbMain.TabIndex = 4;
            gbMain.TabStop = false;
            // 
            // btnOpenEncrypt
            // 
            btnOpenEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOpenEncrypt.Location = new System.Drawing.Point(373, 158);
            btnOpenEncrypt.Name = "btnOpenEncrypt";
            btnOpenEncrypt.Size = new System.Drawing.Size(133, 31);
            btnOpenEncrypt.TabIndex = 11;
            btnOpenEncrypt.Text = "Open Saved";
            btnOpenEncrypt.UseVisualStyleBackColor = true;
            btnOpenEncrypt.Click += btnOpenEncrypt_Click;
            // 
            // btnCopy
            // 
            btnCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCopy.ForeColor = System.Drawing.Color.Black;
            btnCopy.Location = new System.Drawing.Point(566, 252);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(168, 61);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "Copy Non-Encrypted Text";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lbPasswordLengthWarn
            // 
            lbPasswordLengthWarn.AutoSize = true;
            lbPasswordLengthWarn.Location = new System.Drawing.Point(615, 62);
            lbPasswordLengthWarn.Name = "lbPasswordLengthWarn";
            lbPasswordLengthWarn.Size = new System.Drawing.Size(119, 30);
            lbPasswordLengthWarn.TabIndex = 9;
            lbPasswordLengthWarn.Text = "Password must be \r\nexactly 16 characters.";
            lbPasswordLengthWarn.Visible = false;
            // 
            // btnSavePasswordOpen
            // 
            btnSavePasswordOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSavePasswordOpen.Location = new System.Drawing.Point(240, 64);
            btnSavePasswordOpen.Name = "btnSavePasswordOpen";
            btnSavePasswordOpen.Size = new System.Drawing.Size(133, 29);
            btnSavePasswordOpen.TabIndex = 10;
            btnSavePasswordOpen.Text = "Open Saved";
            btnSavePasswordOpen.UseVisualStyleBackColor = true;
            btnSavePasswordOpen.Click += btnSavePasswordOpen_Click;
            // 
            // lbCleartext
            // 
            lbCleartext.AutoSize = true;
            lbCleartext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCleartext.Location = new System.Drawing.Point(52, 265);
            lbCleartext.Name = "lbCleartext";
            lbCleartext.Size = new System.Drawing.Size(143, 25);
            lbCleartext.TabIndex = 8;
            lbCleartext.Text = "abcimherehehe";
            // 
            // lbIns3
            // 
            lbIns3.AutoSize = true;
            lbIns3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns3.Location = new System.Drawing.Point(38, 225);
            lbIns3.Name = "lbIns3";
            lbIns3.Size = new System.Drawing.Size(311, 25);
            lbIns3.TabIndex = 7;
            lbIns3.Text = "3. Here's the non-encrypted phrase.";
            // 
            // btnConfirmInputEncrypt
            // 
            btnConfirmInputEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmInputEncrypt.ForeColor = System.Drawing.Color.Black;
            btnConfirmInputEncrypt.Location = new System.Drawing.Point(508, 157);
            btnConfirmInputEncrypt.Name = "btnConfirmInputEncrypt";
            btnConfirmInputEncrypt.Size = new System.Drawing.Size(101, 32);
            btnConfirmInputEncrypt.TabIndex = 6;
            btnConfirmInputEncrypt.Text = "Confirm";
            btnConfirmInputEncrypt.UseVisualStyleBackColor = true;
            btnConfirmInputEncrypt.Click += btnConfirmInputEncrypt_Click;
            // 
            // gbConfirmPasswordSave
            // 
            gbConfirmPasswordSave.Controls.Add(btnSavePasswordConfirmNo);
            gbConfirmPasswordSave.Controls.Add(btnSavePasswordConfirmYes);
            gbConfirmPasswordSave.Controls.Add(lbSavePasswordConfirmTitle);
            gbConfirmPasswordSave.Controls.Add(lbSavePasswordConfirmMessage);
            gbConfirmPasswordSave.Enabled = false;
            gbConfirmPasswordSave.Location = new System.Drawing.Point(162, 293);
            gbConfirmPasswordSave.Name = "gbConfirmPasswordSave";
            gbConfirmPasswordSave.Size = new System.Drawing.Size(306, 197);
            gbConfirmPasswordSave.TabIndex = 4;
            gbConfirmPasswordSave.TabStop = false;
            gbConfirmPasswordSave.Visible = false;
            // 
            // btnSavePasswordConfirmNo
            // 
            btnSavePasswordConfirmNo.Location = new System.Drawing.Point(18, 144);
            btnSavePasswordConfirmNo.Name = "btnSavePasswordConfirmNo";
            btnSavePasswordConfirmNo.Size = new System.Drawing.Size(93, 35);
            btnSavePasswordConfirmNo.TabIndex = 3;
            btnSavePasswordConfirmNo.Text = "Cancel";
            btnSavePasswordConfirmNo.UseVisualStyleBackColor = true;
            // 
            // btnSavePasswordConfirmYes
            // 
            btnSavePasswordConfirmYes.Location = new System.Drawing.Point(202, 144);
            btnSavePasswordConfirmYes.Name = "btnSavePasswordConfirmYes";
            btnSavePasswordConfirmYes.Size = new System.Drawing.Size(86, 35);
            btnSavePasswordConfirmYes.TabIndex = 2;
            btnSavePasswordConfirmYes.Text = "Ok";
            btnSavePasswordConfirmYes.UseVisualStyleBackColor = true;
            // 
            // lbSavePasswordConfirmTitle
            // 
            lbSavePasswordConfirmTitle.AutoSize = true;
            lbSavePasswordConfirmTitle.Location = new System.Drawing.Point(1, 24);
            lbSavePasswordConfirmTitle.Name = "lbSavePasswordConfirmTitle";
            lbSavePasswordConfirmTitle.Size = new System.Drawing.Size(128, 15);
            lbSavePasswordConfirmTitle.TabIndex = 1;
            lbSavePasswordConfirmTitle.Text = "Open Saved Password?";
            // 
            // lbSavePasswordConfirmMessage
            // 
            lbSavePasswordConfirmMessage.AutoSize = true;
            lbSavePasswordConfirmMessage.Location = new System.Drawing.Point(1, 58);
            lbSavePasswordConfirmMessage.Name = "lbSavePasswordConfirmMessage";
            lbSavePasswordConfirmMessage.Size = new System.Drawing.Size(305, 45);
            lbSavePasswordConfirmMessage.TabIndex = 0;
            lbSavePasswordConfirmMessage.Text = "You are about to save a text (.txt) file in your documents \r\nfolder which is called your password and contains your \r\npassword.";
            lbSavePasswordConfirmMessage.Visible = false;
            // 
            // txtEncryptInput
            // 
            txtEncryptInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtEncryptInput.Location = new System.Drawing.Point(52, 160);
            txtEncryptInput.Name = "txtEncryptInput";
            txtEncryptInput.Size = new System.Drawing.Size(315, 29);
            txtEncryptInput.TabIndex = 5;
            // 
            // lbIns2
            // 
            lbIns2.AutoSize = true;
            lbIns2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns2.Location = new System.Drawing.Point(38, 128);
            lbIns2.Name = "lbIns2";
            lbIns2.Size = new System.Drawing.Size(586, 25);
            lbIns2.TabIndex = 4;
            lbIns2.Text = "2. Enter the encrypted string that was encrypted with your password.";
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            btnConfirmPassword.Location = new System.Drawing.Point(508, 60);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new System.Drawing.Size(101, 32);
            btnConfirmPassword.TabIndex = 3;
            btnConfirmPassword.Text = "Confirm";
            btnConfirmPassword.UseVisualStyleBackColor = true;
            btnConfirmPassword.Click += btnConfirmPass_Click;
            // 
            // txtPasswordInput
            // 
            txtPasswordInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtPasswordInput.Location = new System.Drawing.Point(52, 64);
            txtPasswordInput.Name = "txtPasswordInput";
            txtPasswordInput.Size = new System.Drawing.Size(182, 29);
            txtPasswordInput.TabIndex = 1;
            // 
            // lbIns1
            // 
            lbIns1.AutoSize = true;
            lbIns1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns1.Location = new System.Drawing.Point(38, 24);
            lbIns1.Name = "lbIns1";
            lbIns1.Size = new System.Drawing.Size(485, 25);
            lbIns1.TabIndex = 0;
            lbIns1.Text = "1. Enter the password that you encrypted the string with.";
            // 
            // gbSaveETextConfirm
            // 
            gbSaveETextConfirm.Controls.Add(btnSaveEncryptedText);
            gbSaveETextConfirm.Controls.Add(btnSaveETextConfirmNo);
            gbSaveETextConfirm.Controls.Add(btnSaveETextConfirmYes);
            gbSaveETextConfirm.Controls.Add(lbSaveETextConfirmTitle);
            gbSaveETextConfirm.Controls.Add(lbSaveETextConfirmMessage);
            gbSaveETextConfirm.Enabled = false;
            gbSaveETextConfirm.Location = new System.Drawing.Point(28, 293);
            gbSaveETextConfirm.Name = "gbSaveETextConfirm";
            gbSaveETextConfirm.Size = new System.Drawing.Size(306, 197);
            gbSaveETextConfirm.TabIndex = 5;
            gbSaveETextConfirm.TabStop = false;
            gbSaveETextConfirm.Visible = false;
            // 
            // btnSaveEncryptedText
            // 
            btnSaveEncryptedText.Location = new System.Drawing.Point(322, 229);
            btnSaveEncryptedText.Name = "btnSaveEncryptedText";
            btnSaveEncryptedText.Size = new System.Drawing.Size(45, 23);
            btnSaveEncryptedText.TabIndex = 11;
            btnSaveEncryptedText.Text = "Save";
            btnSaveEncryptedText.UseVisualStyleBackColor = true;
            // 
            // btnSaveETextConfirmNo
            // 
            btnSaveETextConfirmNo.Location = new System.Drawing.Point(18, 144);
            btnSaveETextConfirmNo.Name = "btnSaveETextConfirmNo";
            btnSaveETextConfirmNo.Size = new System.Drawing.Size(93, 35);
            btnSaveETextConfirmNo.TabIndex = 3;
            btnSaveETextConfirmNo.Text = "Cancel";
            btnSaveETextConfirmNo.UseVisualStyleBackColor = true;
            // 
            // btnSaveETextConfirmYes
            // 
            btnSaveETextConfirmYes.Location = new System.Drawing.Point(202, 144);
            btnSaveETextConfirmYes.Name = "btnSaveETextConfirmYes";
            btnSaveETextConfirmYes.Size = new System.Drawing.Size(86, 35);
            btnSaveETextConfirmYes.TabIndex = 2;
            btnSaveETextConfirmYes.Text = "Ok";
            btnSaveETextConfirmYes.UseVisualStyleBackColor = true;
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
            // btnGenPass
            // 
            btnGenPass.Location = new System.Drawing.Point(240, 64);
            btnGenPass.Name = "btnGenPass";
            btnGenPass.Size = new System.Drawing.Size(127, 23);
            btnGenPass.TabIndex = 2;
            btnGenPass.Text = "Generate a Password";
            btnGenPass.UseVisualStyleBackColor = true;
            btnGenPass.Visible = false;
            // 
            // btnGoToMainMenu
            // 
            btnGoToMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGoToMainMenu.Location = new System.Drawing.Point(578, 389);
            btnGoToMainMenu.Name = "btnGoToMainMenu";
            btnGoToMainMenu.Size = new System.Drawing.Size(168, 36);
            btnGoToMainMenu.TabIndex = 5;
            btnGoToMainMenu.Text = "Back to main menu";
            btnGoToMainMenu.UseVisualStyleBackColor = true;
            btnGoToMainMenu.Click += btnGoToMainMenu_Click;
            // 
            // frmDecryptString
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnGoToMainMenu);
            Controls.Add(gbMain);
            Controls.Add(label1);
            Name = "frmDecryptString";
            Text = "TEPP: Decrpytion";
            Load += Form3_Load;
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