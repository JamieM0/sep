namespace sep
{
    partial class frmStreamedFunction
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenPassword = new System.Windows.Forms.Button();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.btnFunction = new System.Windows.Forms.Button();
            this.cbSaveOriginal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(12, 37);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(291, 29);
            this.txtPassword.TabIndex = 0;
            // 
            // btnGenPassword
            // 
            this.btnGenPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenPassword.Location = new System.Drawing.Point(12, 72);
            this.btnGenPassword.Name = "btnGenPassword";
            this.btnGenPassword.Size = new System.Drawing.Size(151, 32);
            this.btnGenPassword.TabIndex = 1;
            this.btnGenPassword.Text = "Generate Password";
            this.btnGenPassword.UseVisualStyleBackColor = true;
            this.btnGenPassword.Click += new System.EventHandler(this.btnGenPassword_Click);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSavePassword.Location = new System.Drawing.Point(169, 72);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(134, 32);
            this.btnSavePassword.TabIndex = 2;
            this.btnSavePassword.Text = "Copy Password";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInstructions.Location = new System.Drawing.Point(12, 9);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(145, 25);
            this.lbInstructions.TabIndex = 3;
            this.lbInstructions.Text = "Enter password:";
            // 
            // btnFunction
            // 
            this.btnFunction.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFunction.Location = new System.Drawing.Point(12, 144);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(291, 43);
            this.btnFunction.TabIndex = 4;
            this.btnFunction.Text = "Encrypt";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // cbSaveOriginal
            // 
            this.cbSaveOriginal.AutoSize = true;
            this.cbSaveOriginal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSaveOriginal.Location = new System.Drawing.Point(12, 113);
            this.cbSaveOriginal.Name = "cbSaveOriginal";
            this.cbSaveOriginal.Size = new System.Drawing.Size(158, 25);
            this.cbSaveOriginal.TabIndex = 5;
            this.cbSaveOriginal.Text = "Keep Original File?";
            this.cbSaveOriginal.UseVisualStyleBackColor = true;
            // 
            // frmStreamedFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 199);
            this.Controls.Add(this.cbSaveOriginal);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.btnGenPassword);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmStreamedFunction";
            this.Text = "SEP";
            this.Load += new System.EventHandler(this.frmStreamedFunction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenPassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.CheckBox cbSaveOriginal;
    }
}