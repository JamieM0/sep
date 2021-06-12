
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
            this.lbEncryptOutput = new System.Windows.Forms.Label();
            this.lbIns3 = new System.Windows.Forms.Label();
            this.btnConfirmInputEncrypt = new System.Windows.Forms.Button();
            this.txtEncryptInput = new System.Windows.Forms.TextBox();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.btnConfirmPass = new System.Windows.Forms.Button();
            this.btnGenPass = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gbMain.Controls.Add(this.lbEncryptOutput);
            this.gbMain.Controls.Add(this.lbIns3);
            this.gbMain.Controls.Add(this.btnConfirmInputEncrypt);
            this.gbMain.Controls.Add(this.txtEncryptInput);
            this.gbMain.Controls.Add(this.lbIns2);
            this.gbMain.Controls.Add(this.btnConfirmPass);
            this.gbMain.Controls.Add(this.btnGenPass);
            this.gbMain.Controls.Add(this.txtPass);
            this.gbMain.Controls.Add(this.lbIns1);
            this.gbMain.Location = new System.Drawing.Point(12, 66);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(734, 319);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
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
            // btnConfirmPass
            // 
            this.btnConfirmPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPass.Location = new System.Drawing.Point(517, 55);
            this.btnConfirmPass.Name = "btnConfirmPass";
            this.btnConfirmPass.Size = new System.Drawing.Size(101, 32);
            this.btnConfirmPass.TabIndex = 3;
            this.btnConfirmPass.Text = "Confirm";
            this.btnConfirmPass.UseVisualStyleBackColor = true;
            this.btnConfirmPass.Click += new System.EventHandler(this.btnConfirmPass_Click);
            // 
            // btnGenPass
            // 
            this.btnGenPass.Location = new System.Drawing.Point(291, 63);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(127, 23);
            this.btnGenPass.TabIndex = 2;
            this.btnGenPass.Text = "Generate a Password";
            this.btnGenPass.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(52, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(233, 23);
            this.txtPass.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbAbout);
            this.Name = "Form1";
            this.Text = "Toggle Encryptor - Prototype";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
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
        private System.Windows.Forms.Button btnConfirmPass;
        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.Button btnConfirmInputEncrypt;
        private System.Windows.Forms.Label lbEncryptOutput;
        private System.Windows.Forms.Label lbIns3;
    }
}

