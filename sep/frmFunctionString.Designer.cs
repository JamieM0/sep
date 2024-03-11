namespace sep
{
    partial class frmFunctionString
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
            lbInfo = new System.Windows.Forms.Label();
            txtInput = new System.Windows.Forms.TextBox();
            lbInfoInput = new System.Windows.Forms.Label();
            pnlPassword = new System.Windows.Forms.Panel();
            btnCopy = new System.Windows.Forms.Button();
            lbInfoOutput = new System.Windows.Forms.Label();
            txtOutput = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnConfirmInput = new System.Windows.Forms.Button();
            pnlPassword.SuspendLayout();
            SuspendLayout();
            // 
            // lbInfo
            // 
            lbInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbInfo.AutoSize = true;
            lbInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbInfo.Location = new System.Drawing.Point(335, 9);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new System.Drawing.Size(141, 30);
            lbInfo.TabIndex = 0;
            lbInfo.Text = "Encrypt String";
            // 
            // txtInput
            // 
            txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtInput.Location = new System.Drawing.Point(12, 67);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(760, 114);
            txtInput.TabIndex = 1;
            // 
            // lbInfoInput
            // 
            lbInfoInput.AutoSize = true;
            lbInfoInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbInfoInput.Location = new System.Drawing.Point(12, 43);
            lbInfoInput.Name = "lbInfoInput";
            lbInfoInput.Size = new System.Drawing.Size(285, 21);
            lbInfoInput.TabIndex = 2;
            lbInfoInput.Text = "Enter plaintext that you want to encrypt:";
            // 
            // pnlPassword
            // 
            pnlPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPassword.Controls.Add(btnCopy);
            pnlPassword.Controls.Add(lbInfoOutput);
            pnlPassword.Controls.Add(txtOutput);
            pnlPassword.Controls.Add(label1);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Controls.Add(btnConfirmInput);
            pnlPassword.Location = new System.Drawing.Point(5, 187);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new System.Drawing.Size(776, 262);
            pnlPassword.TabIndex = 3;
            // 
            // btnCopy
            // 
            btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCopy.Location = new System.Drawing.Point(546, 90);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(221, 45);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "Copy Encrypted String";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Visible = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // lbInfoOutput
            // 
            lbInfoOutput.AutoSize = true;
            lbInfoOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbInfoOutput.Location = new System.Drawing.Point(7, 111);
            lbInfoOutput.Name = "lbInfoOutput";
            lbInfoOutput.Size = new System.Drawing.Size(127, 21);
            lbInfoOutput.TabIndex = 6;
            lbInfoOutput.Text = "Encrypted String:";
            lbInfoOutput.Visible = false;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOutput.Location = new System.Drawing.Point(7, 135);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new System.Drawing.Size(760, 114);
            txtOutput.TabIndex = 5;
            txtOutput.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(7, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 21);
            label1.TabIndex = 4;
            label1.Text = "Enter Password:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPassword.Location = new System.Drawing.Point(7, 24);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(589, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnConfirmInput
            // 
            btnConfirmInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnConfirmInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirmInput.Location = new System.Drawing.Point(602, 10);
            btnConfirmInput.Name = "btnConfirmInput";
            btnConfirmInput.Size = new System.Drawing.Size(165, 45);
            btnConfirmInput.TabIndex = 0;
            btnConfirmInput.Text = "Encrypt String";
            btnConfirmInput.UseVisualStyleBackColor = true;
            btnConfirmInput.Click += btnConfirmInput_Click;
            // 
            // frmFunctionString
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(pnlPassword);
            Controls.Add(lbInfoInput);
            Controls.Add(txtInput);
            Controls.Add(lbInfo);
            Name = "frmFunctionString";
            Text = "SEP: Encrypt String";
            Resize += frmFunctionString_Resize;
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbInfoInput;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnConfirmInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbInfoOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCopy;
    }
}