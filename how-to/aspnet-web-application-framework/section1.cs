using IronPrint;
namespace IronPrint.Examples.HowTo.AspnetWebApplicationFramework
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Print a PDF Asynchronously in Seconds
            return await IronPrint.Printer.PrintAsync("Basic.pdf");
        }
    }
}