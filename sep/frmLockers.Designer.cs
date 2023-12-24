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
            lbTitles = new System.Windows.Forms.Label();
            lbWelcome = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btnCreateLocker = new System.Windows.Forms.Button();
            btnDeleteLocker = new System.Windows.Forms.Button();
            pnlCreateMenu = new System.Windows.Forms.Panel();
            btnCreateLockerConfirm = new System.Windows.Forms.Button();
            txtLockerName = new System.Windows.Forms.TextBox();
            lbIns2 = new System.Windows.Forms.Label();
            lbDirectoryListing = new System.Windows.Forms.Label();
            btnOpenDirectory = new System.Windows.Forms.Button();
            lbIns1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            pnlCreateMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitles
            // 
            lbTitles.AutoSize = true;
            lbTitles.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitles.Location = new System.Drawing.Point(12, 9);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new System.Drawing.Size(210, 47);
            lbTitles.TabIndex = 0;
            lbTitles.Text = "SEP: Lockers";
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbWelcome.Location = new System.Drawing.Point(12, 56);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new System.Drawing.Size(877, 42);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "Lockers are secure, encrypted folders. You can create them by right-clicking any folder, and selecting \"SEP Convert to Locker\". \r\nLearn More by clicking this message.";
            lbWelcome.Click += lbWelcome_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(784, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(119, 41);
            btnBack.TabIndex = 2;
            btnBack.Text = "<-- Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(12, 110);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(410, 45);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(296, 7);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(110, 32);
            button2.TabIndex = 3;
            button2.Text = "Open Locker";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(180, 7);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(110, 32);
            button1.TabIndex = 2;
            button1.Text = "Unlock";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(171, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 25);
            label2.TabIndex = 0;
            // 
            // btnCreateLocker
            // 
            btnCreateLocker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreateLocker.Location = new System.Drawing.Point(499, 12);
            btnCreateLocker.Name = "btnCreateLocker";
            btnCreateLocker.Size = new System.Drawing.Size(258, 41);
            btnCreateLocker.TabIndex = 5;
            btnCreateLocker.Text = "+ Create a new locker";
            btnCreateLocker.UseVisualStyleBackColor = true;
            btnCreateLocker.Visible = false;
            btnCreateLocker.Click += btnCreateLocker_Click;
            // 
            // btnDeleteLocker
            // 
            btnDeleteLocker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDeleteLocker.Location = new System.Drawing.Point(581, 12);
            btnDeleteLocker.Name = "btnDeleteLocker";
            btnDeleteLocker.Size = new System.Drawing.Size(176, 41);
            btnDeleteLocker.TabIndex = 6;
            btnDeleteLocker.Text = "- Delete Locker";
            btnDeleteLocker.UseVisualStyleBackColor = true;
            btnDeleteLocker.Click += button3_Click;
            // 
            // pnlCreateMenu
            // 
            pnlCreateMenu.Controls.Add(btnCreateLockerConfirm);
            pnlCreateMenu.Controls.Add(txtLockerName);
            pnlCreateMenu.Controls.Add(lbIns2);
            pnlCreateMenu.Controls.Add(lbDirectoryListing);
            pnlCreateMenu.Controls.Add(btnOpenDirectory);
            pnlCreateMenu.Controls.Add(lbIns1);
            pnlCreateMenu.Location = new System.Drawing.Point(12, 59);
            pnlCreateMenu.Name = "pnlCreateMenu";
            pnlCreateMenu.Size = new System.Drawing.Size(891, 379);
            pnlCreateMenu.TabIndex = 7;
            pnlCreateMenu.Visible = false;
            // 
            // btnCreateLockerConfirm
            // 
            btnCreateLockerConfirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreateLockerConfirm.Location = new System.Drawing.Point(3, 245);
            btnCreateLockerConfirm.Name = "btnCreateLockerConfirm";
            btnCreateLockerConfirm.Size = new System.Drawing.Size(511, 41);
            btnCreateLockerConfirm.TabIndex = 6;
            btnCreateLockerConfirm.Text = "Create Locker";
            btnCreateLockerConfirm.UseVisualStyleBackColor = true;
            btnCreateLockerConfirm.Click += btnCreateLockerConfirm_Click;
            // 
            // txtLockerName
            // 
            txtLockerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLockerName.Location = new System.Drawing.Point(290, 158);
            txtLockerName.Name = "txtLockerName";
            txtLockerName.Size = new System.Drawing.Size(224, 29);
            txtLockerName.TabIndex = 4;
            // 
            // lbIns2
            // 
            lbIns2.AutoSize = true;
            lbIns2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns2.Location = new System.Drawing.Point(3, 157);
            lbIns2.Name = "lbIns2";
            lbIns2.Size = new System.Drawing.Size(281, 30);
            lbIns2.TabIndex = 3;
            lbIns2.Text = "Enter a name for your locker:";
            // 
            // lbDirectoryListing
            // 
            lbDirectoryListing.AutoSize = true;
            lbDirectoryListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDirectoryListing.Location = new System.Drawing.Point(3, 96);
            lbDirectoryListing.Name = "lbDirectoryListing";
            lbDirectoryListing.Size = new System.Drawing.Size(196, 21);
            lbDirectoryListing.TabIndex = 2;
            lbDirectoryListing.Text = "Directory Name Goes Here";
            lbDirectoryListing.Visible = false;
            // 
            // btnOpenDirectory
            // 
            btnOpenDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpenDirectory.Location = new System.Drawing.Point(388, 65);
            btnOpenDirectory.Name = "btnOpenDirectory";
            btnOpenDirectory.Size = new System.Drawing.Size(126, 36);
            btnOpenDirectory.TabIndex = 1;
            btnOpenDirectory.Text = "Open";
            btnOpenDirectory.UseVisualStyleBackColor = true;
            btnOpenDirectory.Click += btnOpenDirectory_Click;
            // 
            // lbIns1
            // 
            lbIns1.AutoSize = true;
            lbIns1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns1.Location = new System.Drawing.Point(3, 66);
            lbIns1.Name = "lbIns1";
            lbIns1.Size = new System.Drawing.Size(369, 30);
            lbIns1.TabIndex = 0;
            lbIns1.Text = "Find a directory to store your locker in:";
            // 
            // frmLockers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(915, 450);
            Controls.Add(btnDeleteLocker);
            Controls.Add(btnCreateLocker);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(lbWelcome);
            Controls.Add(lbTitles);
            Controls.Add(pnlCreateMenu);
            Name = "frmLockers";
            Text = "SEP: Lockers";
            Load += frmLockers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCreateMenu.ResumeLayout(false);
            pnlCreateMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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