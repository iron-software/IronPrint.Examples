using IronPrint;
namespace ironprint.LicenseKeys
{
    public class Section3
    {
        public void Run()
        {
            // Check if a given license key string is valid
            bool valid = IronPrint.License.IsValidLicense("IRONPRINT.MYLICENSE.KEY.1EF01");
        }
    }
}