namespace lic_gen
{
    partial class MainForm
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
            this.btnCreateSecret = new System.Windows.Forms.Button();
            this.btnGenerateLic = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.cbNeverExpired = new System.Windows.Forms.CheckBox();
            this.cbLicenseType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCheckLic = new System.Windows.Forms.Button();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateSecret
            // 
            this.btnCreateSecret.Location = new System.Drawing.Point(442, 15);
            this.btnCreateSecret.Name = "btnCreateSecret";
            this.btnCreateSecret.Size = new System.Drawing.Size(122, 23);
            this.btnCreateSecret.TabIndex = 0;
            this.btnCreateSecret.Text = "Create key pair";
            this.btnCreateSecret.UseVisualStyleBackColor = true;
            this.btnCreateSecret.Click += new System.EventHandler(this.btnRsaSecret_Click);
            // 
            // btnGenerateLic
            // 
            this.btnGenerateLic.Location = new System.Drawing.Point(252, 182);
            this.btnGenerateLic.Name = "btnGenerateLic";
            this.btnGenerateLic.Size = new System.Drawing.Size(183, 23);
            this.btnGenerateLic.TabIndex = 2;
            this.btnGenerateLic.Text = "Generate licence";
            this.btnGenerateLic.UseVisualStyleBackColor = true;
            this.btnGenerateLic.Click += new System.EventHandler(this.btnGenerateLic_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(287, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(148, 20);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ExpireDate";
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.Location = new System.Drawing.Point(287, 118);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(148, 20);
            this.dtExpireDate.TabIndex = 9;
            this.dtExpireDate.Value = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            // 
            // cbNeverExpired
            // 
            this.cbNeverExpired.AutoSize = true;
            this.cbNeverExpired.Location = new System.Drawing.Point(442, 120);
            this.cbNeverExpired.Name = "cbNeverExpired";
            this.cbNeverExpired.Size = new System.Drawing.Size(55, 17);
            this.cbNeverExpired.TabIndex = 10;
            this.cbNeverExpired.Text = "Never";
            this.cbNeverExpired.UseVisualStyleBackColor = true;
            // 
            // cbLicenseType
            // 
            this.cbLicenseType.FormattingEnabled = true;
            this.cbLicenseType.Location = new System.Drawing.Point(287, 145);
            this.cbLicenseType.Name = "cbLicenseType";
            this.cbLicenseType.Size = new System.Drawing.Size(148, 21);
            this.cbLicenseType.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "License type";
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Location = new System.Drawing.Point(82, 15);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.ReadOnly = true;
            this.tbPrivateKey.Size = new System.Drawing.Size(353, 20);
            this.tbPrivateKey.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCheckLic
            // 
            this.btnCheckLic.Location = new System.Drawing.Point(252, 221);
            this.btnCheckLic.Name = "btnCheckLic";
            this.btnCheckLic.Size = new System.Drawing.Size(183, 23);
            this.btnCheckLic.TabIndex = 14;
            this.btnCheckLic.Text = "Check licence";
            this.btnCheckLic.UseVisualStyleBackColor = true;
            this.btnCheckLic.Click += new System.EventHandler(this.btnCheckLic_Click);
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(82, 43);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.ReadOnly = true;
            this.tbPublicKey.Size = new System.Drawing.Size(353, 20);
            this.tbPublicKey.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Private key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Public key";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 312);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPublicKey);
            this.Controls.Add(this.btnCheckLic);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLicenseType);
            this.Controls.Add(this.cbNeverExpired);
            this.Controls.Add(this.dtExpireDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnGenerateLic);
            this.Controls.Add(this.btnCreateSecret);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSecret;
        private System.Windows.Forms.Button btnGenerateLic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.CheckBox cbNeverExpired;
        private System.Windows.Forms.ComboBox cbLicenseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCheckLic;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

