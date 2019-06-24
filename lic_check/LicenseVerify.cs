

using System;
using System.IO;
using System.Management;
using Rhino.Licensing;
using lic_check.Properties;

namespace lic_check
{
    public class LicenseVerify
    {
        
        public static bool IsValid(out DateTime expiration, string licFile, string publicKey)
        {            
            expiration = DateTime.MinValue;

            var licVal = new LicenseValidator(publicKey, licFile);

            try
            {
                licVal.AssertValidLicense();
            }
            catch (Exception)
            {
                return false;
            }

            expiration = licVal.ExpirationDate;

            var cpuInfo = string.Empty;
            var mc = new ManagementClass("win32_processor");
            var moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }
            if(licVal.ExpirationDate <= DateTime.Now)
            {
                return false;
            }

            if(licVal.Name != cpuInfo)
            {
                return false;
            }

            
            return true;

        }
    }
}
