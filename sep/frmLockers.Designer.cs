namespace sep
{
    partial class frmLockers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLockers));
            this.lbTitles = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateLocker = new System.Windows.Forms.Button();
            this.btnDeleteLocker = new System.Windows.Forms.Button();
            this.pnlCreateMenu = new System.Windows.Forms.Panel();
            this.btnCreateLockerConfirm = new System.Windows.Forms.Button();
            this.txtLockerName = new System.Windows.Forms.TextBox();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.lbDirectoryListing = new System.Windows.Forms.Label();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCreateMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitles
            // 
            this.lbTitles.AutoSize = true;
            this.lbTitles.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitles.Location = new System.Drawing.Point(12, 9);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(210, 47);
            this.lbTitles.TabIndex = 0;
            this.lbTitles.Text = "SEP: Lockers";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.Location = new System.Drawing.Point(12, 56);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(866, 42);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = resources.GetString("lbWelcome.Text");
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(784, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<-- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 45);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(296, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open Locker";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(180, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Unlock";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(171, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 0;
            // 
            // btnCreateLocker
            // 
            this.btnCreateLocker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateLocker.Location = new System.Drawing.Point(499, 12);
            this.btnCreateLocker.Name = "btnCreateLocker";
            this.btnCreateLocker.Size = new System.Drawing.Size(258, 41);
            this.btnCreateLocker.TabIndex = 5;
            this.btnCreateLocker.Text = "+ Create a new locker";
            this.btnCreateLocker.UseVisualStyleBackColor = true;
            this.btnCreateLocker.Click += new System.EventHandler(this.btnCreateLocker_Click);
            // 
            // btnDeleteLocker
            // 
            this.btnDeleteLocker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteLocker.Location = new System.Drawing.Point(308, 12);
            this.btnDeleteLocker.Name = "btnDeleteLocker";
            this.btnDeleteLocker.Size = new System.Drawing.Size(176, 41);
            this.btnDeleteLocker.TabIndex = 6;
            this.btnDeleteLocker.Text = "- Delete Locker";
            this.btnDeleteLocker.UseVisualStyleBackColor = true;
            this.btnDeleteLocker.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlCreateMenu
            // 
            this.pnlCreateMenu.Controls.Add(this.btnCreateLockerConfirm);
            this.pnlCreateMenu.Controls.Add(this.txtLockerName);
            this.pnlCreateMenu.Controls.Add(this.lbIns2);
            this.pnlCreateMenu.Controls.Add(this.lbDirectoryListing);
            this.pnlCreateMenu.Controls.Add(this.btnOpenDirectory);
            this.pnlCreateMenu.Controls.Add(this.lbIns1);
            this.pnlCreateMenu.Location = new System.Drawing.Point(12, 59);
            this.pnlCreateMenu.Name = "pnlCreateMenu";
            this.pnlCreateMenu.Size = new System.Drawing.Size(891, 379);
            this.pnlCreateMenu.TabIndex = 7;
            this.pnlCreateMenu.Visible = false;
            // 
            // btnCreateLockerConfirm
            // 
            this.btnCreateLockerConfirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateLockerConfirm.Location = new System.Drawing.Point(3, 245);
            this.btnCreateLockerConfirm.Name = "btnCreateLockerConfirm";
            this.btnCreateLockerConfirm.Size = new System.Drawing.Size(511, 41);
            this.btnCreateLockerConfirm.TabIndex = 6;
            this.btnCreateLockerConfirm.Text = "Create Locker";
            this.btnCreateLockerConfirm.UseVisualStyleBackColor = true;
            this.btnCreateLockerConfirm.Click += new System.EventHandler(this.btnCreateLockerConfirm_Click);
            // 
            // txtLockerName
            // 
            this.txtLockerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLockerName.Location = new System.Drawing.Point(290, 158);
            this.txtLockerName.Name = "txtLockerName";
            this.txtLockerName.Size = new System.Drawing.Size(224, 29);
            this.txtLockerName.TabIndex = 4;
            // 
            // lbIns2
            // 
            this.lbIns2.AutoSize = true;
            this.lbIns2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns2.Location = new System.Drawing.Point(3, 157);
            this.lbIns2.Name = "lbIns2";
            this.lbIns2.Size = new System.Drawing.Size(281, 30);
            this.lbIns2.TabIndex = 3;
            this.lbIns2.Text = "Enter a name for your locker:";
            // 
            // lbDirectoryListing
            // 
            this.lbDirectoryListing.AutoSize = true;
            this.lbDirectoryListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDirectoryListing.Location = new System.Drawing.Point(3, 96);
            this.lbDirectoryListing.Name = "lbDirectoryListing";
            this.lbDirectoryListing.Size = new System.Drawing.Size(196, 21);
            this.lbDirectoryListing.TabIndex = 2;
            this.lbDirectoryListing.Text = "Directory Name Goes Here";
            this.lbDirectoryListing.Visible = false;
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenDirectory.Location = new System.Drawing.Point(388, 65);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(126, 36);
            this.btnOpenDirectory.TabIndex = 1;
            this.btnOpenDirectory.Text = "Open";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // lbIns1
            // 
            this.lbIns1.AutoSize = true;
            this.lbIns1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns1.Location = new System.Drawing.Point(3, 66);
            this.lbIns1.Name = "lbIns1";
            this.lbIns1.Size = new System.Drawing.Size(369, 30);
            this.lbIns1.TabIndex = 0;
            this.lbIns1.Text = "Find a directory to store your locker in:";
            // 
            // frmLockers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.pnlCreateMenu);
            this.Controls.Add(this.btnDeleteLocker);
            this.Controls.Add(this.btnCreateLocker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbTitles);
            this.Name = "frmLockers";
            this.Text = "SEP: Lockers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCreateMenu.ResumeLayout(false);
            this.pnlCreateMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitles;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateLocker;
        private System.Windows.Forms.Button btnDeleteLocker;
        private System.Windows.Forms.Panel pnlCreateMenu;
        private System.Windows.Forms.Label lbDirectoryListing;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.Button btnCreateLockerConfirm;
        private System.Windows.Forms.TextBox txtLockerName;
        private System.Windows.Forms.Label lbIns2;
    }
}