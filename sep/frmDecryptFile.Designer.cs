namespace sep
{
    partial class frmDecryptFile
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
            this.lbHeading = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnGuesser = new System.Windows.Forms.Button();
            this.cbKeepOriginal = new System.Windows.Forms.CheckBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.pnlGuesser = new System.Windows.Forms.Panel();
            this.btnGuessGo = new System.Windows.Forms.Button();
            this.txtGuesses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSelectedFolder = new System.Windows.Forms.Label();
            this.btnSkipFolder = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lbInsG1 = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.pnlGuesser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeading.Location = new System.Drawing.Point(12, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(487, 45);
            this.lbHeading.TabIndex = 2;
            this.lbHeading.Text = "Simple Encryption Program (SEP)";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnGuesser);
            this.gbMain.Controls.Add(this.cbKeepOriginal);
            this.gbMain.Controls.Add(this.lbFilePath);
            this.gbMain.Controls.Add(this.btnOpen);
            this.gbMain.Controls.Add(this.btnGo);
            this.gbMain.Controls.Add(this.lbIns2);
            this.gbMain.Controls.Add(this.btnConfirmPassword);
            this.gbMain.Controls.Add(this.txtPasswordInput);
            this.gbMain.Controls.Add(this.lbIns1);
            this.gbMain.Location = new System.Drawing.Point(12, 74);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(734, 351);
            this.gbMain.TabIndex = 5;
            this.gbMain.TabStop = false;
            // 
            // btnGuesser
            // 
            this.btnGuesser.Enabled = false;
            this.btnGuesser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuesser.ForeColor = System.Drawing.Color.Black;
            this.btnGuesser.Location = new System.Drawing.Point(240, 165);
            this.btnGuesser.Name = "btnGuesser";
            this.btnGuesser.Size = new System.Drawing.Size(219, 31);
            this.btnGuesser.TabIndex = 15;
            this.btnGuesser.Text = "Use Guesser Instead!";
            this.btnGuesser.UseVisualStyleBackColor = true;
            this.btnGuesser.Click += new System.EventHandler(this.btnGuesser_Click);
            // 
            // cbKeepOriginal
            // 
            this.cbKeepOriginal.AutoSize = true;
            this.cbKeepOriginal.Checked = true;
            this.cbKeepOriginal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeepOriginal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbKeepOriginal.Location = new System.Drawing.Point(38, 256);
            this.cbKeepOriginal.Name = "cbKeepOriginal";
            this.cbKeepOriginal.Size = new System.Drawing.Size(446, 29);
            this.cbKeepOriginal.TabIndex = 14;
            this.cbKeepOriginal.Text = "Would you like to keep the encrypted file as well?";
            this.cbKeepOriginal.UseVisualStyleBackColor = true;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFilePath.Location = new System.Drawing.Point(177, 66);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(0, 21);
            this.lbFilePath.TabIndex = 13;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(38, 57);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(133, 30);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(532, 247);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(186, 43);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Decrypt it!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbIns2
            // 
            this.lbIns2.AutoSize = true;
            this.lbIns2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns2.Location = new System.Drawing.Point(38, 128);
            this.lbIns2.Name = "lbIns2";
            this.lbIns2.Size = new System.Drawing.Size(380, 25);
            this.lbIns2.TabIndex = 4;
            this.lbIns2.Text = "2. Enter the password for this encrypted file.";
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPassword.Location = new System.Drawing.Point(585, 61);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(133, 30);
            this.btnConfirmPassword.TabIndex = 3;
            this.btnConfirmPassword.Text = "Confirm File";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            this.btnConfirmPassword.Visible = false;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPassword_Click);
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordInput.Location = new System.Drawing.Point(38, 166);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.PasswordChar = '*';
            this.txtPasswordInput.Size = new System.Drawing.Size(182, 27);
            this.txtPasswordInput.TabIndex = 1;
            // 
            // lbIns1
            // 
            this.lbIns1.AutoSize = true;
            this.lbIns1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns1.Location = new System.Drawing.Point(38, 24);
            this.lbIns1.Name = "lbIns1";
            this.lbIns1.Size = new System.Drawing.Size(210, 25);
            this.lbIns1.TabIndex = 0;
            this.lbIns1.Text = "1. Locate encrypted file.";
            // 
            // pnlGuesser
            // 
            this.pnlGuesser.Controls.Add(this.btnGuessGo);
            this.pnlGuesser.Controls.Add(this.txtGuesses);
            this.pnlGuesser.Controls.Add(this.label1);
            this.pnlGuesser.Controls.Add(this.lbSelectedFolder);
            this.pnlGuesser.Controls.Add(this.btnSkipFolder);
            this.pnlGuesser.Controls.Add(this.btnChooseFolder);
            this.pnlGuesser.Controls.Add(this.lbInsG1);
            this.pnlGuesser.Location = new System.Drawing.Point(12, 64);
            this.pnlGuesser.Name = "pnlGuesser";
            this.pnlGuesser.Size = new System.Drawing.Size(776, 369);
            this.pnlGuesser.TabIndex = 8;
            this.pnlGuesser.Visible = false;
            // 
            // btnGuessGo
            // 
            this.btnGuessGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuessGo.Location = new System.Drawing.Point(697, 143);
            this.btnGuessGo.Name = "btnGuessGo";
            this.btnGuessGo.Size = new System.Drawing.Size(79, 212);
            this.btnGuessGo.TabIndex = 9;
            this.btnGuessGo.Text = "Go!";
            this.btnGuessGo.UseVisualStyleBackColor = true;
            this.btnGuessGo.Click += new System.EventHandler(this.btnGuessGo_Click);
            // 
            // txtGuesses
            // 
            this.txtGuesses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGuesses.Location = new System.Drawing.Point(16, 143);
            this.txtGuesses.Multiline = true;
            this.txtGuesses.Name = "txtGuesses";
            this.txtGuesses.Size = new System.Drawing.Size(672, 212);
            this.txtGuesses.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input each password guess (one per line)";
            // 
            // lbSelectedFolder
            // 
            this.lbSelectedFolder.AutoSize = true;
            this.lbSelectedFolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectedFolder.Location = new System.Drawing.Point(16, 76);
            this.lbSelectedFolder.Name = "lbSelectedFolder";
            this.lbSelectedFolder.Size = new System.Drawing.Size(196, 25);
            this.lbSelectedFolder.TabIndex = 3;
            this.lbSelectedFolder.Text = "Selected Folder: None";
            // 
            // btnSkipFolder
            // 
            this.btnSkipFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSkipFolder.Location = new System.Drawing.Point(644, 46);
            this.btnSkipFolder.Name = "btnSkipFolder";
            this.btnSkipFolder.Size = new System.Drawing.Size(129, 37);
            this.btnSkipFolder.TabIndex = 2;
            this.btnSkipFolder.Text = "Skip";
            this.btnSkipFolder.UseVisualStyleBackColor = true;
            this.btnSkipFolder.Visible = false;
            this.btnSkipFolder.Click += new System.EventHandler(this.btnSkipFolder_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFolder.Location = new System.Drawing.Point(644, 3);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(129, 37);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "Choose folder...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lbInsG1
            // 
            this.lbInsG1.AutoSize = true;
            this.lbInsG1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInsG1.Location = new System.Drawing.Point(16, 10);
            this.lbInsG1.Name = "lbInsG1";
            this.lbInsG1.Size = new System.Drawing.Size(600, 63);
            this.lbInsG1.TabIndex = 0;
            this.lbInsG1.Text = "Guesser will attempt decryption on your selected file for each of the given passw" +
    "ords.\r\nEach time, creating a new copy of the supposedly decrypted file. \r\nPlease" +
    " choose an output directory.";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackToMain.Location = new System.Drawing.Point(602, 16);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(186, 42);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Cancel Guesser";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Visible = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(602, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDecryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.pnlGuesser);
            this.Name = "frmDecryptFile";
            this.Text = "Decrypt File";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.pnlGuesser.ResumeLayout(false);
            this.pnlGuesser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lbIns2;
        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.CheckBox cbKeepOriginal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuesser;
        private System.Windows.Forms.Panel pnlGuesser;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Label lbInsG1;
        private System.Windows.Forms.Button btnSkipFolder;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lbSelectedFolder;
        private System.Windows.Forms.Button btnGuessGo;
        private System.Windows.Forms.TextBox txtGuesses;
        private System.Windows.Forms.Label label1;
    }
}