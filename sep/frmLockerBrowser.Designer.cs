namespace sep
{
    partial class frmLockerBrowser
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
            dgLockersBrowser = new System.Windows.Forms.DataGridView();
            lbWelcome = new System.Windows.Forms.Label();
            lbTitles = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            btnCreateLocker = new System.Windows.Forms.Button();
            btnDeleteLocker = new System.Windows.Forms.Button();
            btnLockAction = new System.Windows.Forms.Button();
            btnOpenLocker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgLockersBrowser).BeginInit();
            SuspendLayout();
            // 
            // dgLockersBrowser
            // 
            dgLockersBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLockersBrowser.Location = new System.Drawing.Point(20, 118);
            dgLockersBrowser.Name = "dgLockersBrowser";
            dgLockersBrowser.ReadOnly = true;
            dgLockersBrowser.RowTemplate.Height = 25;
            dgLockersBrowser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgLockersBrowser.Size = new System.Drawing.Size(699, 250);
            dgLockersBrowser.TabIndex = 0;
            dgLockersBrowser.CellClick += dgLockersBrowser_CellClick;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbWelcome.Location = new System.Drawing.Point(20, 56);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new System.Drawing.Size(705, 42);
            lbWelcome.TabIndex = 3;
            lbWelcome.Text = "Lockers are secure, encrypted folders. You can create them by right-clicking any folder, and selecting \r\n\"SEP Convert to Locker\".  Learn More by clicking this message.";
            lbWelcome.Click += lbWelcome_Click;
            // 
            // lbTitles
            // 
            lbTitles.AutoSize = true;
            lbTitles.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitles.Location = new System.Drawing.Point(20, 9);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new System.Drawing.Size(210, 47);
            lbTitles.TabIndex = 2;
            lbTitles.Text = "SEP: Lockers";
            // 
            // btnBack
            // 
            btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(600, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(119, 41);
            btnBack.TabIndex = 4;
            btnBack.Text = "<-- Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateLocker
            // 
            btnCreateLocker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreateLocker.Location = new System.Drawing.Point(382, 12);
            btnCreateLocker.Name = "btnCreateLocker";
            btnCreateLocker.Size = new System.Drawing.Size(196, 41);
            btnCreateLocker.TabIndex = 5;
            btnCreateLocker.Text = "+ Create Locker";
            btnCreateLocker.UseVisualStyleBackColor = true;
            btnCreateLocker.Click += btnCreateLocker_Click;
            // 
            // btnDeleteLocker
            // 
            btnDeleteLocker.Enabled = false;
            btnDeleteLocker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDeleteLocker.Location = new System.Drawing.Point(519, 388);
            btnDeleteLocker.Name = "btnDeleteLocker";
            btnDeleteLocker.Size = new System.Drawing.Size(200, 50);
            btnDeleteLocker.TabIndex = 6;
            btnDeleteLocker.Text = "Delete Locker";
            btnDeleteLocker.UseVisualStyleBackColor = true;
            btnDeleteLocker.Click += btnDeleteLocker_Click;
            // 
            // btnLockAction
            // 
            btnLockAction.Enabled = false;
            btnLockAction.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLockAction.Location = new System.Drawing.Point(20, 386);
            btnLockAction.Name = "btnLockAction";
            btnLockAction.Size = new System.Drawing.Size(200, 50);
            btnLockAction.TabIndex = 7;
            btnLockAction.Text = "Lock Locker";
            btnLockAction.UseVisualStyleBackColor = true;
            btnLockAction.Click += btnLockAction_Click;
            // 
            // btnOpenLocker
            // 
            btnOpenLocker.Enabled = false;
            btnOpenLocker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpenLocker.Location = new System.Drawing.Point(274, 388);
            btnOpenLocker.Name = "btnOpenLocker";
            btnOpenLocker.Size = new System.Drawing.Size(200, 50);
            btnOpenLocker.TabIndex = 8;
            btnOpenLocker.Text = "Open Locker";
            btnOpenLocker.UseVisualStyleBackColor = true;
            btnOpenLocker.Click += btnOpenLocker_Click;
            // 
            // frmLockerBrowser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(735, 455);
            Controls.Add(btnOpenLocker);
            Controls.Add(btnLockAction);
            Controls.Add(btnDeleteLocker);
            Controls.Add(btnCreateLocker);
            Controls.Add(btnBack);
            Controls.Add(lbWelcome);
            Controls.Add(lbTitles);
            Controls.Add(dgLockersBrowser);
            Name = "frmLockerBrowser";
            Text = "SEP: Lockers (Browser)";
            ((System.ComponentModel.ISupportInitialize)dgLockersBrowser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgLockersBrowser;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbTitles;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateLocker;
        private System.Windows.Forms.Button btnDeleteLocker;
        private System.Windows.Forms.Button btnLockAction;
        private System.Windows.Forms.Button btnOpenLocker;
    }
}