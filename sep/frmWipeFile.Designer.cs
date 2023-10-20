namespace sep
{
    partial class frmWipeFile
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
            lbTitle = new System.Windows.Forms.Label();
            lbFileInfo = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnBrowse = new System.Windows.Forms.Button();
            lbFileName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtNumP = new System.Windows.Forms.TextBox();
            btnWipe = new System.Windows.Forms.Button();
            lbDocDisclosure = new System.Windows.Forms.Label();
            lbDocLink = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(127, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Wipe File";
            // 
            // lbFileInfo
            // 
            lbFileInfo.AutoSize = true;
            lbFileInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFileInfo.Location = new System.Drawing.Point(12, 54);
            lbFileInfo.Name = "lbFileInfo";
            lbFileInfo.Size = new System.Drawing.Size(128, 30);
            lbFileInfo.TabIndex = 1;
            lbFileInfo.Text = "File to Wipe:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(155, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(111, 37);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBrowse.Location = new System.Drawing.Point(155, 53);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(111, 37);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lbFileName
            // 
            lbFileName.AutoSize = true;
            lbFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFileName.Location = new System.Drawing.Point(12, 96);
            lbFileName.Name = "lbFileName";
            lbFileName.Size = new System.Drawing.Size(0, 21);
            lbFileName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 135);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(186, 30);
            label1.TabIndex = 5;
            label1.Text = "Number of passes:";
            // 
            // txtNumP
            // 
            txtNumP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNumP.Location = new System.Drawing.Point(204, 139);
            txtNumP.Name = "txtNumP";
            txtNumP.Size = new System.Drawing.Size(62, 29);
            txtNumP.TabIndex = 6;
            txtNumP.Text = "3";
            // 
            // btnWipe
            // 
            btnWipe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnWipe.Location = new System.Drawing.Point(12, 190);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new System.Drawing.Size(254, 56);
            btnWipe.TabIndex = 7;
            btnWipe.Text = "Wipe Selected File.";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // lbDocDisclosure
            // 
            lbDocDisclosure.AutoSize = true;
            lbDocDisclosure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDocDisclosure.Location = new System.Drawing.Point(4, 259);
            lbDocDisclosure.Name = "lbDocDisclosure";
            lbDocDisclosure.Size = new System.Drawing.Size(273, 17);
            lbDocDisclosure.TabIndex = 8;
            lbDocDisclosure.Text = "Before using, please read the documentation:";
            // 
            // lbDocLink
            // 
            lbDocLink.AutoSize = true;
            lbDocLink.Location = new System.Drawing.Point(17, 276);
            lbDocLink.Name = "lbDocLink";
            lbDocLink.Size = new System.Drawing.Size(245, 15);
            lbDocLink.TabIndex = 10;
            lbDocLink.TabStop = true;
            lbDocLink.Text = "https://docs.jmatthews.uk/sep/secure-delete";
            lbDocLink.LinkClicked += lbDocLink_LinkClicked;
            // 
            // frmWipeFile
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(276, 306);
            Controls.Add(lbDocLink);
            Controls.Add(lbDocDisclosure);
            Controls.Add(btnWipe);
            Controls.Add(txtNumP);
            Controls.Add(label1);
            Controls.Add(lbFileName);
            Controls.Add(btnBrowse);
            Controls.Add(btnCancel);
            Controls.Add(lbFileInfo);
            Controls.Add(lbTitle);
            Name = "frmWipeFile";
            Text = "SEP: Wipe File";
            Load += frmWipeFile_Load;
            DragDrop += frmWipeFile_DragDrop;
            DragEnter += frmWipeFile_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFileInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumP;
        private System.Windows.Forms.Button btnWipe;
        private System.Windows.Forms.Label lbDocDisclosure;
        private System.Windows.Forms.LinkLabel lbDocLink;
    }
}