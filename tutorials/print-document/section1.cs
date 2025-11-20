using IronPrint;
namespace IronPrint.Examples.Tutorial.PrintDocument
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Print Your Document in One Line – Try IronPrint Now
            IronPrint.Printer.Print("path/to/your/document.pdf");
        }
    }
}