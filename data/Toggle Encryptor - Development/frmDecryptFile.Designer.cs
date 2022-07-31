namespace Toggle_Encryptor___Development
{
    partial class frmDecryptFile
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
            this.lbFilePath = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.cbKeepOriginal = new System.Windows.Forms.CheckBox();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeading.Location = new System.Drawing.Point(12, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(699, 45);
            this.lbHeading.TabIndex = 2;
            this.lbHeading.Text = "Encryption Program Protocol (TEPP) - Prototype";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.cbKeepOriginal);
            this.gbMain.Controls.Add(this.lbFilePath);
            this.gbMain.Controls.Add(this.btnOpen);
            this.gbMain.Controls.Add(this.btnGo);
            this.gbMain.Controls.Add(this.lbIns2);
            this.gbMain.Controls.Add(this.btnConfirmPassword);
            this.gbMain.Controls.Add(this.txtPasswordInput);
            this.gbMain.Controls.Add(this.lbIns1);
            this.gbMain.Location = new System.Drawing.Point(12, 74);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(734, 319);
            this.gbMain.TabIndex = 5;
            this.gbMain.TabStop = false;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFilePath.Location = new System.Drawing.Point(177, 66);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(0, 21);
            this.lbFilePath.TabIndex = 13;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(38, 62);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(133, 29);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open Saved";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(532, 233);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(186, 43);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Decrypt it!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbIns2
            // 
            this.lbIns2.AutoSize = true;
            this.lbIns2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns2.Location = new System.Drawing.Point(38, 128);
            this.lbIns2.Name = "lbIns2";
            this.lbIns2.Size = new System.Drawing.Size(380, 25);
            this.lbIns2.TabIndex = 4;
            this.lbIns2.Text = "2. Enter the password for this encrypted file.";
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPassword.Location = new System.Drawing.Point(617, 55);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(101, 32);
            this.btnConfirmPassword.TabIndex = 3;
            this.btnConfirmPassword.Text = "Confirm";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPassword_Click);
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.Location = new System.Drawing.Point(38, 166);
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
            this.lbIns1.Size = new System.Drawing.Size(210, 25);
            this.lbIns1.TabIndex = 0;
            this.lbIns1.Text = "1. Locate encrypted file.";
            // 
            // cbKeepOriginal
            // 
            this.cbKeepOriginal.AutoSize = true;
            this.cbKeepOriginal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbKeepOriginal.Location = new System.Drawing.Point(38, 247);
            this.cbKeepOriginal.Name = "cbKeepOriginal";
            this.cbKeepOriginal.Size = new System.Drawing.Size(446, 29);
            this.cbKeepOriginal.TabIndex = 14;
            this.cbKeepOriginal.Text = "Would you like to keep the encrypted file as well?";
            this.cbKeepOriginal.UseVisualStyleBackColor = true;
            // 
            // frmDecryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.lbHeading);
            this.Name = "frmDecryptFile";
            this.Text = "Decrypt File";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lbIns2;
        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.CheckBox cbKeepOriginal;
    }
}