namespace sep
{
    partial class frmFunctionScreen
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlFileSelect = new System.Windows.Forms.Panel();
            this.lbFileName = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lbIns1 = new System.Windows.Forms.Label();
            this.pnlPasswordInput = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnPWLibFunc = new System.Windows.Forms.Button();
            this.btnGenPassword = new System.Windows.Forms.Button();
            this.pbPWReveal = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbIns2 = new System.Windows.Forms.Label();
            this.pnlFinalSteps = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.cbDeleteAsk = new System.Windows.Forms.CheckBox();
            this.btnUseAuthenticator = new System.Windows.Forms.Button();
            this.lbIns3 = new System.Windows.Forms.Label();
            this.pnlAuthApp = new System.Windows.Forms.Panel();
            this.btnCancelMFASetup = new System.Windows.Forms.Button();
            this.btnConfirmAuthSetup = new System.Windows.Forms.Button();
            this.txtAuthSetupVerify = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbS1 = new System.Windows.Forms.Label();
            this.pbQRAuthSetup = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAuthDecrypt = new System.Windows.Forms.Panel();
            this.btnAuthDecryptCancel = new System.Windows.Forms.Button();
            this.btnAuthDecryptSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthConfirmDecrypt = new System.Windows.Forms.TextBox();
            this.lbAuthInfo = new System.Windows.Forms.Label();
            this.pnlGuesser = new System.Windows.Forms.Panel();
            this.btnCancelGuesser = new System.Windows.Forms.Button();
            this.btnGuessGo = new System.Windows.Forms.Button();
            this.txtGuesses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSelectedFolder = new System.Windows.Forms.Label();
            this.btnSkipFolder = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lbInsG1 = new System.Windows.Forms.Label();
            this.pnlFileSelect.SuspendLayout();
            this.pnlPasswordInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPWReveal)).BeginInit();
            this.pnlFinalSteps.SuspendLayout();
            this.pnlAuthApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRAuthSetup)).BeginInit();
            this.pnlAuthDecrypt.SuspendLayout();
            this.pnlGuesser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(951, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<-- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(22, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(340, 37);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Simple Encryption Program";
            // 
            // pnlFileSelect
            // 
            this.pnlFileSelect.Controls.Add(this.lbFileName);
            this.pnlFileSelect.Controls.Add(this.btnOpenFile);
            this.pnlFileSelect.Controls.Add(this.lbIns1);
            this.pnlFileSelect.Location = new System.Drawing.Point(6, 174);
            this.pnlFileSelect.Name = "pnlFileSelect";
            this.pnlFileSelect.Size = new System.Drawing.Size(370, 196);
            this.pnlFileSelect.TabIndex = 2;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFileName.Location = new System.Drawing.Point(181, 150);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(22, 25);
            this.lbFileName.TabIndex = 2;
            this.lbFileName.Text = "a";
            this.lbFileName.Visible = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFile.Location = new System.Drawing.Point(91, 75);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(182, 59);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lbIns1
            // 
            this.lbIns1.AutoSize = true;
            this.lbIns1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns1.Location = new System.Drawing.Point(40, 26);
            this.lbIns1.Name = "lbIns1";
            this.lbIns1.Size = new System.Drawing.Size(287, 30);
            this.lbIns1.TabIndex = 0;
            this.lbIns1.Text = "Please select a file to encrypt.";
            // 
            // pnlPasswordInput
            // 
            this.pnlPasswordInput.Controls.Add(this.btnConfirm);
            this.pnlPasswordInput.Controls.Add(this.btnPWLibFunc);
            this.pnlPasswordInput.Controls.Add(this.btnGenPassword);
            this.pnlPasswordInput.Controls.Add(this.pbPWReveal);
            this.pnlPasswordInput.Controls.Add(this.txtPassword);
            this.pnlPasswordInput.Controls.Add(this.lbIns2);
            this.pnlPasswordInput.Location = new System.Drawing.Point(384, 174);
            this.pnlPasswordInput.Name = "pnlPasswordInput";
            this.pnlPasswordInput.Size = new System.Drawing.Size(370, 313);
            this.pnlPasswordInput.TabIndex = 4;
            this.pnlPasswordInput.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(15, 237);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(346, 66);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm Password";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnPWLibFunc
            // 
            this.btnPWLibFunc.Enabled = false;
            this.btnPWLibFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPWLibFunc.Location = new System.Drawing.Point(15, 178);
            this.btnPWLibFunc.Name = "btnPWLibFunc";
            this.btnPWLibFunc.Size = new System.Drawing.Size(346, 30);
            this.btnPWLibFunc.TabIndex = 4;
            this.btnPWLibFunc.Text = "Save Password";
            this.btnPWLibFunc.UseVisualStyleBackColor = true;
            this.btnPWLibFunc.Click += new System.EventHandler(this.btnPWLibFunc_Click);
            // 
            // btnGenPassword
            // 
            this.btnGenPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenPassword.Location = new System.Drawing.Point(15, 136);
            this.btnGenPassword.Name = "btnGenPassword";
            this.btnGenPassword.Size = new System.Drawing.Size(346, 30);
            this.btnGenPassword.TabIndex = 3;
            this.btnGenPassword.Text = "Generate Password";
            this.btnGenPassword.UseVisualStyleBackColor = true;
            this.btnGenPassword.Click += new System.EventHandler(this.btnGenPassword_Click);
            // 
            // pbPWReveal
            // 
            this.pbPWReveal.Image = global::sep.Properties.Resources.password_reveal_default;
            this.pbPWReveal.Location = new System.Drawing.Point(313, 71);
            this.pbPWReveal.Name = "pbPWReveal";
            this.pbPWReveal.Size = new System.Drawing.Size(48, 38);
            this.pbPWReveal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPWReveal.TabIndex = 2;
            this.pbPWReveal.TabStop = false;
            this.pbPWReveal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPWReveal_MouseDown);
            this.pbPWReveal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPWReveal_MouseUp);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(13, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(294, 33);
            this.txtPassword.TabIndex = 1;
            // 
            // lbIns2
            // 
            this.lbIns2.AutoSize = true;
            this.lbIns2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns2.Location = new System.Drawing.Point(15, 26);
            this.lbIns2.Name = "lbIns2";
            this.lbIns2.Size = new System.Drawing.Size(346, 30);
            this.lbIns2.TabIndex = 0;
            this.lbIns2.Text = "Enter a password to encrypt the file.";
            this.lbIns2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFinalSteps
            // 
            this.pnlFinalSteps.Controls.Add(this.btnGo);
            this.pnlFinalSteps.Controls.Add(this.cbDeleteAsk);
            this.pnlFinalSteps.Controls.Add(this.btnUseAuthenticator);
            this.pnlFinalSteps.Controls.Add(this.lbIns3);
            this.pnlFinalSteps.Location = new System.Drawing.Point(760, 174);
            this.pnlFinalSteps.Name = "pnlFinalSteps";
            this.pnlFinalSteps.Size = new System.Drawing.Size(370, 313);
            this.pnlFinalSteps.TabIndex = 5;
            this.pnlFinalSteps.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(67, 209);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(239, 70);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Encrypt";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cbDeleteAsk
            // 
            this.cbDeleteAsk.AutoSize = true;
            this.cbDeleteAsk.Location = new System.Drawing.Point(32, 133);
            this.cbDeleteAsk.Name = "cbDeleteAsk";
            this.cbDeleteAsk.Size = new System.Drawing.Size(299, 64);
            this.cbDeleteAsk.TabIndex = 2;
            this.cbDeleteAsk.Text = "Delete the selected file after \r\nencryption.";
            this.cbDeleteAsk.UseVisualStyleBackColor = true;
            // 
            // btnUseAuthenticator
            // 
            this.btnUseAuthenticator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUseAuthenticator.Location = new System.Drawing.Point(67, 71);
            this.btnUseAuthenticator.Name = "btnUseAuthenticator";
            this.btnUseAuthenticator.Size = new System.Drawing.Size(239, 40);
            this.btnUseAuthenticator.TabIndex = 1;
            this.btnUseAuthenticator.Text = "Use Authenticator";
            this.btnUseAuthenticator.UseVisualStyleBackColor = true;
            this.btnUseAuthenticator.Click += new System.EventHandler(this.btnUseAuthenticator_Click);
            // 
            // lbIns3
            // 
            this.lbIns3.AutoSize = true;
            this.lbIns3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIns3.Location = new System.Drawing.Point(106, 26);
            this.lbIns3.Name = "lbIns3";
            this.lbIns3.Size = new System.Drawing.Size(169, 30);
            this.lbIns3.TabIndex = 0;
            this.lbIns3.Text = "Ready to encrypt";
            // 
            // pnlAuthApp
            // 
            this.pnlAuthApp.Controls.Add(this.btnCancelMFASetup);
            this.pnlAuthApp.Controls.Add(this.btnConfirmAuthSetup);
            this.pnlAuthApp.Controls.Add(this.txtAuthSetupVerify);
            this.pnlAuthApp.Controls.Add(this.label3);
            this.pnlAuthApp.Controls.Add(this.lbS1);
            this.pnlAuthApp.Controls.Add(this.pbQRAuthSetup);
            this.pnlAuthApp.Controls.Add(this.label2);
            this.pnlAuthApp.Location = new System.Drawing.Point(198, 114);
            this.pnlAuthApp.Name = "pnlAuthApp";
            this.pnlAuthApp.Size = new System.Drawing.Size(763, 382);
            this.pnlAuthApp.TabIndex = 7;
            this.pnlAuthApp.Visible = false;
            // 
            // btnCancelMFASetup
            // 
            this.btnCancelMFASetup.Location = new System.Drawing.Point(575, 6);
            this.btnCancelMFASetup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancelMFASetup.Name = "btnCancelMFASetup";
            this.btnCancelMFASetup.Size = new System.Drawing.Size(169, 50);
            this.btnCancelMFASetup.TabIndex = 6;
            this.btnCancelMFASetup.Text = "Cancel";
            this.btnCancelMFASetup.UseVisualStyleBackColor = true;
            this.btnCancelMFASetup.Click += new System.EventHandler(this.btnCancelMFASetup_Click);
            // 
            // btnConfirmAuthSetup
            // 
            this.btnConfirmAuthSetup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmAuthSetup.Location = new System.Drawing.Point(365, 269);
            this.btnConfirmAuthSetup.Name = "btnConfirmAuthSetup";
            this.btnConfirmAuthSetup.Size = new System.Drawing.Size(379, 39);
            this.btnConfirmAuthSetup.TabIndex = 5;
            this.btnConfirmAuthSetup.Text = "Confirm";
            this.btnConfirmAuthSetup.UseVisualStyleBackColor = true;
            this.btnConfirmAuthSetup.Click += new System.EventHandler(this.btnConfirmAuthSetup_Click);
            // 
            // txtAuthSetupVerify
            // 
            this.txtAuthSetupVerify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthSetupVerify.Location = new System.Drawing.Point(618, 201);
            this.txtAuthSetupVerify.Name = "txtAuthSetupVerify";
            this.txtAuthSetupVerify.Size = new System.Drawing.Size(108, 33);
            this.txtAuthSetupVerify.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "2. Enter the current code:";
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbS1.Location = new System.Drawing.Point(365, 121);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(310, 60);
            this.lbS1.TabIndex = 2;
            this.lbS1.Text = "1. Scan the QR code using your \r\nauthenticator app.";
            // 
            // pbQRAuthSetup
            // 
            this.pbQRAuthSetup.Location = new System.Drawing.Point(22, 61);
            this.pbQRAuthSetup.Name = "pbQRAuthSetup";
            this.pbQRAuthSetup.Size = new System.Drawing.Size(331, 294);
            this.pbQRAuthSetup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQRAuthSetup.TabIndex = 1;
            this.pbQRAuthSetup.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add an authenticator (MFA) app.";
            // 
            // pnlAuthDecrypt
            // 
            this.pnlAuthDecrypt.Controls.Add(this.btnAuthDecryptCancel);
            this.pnlAuthDecrypt.Controls.Add(this.btnAuthDecryptSubmit);
            this.pnlAuthDecrypt.Controls.Add(this.label1);
            this.pnlAuthDecrypt.Controls.Add(this.txtAuthConfirmDecrypt);
            this.pnlAuthDecrypt.Controls.Add(this.lbAuthInfo);
            this.pnlAuthDecrypt.Location = new System.Drawing.Point(187, 100);
            this.pnlAuthDecrypt.Name = "pnlAuthDecrypt";
            this.pnlAuthDecrypt.Size = new System.Drawing.Size(789, 429);
            this.pnlAuthDecrypt.TabIndex = 2;
            this.pnlAuthDecrypt.Visible = false;
            // 
            // btnAuthDecryptCancel
            // 
            this.btnAuthDecryptCancel.Location = new System.Drawing.Point(605, 11);
            this.btnAuthDecryptCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAuthDecryptCancel.Name = "btnAuthDecryptCancel";
            this.btnAuthDecryptCancel.Size = new System.Drawing.Size(169, 50);
            this.btnAuthDecryptCancel.TabIndex = 8;
            this.btnAuthDecryptCancel.Text = "Cancel";
            this.btnAuthDecryptCancel.UseVisualStyleBackColor = true;
            this.btnAuthDecryptCancel.Click += new System.EventHandler(this.btnAuthDecryptCancel_Click);
            // 
            // btnAuthDecryptSubmit
            // 
            this.btnAuthDecryptSubmit.Location = new System.Drawing.Point(312, 273);
            this.btnAuthDecryptSubmit.Name = "btnAuthDecryptSubmit";
            this.btnAuthDecryptSubmit.Size = new System.Drawing.Size(192, 57);
            this.btnAuthDecryptSubmit.TabIndex = 7;
            this.btnAuthDecryptSubmit.Text = "Submit Code";
            this.btnAuthDecryptSubmit.UseVisualStyleBackColor = true;
            this.btnAuthDecryptSubmit.Click += new System.EventHandler(this.btnAuthDecryptSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "This file uses a secret key! ";
            // 
            // txtAuthConfirmDecrypt
            // 
            this.txtAuthConfirmDecrypt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthConfirmDecrypt.Location = new System.Drawing.Point(353, 198);
            this.txtAuthConfirmDecrypt.Name = "txtAuthConfirmDecrypt";
            this.txtAuthConfirmDecrypt.Size = new System.Drawing.Size(108, 33);
            this.txtAuthConfirmDecrypt.TabIndex = 5;
            // 
            // lbAuthInfo
            // 
            this.lbAuthInfo.AutoSize = true;
            this.lbAuthInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAuthInfo.Location = new System.Drawing.Point(127, 130);
            this.lbAuthInfo.Name = "lbAuthInfo";
            this.lbAuthInfo.Size = new System.Drawing.Size(559, 32);
            this.lbAuthInfo.TabIndex = 0;
            this.lbAuthInfo.Text = "Please enter the code from your authenticator app:";
            this.lbAuthInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlGuesser
            // 
            this.pnlGuesser.Controls.Add(this.btnCancelGuesser);
            this.pnlGuesser.Controls.Add(this.btnGuessGo);
            this.pnlGuesser.Controls.Add(this.txtGuesses);
            this.pnlGuesser.Controls.Add(this.label4);
            this.pnlGuesser.Controls.Add(this.lbSelectedFolder);
            this.pnlGuesser.Controls.Add(this.btnSkipFolder);
            this.pnlGuesser.Controls.Add(this.btnChooseFolder);
            this.pnlGuesser.Controls.Add(this.lbInsG1);
            this.pnlGuesser.Location = new System.Drawing.Point(179, 129);
            this.pnlGuesser.Name = "pnlGuesser";
            this.pnlGuesser.Size = new System.Drawing.Size(776, 369);
            this.pnlGuesser.TabIndex = 9;
            this.pnlGuesser.Visible = false;
            // 
            // btnCancelGuesser
            // 
            this.btnCancelGuesser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelGuesser.Location = new System.Drawing.Point(622, 306);
            this.btnCancelGuesser.Name = "btnCancelGuesser";
            this.btnCancelGuesser.Size = new System.Drawing.Size(151, 49);
            this.btnCancelGuesser.TabIndex = 10;
            this.btnCancelGuesser.Text = "Cancel";
            this.btnCancelGuesser.UseVisualStyleBackColor = true;
            this.btnCancelGuesser.Click += new System.EventHandler(this.btnCancelGuesser_Click);
            // 
            // btnGuessGo
            // 
            this.btnGuessGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuessGo.Location = new System.Drawing.Point(622, 143);
            this.btnGuessGo.Name = "btnGuessGo";
            this.btnGuessGo.Size = new System.Drawing.Size(151, 158);
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
            this.txtGuesses.Size = new System.Drawing.Size(600, 212);
            this.txtGuesses.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Input each password guess (one per line)";
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
            // frmFunctionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 627);
            this.Controls.Add(this.pnlAuthApp);
            this.Controls.Add(this.pnlFinalSteps);
            this.Controls.Add(this.pnlPasswordInput);
            this.Controls.Add(this.pnlFileSelect);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlAuthDecrypt);
            this.Controls.Add(this.pnlGuesser);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmFunctionScreen";
            this.Text = "SEP: Encrypt File";
            this.Load += new System.EventHandler(this.frmFunctionScreen_Load);
            this.pnlFileSelect.ResumeLayout(false);
            this.pnlFileSelect.PerformLayout();
            this.pnlPasswordInput.ResumeLayout(false);
            this.pnlPasswordInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPWReveal)).EndInit();
            this.pnlFinalSteps.ResumeLayout(false);
            this.pnlFinalSteps.PerformLayout();
            this.pnlAuthApp.ResumeLayout(false);
            this.pnlAuthApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRAuthSetup)).EndInit();
            this.pnlAuthDecrypt.ResumeLayout(false);
            this.pnlAuthDecrypt.PerformLayout();
            this.pnlGuesser.ResumeLayout(false);
            this.pnlGuesser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlFileSelect;
        private System.Windows.Forms.Label lbIns1;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Panel pnlPasswordInput;
        private System.Windows.Forms.Label lbIns2;
        private System.Windows.Forms.PictureBox pbPWReveal;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenPassword;
        private System.Windows.Forms.Button btnPWLibFunc;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlFinalSteps;
        private System.Windows.Forms.Button btnUseAuthenticator;
        private System.Windows.Forms.Label lbIns3;
        private System.Windows.Forms.Panel pnlAuthApp;
        private System.Windows.Forms.Button btnConfirmAuthSetup;
        private System.Windows.Forms.TextBox txtAuthSetupVerify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbS1;
        private System.Windows.Forms.PictureBox pbQRAuthSetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelMFASetup;
        private System.Windows.Forms.Panel pnlAuthDecrypt;
        private System.Windows.Forms.Button btnAuthDecryptSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthConfirmDecrypt;
        private System.Windows.Forms.Label lbAuthInfo;
        private System.Windows.Forms.Button btnAuthDecryptCancel;
        private System.Windows.Forms.CheckBox cbDeleteAsk;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel pnlGuesser;
        private System.Windows.Forms.Button btnGuessGo;
        private System.Windows.Forms.TextBox txtGuesses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSelectedFolder;
        private System.Windows.Forms.Button btnSkipFolder;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lbInsG1;
        private System.Windows.Forms.Button btnCancelGuesser;
    }
}