using IronPrint;
namespace IronPrint.Examples.HowTo.LicenseKeys
{
    public static class Section3
    {
        public static void Run()
        {
            // Check if a given license key string is valid
            bool valid = IronPrint.License.IsValidLicense("IRONPRINT.MYLICENSE.KEY.1EF01");
        }
    }
}