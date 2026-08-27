using IronPrint;
namespace IronPrint.Examples.HowTo.AspnetWebApplicationFramework
{
    public static class Section1
    {
        public static void Run()
        {
            return await IronPrint.Printer.PrintAsync("Basic.pdf");
        }
    }
}