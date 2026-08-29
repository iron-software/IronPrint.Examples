using IronPrint;
namespace IronPrint.Examples.Tutorial.PrintDocument
{
    public static class Section1
    {
        public static void Run()
        {
            IronPrint.Printer.Print("path/to/your/document.pdf");
        }
    }
}