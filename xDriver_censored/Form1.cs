using lic_check;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xDriver_censored
{
    public partial class Form1 : Form
    {
        string _licenseFile => Path.Combine(Application.StartupPath, "license");
        string _publicKeyFile => Path.Combine(Application.StartupPath, "publicKey.xml");

        public Form1()
        {
            InitializeComponent();
            tbComputerId.Text = GetCpuInfo();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.MinValue;

            bool isValid = false;
            
            if(File.Exists(_licenseFile) && File.Exists(_publicKeyFile))
                isValid = LicenseVerify.IsValid(out dt, _licenseFile, File.ReadAllText(_publicKeyFile));
            if (isValid)
            {
                lblLicenseCheckResult.Text = $"License is OK till {dt.ToString()}";
                lblLicenseCheckResult.ForeColor = Color.Green;
            }
            else
            {
                lblLicenseCheckResult.Text = "Not Licensed!!!";
                lblLicenseCheckResult.ForeColor = Color.Red;
            }

        }

        
        string GetCpuInfo()
        {
            var mc = new ManagementClass("win32_processor");
            var moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                return mo.Properties["processorID"].Value.ToString();
            }

            return string.Empty;
        }
    }
}
