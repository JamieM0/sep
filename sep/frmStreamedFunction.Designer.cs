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
            txtPassword = new System.Windows.Forms.TextBox();
            btnGenPassword = new System.Windows.Forms.Button();
            btnSavePassword = new System.Windows.Forms.Button();
            lbInstructions = new System.Windows.Forms.Label();
            btnFunction = new System.Windows.Forms.Button();
            cbDeleteAsk = new System.Windows.Forms.CheckBox();
            btnPWLibFunc = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(12, 37);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(222, 29);
            txtPassword.TabIndex = 0;
            // 
            // btnGenPassword
            // 
            btnGenPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGenPassword.Location = new System.Drawing.Point(12, 72);
            btnGenPassword.Name = "btnGenPassword";
            btnGenPassword.Size = new System.Drawing.Size(151, 32);
            btnGenPassword.TabIndex = 1;
            btnGenPassword.Text = "Generate Password";
            btnGenPassword.UseVisualStyleBackColor = true;
            btnGenPassword.Click += btnGenPassword_Click;
            // 
            // btnSavePassword
            // 
            btnSavePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSavePassword.Location = new System.Drawing.Point(240, 36);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new System.Drawing.Size(63, 30);
            btnSavePassword.TabIndex = 2;
            btnSavePassword.Text = "Copy";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // lbInstructions
            // 
            lbInstructions.AutoSize = true;
            lbInstructions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbInstructions.Location = new System.Drawing.Point(12, 9);
            lbInstructions.Name = "lbInstructions";
            lbInstructions.Size = new System.Drawing.Size(145, 25);
            lbInstructions.TabIndex = 3;
            lbInstructions.Text = "Enter password:";
            // 
            // btnFunction
            // 
            btnFunction.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFunction.Location = new System.Drawing.Point(12, 144);
            btnFunction.Name = "btnFunction";
            btnFunction.Size = new System.Drawing.Size(291, 43);
            btnFunction.TabIndex = 4;
            btnFunction.Text = "Encrypt";
            btnFunction.UseVisualStyleBackColor = true;
            btnFunction.Click += btnFunction_Click;
            // 
            // cbDeleteAsk
            // 
            cbDeleteAsk.AutoSize = true;
            cbDeleteAsk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbDeleteAsk.Location = new System.Drawing.Point(12, 113);
            cbDeleteAsk.Name = "cbDeleteAsk";
            cbDeleteAsk.Size = new System.Drawing.Size(170, 25);
            cbDeleteAsk.TabIndex = 5;
            cbDeleteAsk.Text = "Delete Selected File?";
            cbDeleteAsk.UseVisualStyleBackColor = true;
            cbDeleteAsk.CheckedChanged += cbSaveOriginal_CheckedChanged;
            // 
            // btnPWLibFunc
            // 
            btnPWLibFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPWLibFunc.Location = new System.Drawing.Point(169, 72);
            btnPWLibFunc.Name = "btnPWLibFunc";
            btnPWLibFunc.Size = new System.Drawing.Size(134, 32);
            btnPWLibFunc.TabIndex = 6;
            btnPWLibFunc.Text = "Save Password";
            btnPWLibFunc.UseVisualStyleBackColor = true;
            btnPWLibFunc.Click += btnPWLibFunc_Click;
            // 
            // frmStreamedFunction
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(315, 199);
            Controls.Add(btnPWLibFunc);
            Controls.Add(cbDeleteAsk);
            Controls.Add(btnFunction);
            Controls.Add(lbInstructions);
            Controls.Add(btnSavePassword);
            Controls.Add(btnGenPassword);
            Controls.Add(txtPassword);
            Name = "frmStreamedFunction";
            Text = "SEP";
            Load += frmStreamedFunction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenPassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.CheckBox cbDeleteAsk;
        private System.Windows.Forms.Button btnPWLibFunc;
    }
}