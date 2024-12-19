using IronPrint;
namespace IronPrint.Examples.HowTo.LicenseKeys
{
    public static class Section2
    {
        public static void Run()
        {
            // Check if the license key has been applied
            bool licensed = IronPrint.License.IsLicensed;
        }
    }
}