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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecryptString = new System.Windows.Forms.Button();
            this.btnEncryptString = new System.Windows.Forms.Button();
            this.pbGithub = new System.Windows.Forms.PictureBox();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnPWLib = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to SEP!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do today?";
            // 
            // btnDecryptString
            // 
            this.btnDecryptString.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecryptString.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptString.Location = new System.Drawing.Point(489, 255);
            this.btnDecryptString.Name = "btnDecryptString";
            this.btnDecryptString.Size = new System.Drawing.Size(172, 43);
            this.btnDecryptString.TabIndex = 3;
            this.btnDecryptString.Text = "Decrypt String";
            this.btnDecryptString.UseVisualStyleBackColor = true;
            this.btnDecryptString.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEncryptString
            // 
            this.btnEncryptString.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncryptString.ForeColor = System.Drawing.Color.Black;
            this.btnEncryptString.Location = new System.Drawing.Point(160, 255);
            this.btnEncryptString.Name = "btnEncryptString";
            this.btnEncryptString.Size = new System.Drawing.Size(172, 43);
            this.btnEncryptString.TabIndex = 4;
            this.btnEncryptString.Text = "Encrypt String";
            this.btnEncryptString.UseVisualStyleBackColor = true;
            this.btnEncryptString.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbGithub
            // 
            this.pbGithub.Image = ((System.Drawing.Image)(resources.GetObject("pbGithub.Image")));
            this.pbGithub.Location = new System.Drawing.Point(694, 26);
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
            this.btnEncryptFile.Location = new System.Drawing.Point(130, 159);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(230, 90);
            this.btnEncryptFile.TabIndex = 6;
            this.btnEncryptFile.Text = "Encrypt";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptFile.Location = new System.Drawing.Point(460, 159);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(230, 90);
            this.btnDecryptFile.TabIndex = 7;
            this.btnDecryptFile.Text = "Decrypt";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnPWLib
            // 
            this.btnPWLib.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPWLib.Location = new System.Drawing.Point(269, 336);
            this.btnPWLib.Name = "btnPWLib";
            this.btnPWLib.Size = new System.Drawing.Size(253, 59);
            this.btnPWLib.TabIndex = 8;
            this.btnPWLib.Text = "Password Library";
            this.btnPWLib.UseVisualStyleBackColor = true;
            this.btnPWLib.Click += new System.EventHandler(this.btnPWLib_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPWLib);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.pbGithub);
            this.Controls.Add(this.btnEncryptString);
            this.Controls.Add(this.btnDecryptString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "Simple Encryption Program (SEP) - Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecryptString;
        private System.Windows.Forms.Button btnEncryptString;
        private System.Windows.Forms.PictureBox pbGithub;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnPWLib;
    }
}