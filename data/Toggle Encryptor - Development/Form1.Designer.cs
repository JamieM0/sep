
namespace Toggle_Encryptor___Development
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbHeading = new System.Windows.Forms.Label();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lbAbout1 = new System.Windows.Forms.Label();
            this.gbAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeading.Location = new System.Drawing.Point(12, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(699, 45);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Encryption Program Protocol (TEPP) - Prototype";
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.lbAbout1);
            this.gbAbout.Location = new System.Drawing.Point(12, 66);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(734, 319);
            this.gbAbout.TabIndex = 1;
            this.gbAbout.TabStop = false;
            // 
            // lbAbout1
            // 
            this.lbAbout1.AutoSize = true;
            this.lbAbout1.Location = new System.Drawing.Point(6, 19);
            this.lbAbout1.Name = "lbAbout1";
            this.lbAbout1.Size = new System.Drawing.Size(723, 195);
            this.lbAbout1.TabIndex = 0;
            this.lbAbout1.Text = resources.GetString("lbAbout1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAbout);
            this.Controls.Add(this.lbHeading);
            this.Name = "Form1";
            this.Text = "Toggle Encryptor - Prototype";
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.Label lbAbout1;
    }
}

