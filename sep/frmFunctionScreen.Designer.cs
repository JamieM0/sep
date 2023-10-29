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
            btnBack = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            pnlFileSelect = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            pbDropIcon = new System.Windows.Forms.PictureBox();
            lbFileName = new System.Windows.Forms.Label();
            btnOpenFile = new System.Windows.Forms.Button();
            lbIns1 = new System.Windows.Forms.Label();
            pnlPasswordInput = new System.Windows.Forms.Panel();
            pbCopyIcon = new System.Windows.Forms.PictureBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnPWLibFunc = new System.Windows.Forms.Button();
            btnGenPassword = new System.Windows.Forms.Button();
            pbPWReveal = new System.Windows.Forms.PictureBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lbIns2 = new System.Windows.Forms.Label();
            pnlFinalSteps = new System.Windows.Forms.Panel();
            btnGo = new System.Windows.Forms.Button();
            cbDeleteAsk = new System.Windows.Forms.CheckBox();
            btnUseAuthenticator = new System.Windows.Forms.Button();
            lbIns3 = new System.Windows.Forms.Label();
            pnlAuthApp = new System.Windows.Forms.Panel();
            btnCancelMFASetup = new System.Windows.Forms.Button();
            btnConfirmAuthSetup = new System.Windows.Forms.Button();
            txtAuthSetupVerify = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lbS1 = new System.Windows.Forms.Label();
            pbQRAuthSetup = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            pnlAuthDecrypt = new System.Windows.Forms.Panel();
            btnAuthDecryptCancel = new System.Windows.Forms.Button();
            btnAuthDecryptSubmit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtAuthConfirmDecrypt = new System.Windows.Forms.TextBox();
            lbAuthInfo = new System.Windows.Forms.Label();
            pnlGuesser = new System.Windows.Forms.Panel();
            btnCancelGuesser = new System.Windows.Forms.Button();
            btnGuessGo = new System.Windows.Forms.Button();
            txtGuesses = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            lbSelectedFolder = new System.Windows.Forms.Label();
            btnSkipFolder = new System.Windows.Forms.Button();
            btnChooseFolder = new System.Windows.Forms.Button();
            lbInsG1 = new System.Windows.Forms.Label();
            pnlLibraryPassword = new System.Windows.Forms.Panel();
            btnPWLibReveal = new System.Windows.Forms.Button();
            btnConfirmPWLib = new System.Windows.Forms.Button();
            txtPWLib = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            lbPWLib = new System.Windows.Forms.Label();
            pnlFileSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDropIcon).BeginInit();
            pnlPasswordInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCopyIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPWReveal).BeginInit();
            pnlFinalSteps.SuspendLayout();
            pnlAuthApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQRAuthSetup).BeginInit();
            pnlAuthDecrypt.SuspendLayout();
            pnlGuesser.SuspendLayout();
            pnlLibraryPassword.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(951, 11);
            btnBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(169, 50);
            btnBack.TabIndex = 0;
            btnBack.Text = "<-- Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(22, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(340, 37);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Simple Encryption Program";
            // 
            // pnlFileSelect
            // 
            pnlFileSelect.Controls.Add(label6);
            pnlFileSelect.Controls.Add(pbDropIcon);
            pnlFileSelect.Controls.Add(lbFileName);
            pnlFileSelect.Controls.Add(btnOpenFile);
            pnlFileSelect.Controls.Add(lbIns1);
            pnlFileSelect.Location = new System.Drawing.Point(8, 92);
            pnlFileSelect.Name = "pnlFileSelect";
            pnlFileSelect.Size = new System.Drawing.Size(370, 474);
            pnlFileSelect.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(98, 294);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(166, 30);
            label6.TabIndex = 4;
            label6.Text = "Drop file(s) here.";
            // 
            // pbDropIcon
            // 
            pbDropIcon.Image = Properties.Resources.noun_drag_and_drop_2709846;
            pbDropIcon.Location = new System.Drawing.Point(108, 327);
            pbDropIcon.Name = "pbDropIcon";
            pbDropIcon.Size = new System.Drawing.Size(137, 118);
            pbDropIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbDropIcon.TabIndex = 3;
            pbDropIcon.TabStop = false;
            // 
            // lbFileName
            // 
            lbFileName.AutoSize = true;
            lbFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFileName.Location = new System.Drawing.Point(108, 170);
            lbFileName.Name = "lbFileName";
            lbFileName.Size = new System.Drawing.Size(18, 21);
            lbFileName.TabIndex = 2;
            lbFileName.Text = "a";
            lbFileName.Visible = false;
            lbFileName.DragDrop += lbFileName_DragDrop;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpenFile.Location = new System.Drawing.Point(75, 76);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new System.Drawing.Size(206, 66);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Choose File(s)";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // lbIns1
            // 
            lbIns1.AutoSize = true;
            lbIns1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns1.Location = new System.Drawing.Point(37, 26);
            lbIns1.Name = "lbIns1";
            lbIns1.Size = new System.Drawing.Size(291, 30);
            lbIns1.TabIndex = 0;
            lbIns1.Text = "Please select file(s) to encrypt.";
            // 
            // pnlPasswordInput
            // 
            pnlPasswordInput.Controls.Add(pbCopyIcon);
            pnlPasswordInput.Controls.Add(btnConfirm);
            pnlPasswordInput.Controls.Add(btnPWLibFunc);
            pnlPasswordInput.Controls.Add(btnGenPassword);
            pnlPasswordInput.Controls.Add(pbPWReveal);
            pnlPasswordInput.Controls.Add(txtPassword);
            pnlPasswordInput.Controls.Add(lbIns2);
            pnlPasswordInput.Location = new System.Drawing.Point(384, 174);
            pnlPasswordInput.Name = "pnlPasswordInput";
            pnlPasswordInput.Size = new System.Drawing.Size(370, 313);
            pnlPasswordInput.TabIndex = 4;
            pnlPasswordInput.Visible = false;
            // 
            // pbCopyIcon
            // 
            pbCopyIcon.Location = new System.Drawing.Point(313, 71);
            pbCopyIcon.Name = "pbCopyIcon";
            pbCopyIcon.Size = new System.Drawing.Size(48, 38);
            pbCopyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbCopyIcon.TabIndex = 6;
            pbCopyIcon.TabStop = false;
            pbCopyIcon.Click += pbCopyIcon_Click;
            pbCopyIcon.MouseDown += pbCopyIcon_MouseDown;
            pbCopyIcon.MouseUp += pbCopyIcon_MouseUp;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Location = new System.Drawing.Point(15, 237);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(346, 66);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm Password";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnPWLibFunc
            // 
            btnPWLibFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPWLibFunc.Location = new System.Drawing.Point(15, 178);
            btnPWLibFunc.Name = "btnPWLibFunc";
            btnPWLibFunc.Size = new System.Drawing.Size(346, 30);
            btnPWLibFunc.TabIndex = 4;
            btnPWLibFunc.Text = "Save Password";
            btnPWLibFunc.UseVisualStyleBackColor = true;
            btnPWLibFunc.Click += btnPWLibFunc_Click;
            // 
            // btnGenPassword
            // 
            btnGenPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGenPassword.Location = new System.Drawing.Point(15, 136);
            btnGenPassword.Name = "btnGenPassword";
            btnGenPassword.Size = new System.Drawing.Size(346, 30);
            btnGenPassword.TabIndex = 3;
            btnGenPassword.Text = "Generate Password";
            btnGenPassword.UseVisualStyleBackColor = true;
            btnGenPassword.Click += btnGenPassword_Click;
            // 
            // pbPWReveal
            // 
            pbPWReveal.Image = Properties.Resources.password_reveal_default;
            pbPWReveal.Location = new System.Drawing.Point(259, 71);
            pbPWReveal.Name = "pbPWReveal";
            pbPWReveal.Size = new System.Drawing.Size(48, 38);
            pbPWReveal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbPWReveal.TabIndex = 2;
            pbPWReveal.TabStop = false;
            pbPWReveal.MouseDown += pbPWReveal_MouseDown;
            pbPWReveal.MouseUp += pbPWReveal_MouseUp;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(13, 75);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(240, 33);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lbIns2
            // 
            lbIns2.AutoSize = true;
            lbIns2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns2.Location = new System.Drawing.Point(15, 26);
            lbIns2.Name = "lbIns2";
            lbIns2.Size = new System.Drawing.Size(346, 30);
            lbIns2.TabIndex = 0;
            lbIns2.Text = "Enter a password to encrypt the file.";
            lbIns2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFinalSteps
            // 
            pnlFinalSteps.Controls.Add(btnGo);
            pnlFinalSteps.Controls.Add(cbDeleteAsk);
            pnlFinalSteps.Controls.Add(btnUseAuthenticator);
            pnlFinalSteps.Controls.Add(lbIns3);
            pnlFinalSteps.Location = new System.Drawing.Point(760, 117);
            pnlFinalSteps.Name = "pnlFinalSteps";
            pnlFinalSteps.Size = new System.Drawing.Size(370, 386);
            pnlFinalSteps.TabIndex = 5;
            pnlFinalSteps.Visible = false;
            // 
            // btnGo
            // 
            btnGo.Location = new System.Drawing.Point(67, 209);
            btnGo.Name = "btnGo";
            btnGo.Size = new System.Drawing.Size(239, 70);
            btnGo.TabIndex = 3;
            btnGo.Text = "Encrypt";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // cbDeleteAsk
            // 
            cbDeleteAsk.AutoSize = true;
            cbDeleteAsk.Location = new System.Drawing.Point(32, 133);
            cbDeleteAsk.Name = "cbDeleteAsk";
            cbDeleteAsk.Size = new System.Drawing.Size(320, 64);
            cbDeleteAsk.TabIndex = 2;
            cbDeleteAsk.Text = "Delete the selected file(s) after \r\nencryption.";
            cbDeleteAsk.UseVisualStyleBackColor = true;
            cbDeleteAsk.CheckedChanged += cbDeleteAsk_CheckedChanged;
            // 
            // btnUseAuthenticator
            // 
            btnUseAuthenticator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUseAuthenticator.Location = new System.Drawing.Point(67, 71);
            btnUseAuthenticator.Name = "btnUseAuthenticator";
            btnUseAuthenticator.Size = new System.Drawing.Size(239, 40);
            btnUseAuthenticator.TabIndex = 1;
            btnUseAuthenticator.Text = "Use Authenticator";
            btnUseAuthenticator.UseVisualStyleBackColor = true;
            btnUseAuthenticator.Visible = false;
            btnUseAuthenticator.Click += btnUseAuthenticator_Click;
            // 
            // lbIns3
            // 
            lbIns3.AutoSize = true;
            lbIns3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbIns3.Location = new System.Drawing.Point(91, 36);
            lbIns3.Name = "lbIns3";
            lbIns3.Size = new System.Drawing.Size(194, 32);
            lbIns3.TabIndex = 0;
            lbIns3.Text = "Ready to encrypt";
            // 
            // pnlAuthApp
            // 
            pnlAuthApp.Controls.Add(btnCancelMFASetup);
            pnlAuthApp.Controls.Add(btnConfirmAuthSetup);
            pnlAuthApp.Controls.Add(txtAuthSetupVerify);
            pnlAuthApp.Controls.Add(label3);
            pnlAuthApp.Controls.Add(lbS1);
            pnlAuthApp.Controls.Add(pbQRAuthSetup);
            pnlAuthApp.Controls.Add(label2);
            pnlAuthApp.Location = new System.Drawing.Point(198, 114);
            pnlAuthApp.Name = "pnlAuthApp";
            pnlAuthApp.Size = new System.Drawing.Size(763, 382);
            pnlAuthApp.TabIndex = 7;
            pnlAuthApp.Visible = false;
            // 
            // btnCancelMFASetup
            // 
            btnCancelMFASetup.Location = new System.Drawing.Point(575, 6);
            btnCancelMFASetup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnCancelMFASetup.Name = "btnCancelMFASetup";
            btnCancelMFASetup.Size = new System.Drawing.Size(169, 50);
            btnCancelMFASetup.TabIndex = 6;
            btnCancelMFASetup.Text = "Cancel";
            btnCancelMFASetup.UseVisualStyleBackColor = true;
            btnCancelMFASetup.Click += btnCancelMFASetup_Click;
            // 
            // btnConfirmAuthSetup
            // 
            btnConfirmAuthSetup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirmAuthSetup.Location = new System.Drawing.Point(365, 269);
            btnConfirmAuthSetup.Name = "btnConfirmAuthSetup";
            btnConfirmAuthSetup.Size = new System.Drawing.Size(379, 39);
            btnConfirmAuthSetup.TabIndex = 5;
            btnConfirmAuthSetup.Text = "Confirm";
            btnConfirmAuthSetup.UseVisualStyleBackColor = true;
            btnConfirmAuthSetup.Click += btnConfirmAuthSetup_Click;
            // 
            // txtAuthSetupVerify
            // 
            txtAuthSetupVerify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAuthSetupVerify.Location = new System.Drawing.Point(618, 201);
            txtAuthSetupVerify.Name = "txtAuthSetupVerify";
            txtAuthSetupVerify.Size = new System.Drawing.Size(108, 33);
            txtAuthSetupVerify.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(365, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(247, 30);
            label3.TabIndex = 3;
            label3.Text = "2. Enter the current code:";
            // 
            // lbS1
            // 
            lbS1.AutoSize = true;
            lbS1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbS1.Location = new System.Drawing.Point(365, 121);
            lbS1.Name = "lbS1";
            lbS1.Size = new System.Drawing.Size(310, 60);
            lbS1.TabIndex = 2;
            lbS1.Text = "1. Scan the QR code using your \r\nauthenticator app.";
            // 
            // pbQRAuthSetup
            // 
            pbQRAuthSetup.Location = new System.Drawing.Point(22, 61);
            pbQRAuthSetup.Name = "pbQRAuthSetup";
            pbQRAuthSetup.Size = new System.Drawing.Size(331, 294);
            pbQRAuthSetup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbQRAuthSetup.TabIndex = 1;
            pbQRAuthSetup.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(16, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(401, 37);
            label2.TabIndex = 0;
            label2.Text = "Add an authenticator (MFA) app.";
            // 
            // pnlAuthDecrypt
            // 
            pnlAuthDecrypt.Controls.Add(btnAuthDecryptCancel);
            pnlAuthDecrypt.Controls.Add(btnAuthDecryptSubmit);
            pnlAuthDecrypt.Controls.Add(label1);
            pnlAuthDecrypt.Controls.Add(txtAuthConfirmDecrypt);
            pnlAuthDecrypt.Controls.Add(lbAuthInfo);
            pnlAuthDecrypt.Location = new System.Drawing.Point(187, 100);
            pnlAuthDecrypt.Name = "pnlAuthDecrypt";
            pnlAuthDecrypt.Size = new System.Drawing.Size(789, 429);
            pnlAuthDecrypt.TabIndex = 2;
            pnlAuthDecrypt.Visible = false;
            // 
            // btnAuthDecryptCancel
            // 
            btnAuthDecryptCancel.Location = new System.Drawing.Point(605, 11);
            btnAuthDecryptCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAuthDecryptCancel.Name = "btnAuthDecryptCancel";
            btnAuthDecryptCancel.Size = new System.Drawing.Size(169, 50);
            btnAuthDecryptCancel.TabIndex = 8;
            btnAuthDecryptCancel.Text = "Cancel";
            btnAuthDecryptCancel.UseVisualStyleBackColor = true;
            btnAuthDecryptCancel.Click += btnAuthDecryptCancel_Click;
            // 
            // btnAuthDecryptSubmit
            // 
            btnAuthDecryptSubmit.Location = new System.Drawing.Point(312, 273);
            btnAuthDecryptSubmit.Name = "btnAuthDecryptSubmit";
            btnAuthDecryptSubmit.Size = new System.Drawing.Size(192, 57);
            btnAuthDecryptSubmit.TabIndex = 7;
            btnAuthDecryptSubmit.Text = "Submit Code";
            btnAuthDecryptSubmit.UseVisualStyleBackColor = true;
            btnAuthDecryptSubmit.Click += btnAuthDecryptSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(234, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(324, 37);
            label1.TabIndex = 6;
            label1.Text = "This file uses a secret key! ";
            // 
            // txtAuthConfirmDecrypt
            // 
            txtAuthConfirmDecrypt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAuthConfirmDecrypt.Location = new System.Drawing.Point(353, 198);
            txtAuthConfirmDecrypt.Name = "txtAuthConfirmDecrypt";
            txtAuthConfirmDecrypt.Size = new System.Drawing.Size(108, 33);
            txtAuthConfirmDecrypt.TabIndex = 5;
            // 
            // lbAuthInfo
            // 
            lbAuthInfo.AutoSize = true;
            lbAuthInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAuthInfo.Location = new System.Drawing.Point(127, 130);
            lbAuthInfo.Name = "lbAuthInfo";
            lbAuthInfo.Size = new System.Drawing.Size(559, 32);
            lbAuthInfo.TabIndex = 0;
            lbAuthInfo.Text = "Please enter the code from your authenticator app:";
            lbAuthInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlGuesser
            // 
            pnlGuesser.Controls.Add(btnCancelGuesser);
            pnlGuesser.Controls.Add(btnGuessGo);
            pnlGuesser.Controls.Add(txtGuesses);
            pnlGuesser.Controls.Add(label4);
            pnlGuesser.Controls.Add(lbSelectedFolder);
            pnlGuesser.Controls.Add(btnSkipFolder);
            pnlGuesser.Controls.Add(btnChooseFolder);
            pnlGuesser.Controls.Add(lbInsG1);
            pnlGuesser.Location = new System.Drawing.Point(179, 129);
            pnlGuesser.Name = "pnlGuesser";
            pnlGuesser.Size = new System.Drawing.Size(776, 369);
            pnlGuesser.TabIndex = 9;
            pnlGuesser.Visible = false;
            // 
            // btnCancelGuesser
            // 
            btnCancelGuesser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelGuesser.Location = new System.Drawing.Point(622, 306);
            btnCancelGuesser.Name = "btnCancelGuesser";
            btnCancelGuesser.Size = new System.Drawing.Size(151, 49);
            btnCancelGuesser.TabIndex = 10;
            btnCancelGuesser.Text = "Cancel";
            btnCancelGuesser.UseVisualStyleBackColor = true;
            btnCancelGuesser.Click += btnCancelGuesser_Click;
            // 
            // btnGuessGo
            // 
            btnGuessGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGuessGo.Location = new System.Drawing.Point(622, 143);
            btnGuessGo.Name = "btnGuessGo";
            btnGuessGo.Size = new System.Drawing.Size(151, 158);
            btnGuessGo.TabIndex = 9;
            btnGuessGo.Text = "Go!";
            btnGuessGo.UseVisualStyleBackColor = true;
            btnGuessGo.Click += btnGuessGo_Click;
            // 
            // txtGuesses
            // 
            txtGuesses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtGuesses.Location = new System.Drawing.Point(16, 143);
            txtGuesses.Multiline = true;
            txtGuesses.Name = "txtGuesses";
            txtGuesses.Size = new System.Drawing.Size(600, 212);
            txtGuesses.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(16, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(293, 21);
            label4.TabIndex = 4;
            label4.Text = "Input each password guess (one per line)";
            // 
            // lbSelectedFolder
            // 
            lbSelectedFolder.AutoSize = true;
            lbSelectedFolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbSelectedFolder.Location = new System.Drawing.Point(16, 76);
            lbSelectedFolder.Name = "lbSelectedFolder";
            lbSelectedFolder.Size = new System.Drawing.Size(196, 25);
            lbSelectedFolder.TabIndex = 3;
            lbSelectedFolder.Text = "Selected Folder: None";
            // 
            // btnSkipFolder
            // 
            btnSkipFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSkipFolder.Location = new System.Drawing.Point(644, 46);
            btnSkipFolder.Name = "btnSkipFolder";
            btnSkipFolder.Size = new System.Drawing.Size(129, 37);
            btnSkipFolder.TabIndex = 2;
            btnSkipFolder.Text = "Skip";
            btnSkipFolder.UseVisualStyleBackColor = true;
            btnSkipFolder.Visible = false;
            btnSkipFolder.Click += btnSkipFolder_Click;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnChooseFolder.Location = new System.Drawing.Point(644, 3);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new System.Drawing.Size(129, 37);
            btnChooseFolder.TabIndex = 1;
            btnChooseFolder.Text = "Choose folder...";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // lbInsG1
            // 
            lbInsG1.AutoSize = true;
            lbInsG1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbInsG1.Location = new System.Drawing.Point(16, 10);
            lbInsG1.Name = "lbInsG1";
            lbInsG1.Size = new System.Drawing.Size(600, 63);
            lbInsG1.TabIndex = 0;
            lbInsG1.Text = "Guesser will attempt decryption on your selected file for each of the given passwords.\r\nEach time, creating a new copy of the supposedly decrypted file. \r\nPlease choose an output directory.";
            // 
            // pnlLibraryPassword
            // 
            pnlLibraryPassword.Controls.Add(btnPWLibReveal);
            pnlLibraryPassword.Controls.Add(btnConfirmPWLib);
            pnlLibraryPassword.Controls.Add(txtPWLib);
            pnlLibraryPassword.Controls.Add(label5);
            pnlLibraryPassword.Controls.Add(lbPWLib);
            pnlLibraryPassword.Location = new System.Drawing.Point(384, 94);
            pnlLibraryPassword.Name = "pnlLibraryPassword";
            pnlLibraryPassword.Size = new System.Drawing.Size(370, 409);
            pnlLibraryPassword.TabIndex = 10;
            pnlLibraryPassword.Visible = false;
            // 
            // btnPWLibReveal
            // 
            btnPWLibReveal.Location = new System.Drawing.Point(244, 260);
            btnPWLibReveal.Name = "btnPWLibReveal";
            btnPWLibReveal.Size = new System.Drawing.Size(117, 58);
            btnPWLibReveal.TabIndex = 5;
            btnPWLibReveal.Text = "Show";
            btnPWLibReveal.UseVisualStyleBackColor = true;
            btnPWLibReveal.MouseDown += btnPWLibReveal_MouseDown;
            btnPWLibReveal.MouseUp += btnPWLibReveal_MouseUp;
            // 
            // btnConfirmPWLib
            // 
            btnConfirmPWLib.Location = new System.Drawing.Point(13, 260);
            btnConfirmPWLib.Name = "btnConfirmPWLib";
            btnConfirmPWLib.Size = new System.Drawing.Size(225, 58);
            btnConfirmPWLib.TabIndex = 4;
            btnConfirmPWLib.Text = "Confirm Password";
            btnConfirmPWLib.UseVisualStyleBackColor = true;
            btnConfirmPWLib.Click += button1_Click;
            // 
            // txtPWLib
            // 
            txtPWLib.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPWLib.Location = new System.Drawing.Point(9, 212);
            txtPWLib.Name = "txtPWLib";
            txtPWLib.PasswordChar = '*';
            txtPWLib.Size = new System.Drawing.Size(352, 33);
            txtPWLib.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(0, 67);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(371, 125);
            label5.TabIndex = 2;
            label5.Text = "Please enter a master password for your \r\npassword library.\r\n\r\nYou will need to remember it as contents\r\nof the library will be unavailable without it.";
            label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPWLib
            // 
            lbPWLib.AutoSize = true;
            lbPWLib.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPWLib.Location = new System.Drawing.Point(106, 24);
            lbPWLib.Name = "lbPWLib";
            lbPWLib.Size = new System.Drawing.Size(167, 30);
            lbPWLib.TabIndex = 1;
            lbPWLib.Text = "Password Library";
            // 
            // frmFunctionScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1134, 578);
            Controls.Add(pnlLibraryPassword);
            Controls.Add(pnlFinalSteps);
            Controls.Add(pnlPasswordInput);
            Controls.Add(pnlFileSelect);
            Controls.Add(lbTitle);
            Controls.Add(btnBack);
            Controls.Add(pnlGuesser);
            Controls.Add(pnlAuthApp);
            Controls.Add(pnlAuthDecrypt);
            Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmFunctionScreen";
            Text = "SEP: Encrypt File";
            Load += frmFunctionScreen_Load;
            DragDrop += frmFunctionScreen_DragDrop;
            DragEnter += frmFunctionScreen_DragEnter;
            pnlFileSelect.ResumeLayout(false);
            pnlFileSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDropIcon).EndInit();
            pnlPasswordInput.ResumeLayout(false);
            pnlPasswordInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCopyIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPWReveal).EndInit();
            pnlFinalSteps.ResumeLayout(false);
            pnlFinalSteps.PerformLayout();
            pnlAuthApp.ResumeLayout(false);
            pnlAuthApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbQRAuthSetup).EndInit();
            pnlAuthDecrypt.ResumeLayout(false);
            pnlAuthDecrypt.PerformLayout();
            pnlGuesser.ResumeLayout(false);
            pnlGuesser.PerformLayout();
            pnlLibraryPassword.ResumeLayout(false);
            pnlLibraryPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.PictureBox pbCopyIcon;
        private System.Windows.Forms.Panel pnlLibraryPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPWLib;
        private System.Windows.Forms.Button btnConfirmPWLib;
        private System.Windows.Forms.TextBox txtPWLib;
        private System.Windows.Forms.Button btnPWLibReveal;
        private System.Windows.Forms.PictureBox pbDropIcon;
        private System.Windows.Forms.Label label6;
    }
}