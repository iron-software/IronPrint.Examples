using System.Threading.Tasks;
using IronPrint;
namespace IronPrint.Examples.HowTo.AspnetWebApplicationFramework
{
    public static class Section1
    {
        public static async Task Run()
        {
            await IronPrint.Printer.PrintAsync("Basic.pdf");
        }
    }
}