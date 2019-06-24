using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Rhino.Licensing;
using lic_check;

namespace lic_gen
{
    public partial class MainForm : Form
    {
        string _privateKeyFile => Path.Combine(Application.StartupPath, "privateKey.xml");
        string _publicKeyFile => Path.Combine(Application.StartupPath, "publicKey.xml");

        public MainForm()
        {
            InitializeComponent();

            cbLicenseType.DataSource = Enum.GetValues(typeof (LicenseType));

            cbLicenseType.SelectedIndex = 2;

            tbPrivateKey.Text = _privateKeyFile;
            tbPublicKey.Text = _publicKeyFile;

            dtExpireDate.Value = new DateTime(DateTime.Now.Date.Year, 12, 31);
        }

        private void btnRsaSecret_Click(object sender, EventArgs e)
        {
            var rsa = new RSACryptoServiceProvider(1024);
            
            File.WriteAllText(_publicKeyFile, rsa.ToXmlString(false));
            File.WriteAllText(_privateKeyFile, rsa.ToXmlString(true));

        }
        

        private void btnGenerateLic_Click(object sender, EventArgs e)
        {
            var privateKey = File.ReadAllText(_privateKeyFile);

            var id = Guid.NewGuid();
            var generator = new LicenseGenerator(privateKey);

            
            var name = tbName.Text;

            var expirationDate = dtExpireDate.Value;

            
            var licenseType = (LicenseType)Enum.Parse(typeof(LicenseType), cbLicenseType.SelectedItem.ToString());

            // generate the license
            
            var license = generator.Generate(name, id, expirationDate, licenseType);

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, license);
            }
        }

        private void btnCheckLic_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var licFile = openFileDialog1.FileName;
                DateTime dt;
                MessageBox.Show(LicenseVerify.IsValid(out dt, licFile, File.ReadAllText(_publicKeyFile)).ToString(), "Check", MessageBoxButtons.OK);
            }
        }
    }
}
