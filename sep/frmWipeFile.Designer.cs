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
            btnSelectDirectory = new System.Windows.Forms.Button();
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
            lbFileInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbFileInfo.AutoSize = true;
            lbFileInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFileInfo.Location = new System.Drawing.Point(12, 54);
            lbFileInfo.Name = "lbFileInfo";
            lbFileInfo.Size = new System.Drawing.Size(66, 25);
            lbFileInfo.TabIndex = 1;
            lbFileInfo.Text = "Select:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(155, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(111, 37);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "<-- Back";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBrowse.Location = new System.Drawing.Point(78, 51);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(91, 33);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Files...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lbFileName
            // 
            lbFileName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbFileName.AutoSize = true;
            lbFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFileName.Location = new System.Drawing.Point(12, 94);
            lbFileName.Name = "lbFileName";
            lbFileName.Size = new System.Drawing.Size(0, 21);
            lbFileName.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(186, 30);
            label1.TabIndex = 5;
            label1.Text = "Number of passes:";
            // 
            // txtNumP
            // 
            txtNumP.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            txtNumP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNumP.Location = new System.Drawing.Point(204, 138);
            txtNumP.Name = "txtNumP";
            txtNumP.Size = new System.Drawing.Size(62, 29);
            txtNumP.TabIndex = 6;
            txtNumP.Text = "3";
            txtNumP.TextChanged += txtNumP_TextChanged;
            // 
            // btnWipe
            // 
            btnWipe.Enabled = false;
            btnWipe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnWipe.Location = new System.Drawing.Point(12, 189);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new System.Drawing.Size(254, 56);
            btnWipe.TabIndex = 7;
            btnWipe.Text = "Wipe Selected File.";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // lbDocDisclosure
            // 
            lbDocDisclosure.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbDocDisclosure.AutoSize = true;
            lbDocDisclosure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDocDisclosure.Location = new System.Drawing.Point(4, 258);
            lbDocDisclosure.Name = "lbDocDisclosure";
            lbDocDisclosure.Size = new System.Drawing.Size(273, 17);
            lbDocDisclosure.TabIndex = 8;
            lbDocDisclosure.Text = "Before using, please read the documentation:";
            // 
            // lbDocLink
            // 
            lbDocLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbDocLink.AutoSize = true;
            lbDocLink.Location = new System.Drawing.Point(17, 275);
            lbDocLink.Name = "lbDocLink";
            lbDocLink.Size = new System.Drawing.Size(245, 15);
            lbDocLink.TabIndex = 10;
            lbDocLink.TabStop = true;
            lbDocLink.Text = "https://docs.jmatthews.uk/sep/secure-delete";
            lbDocLink.LinkClicked += lbDocLink_LinkClicked;
            // 
            // btnSelectDirectory
            // 
            btnSelectDirectory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnSelectDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSelectDirectory.Location = new System.Drawing.Point(175, 51);
            btnSelectDirectory.Name = "btnSelectDirectory";
            btnSelectDirectory.Size = new System.Drawing.Size(91, 33);
            btnSelectDirectory.TabIndex = 11;
            btnSelectDirectory.Text = "Directory...";
            btnSelectDirectory.UseVisualStyleBackColor = true;
            btnSelectDirectory.Click += btnSelectDirectory_Click;
            // 
            // frmWipeFile
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(276, 299);
            Controls.Add(btnSelectDirectory);
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
        private System.Windows.Forms.Button btnSelectDirectory;
    }
}