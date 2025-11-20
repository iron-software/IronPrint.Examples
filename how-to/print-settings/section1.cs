using IronPrint;
namespace IronPrint.Examples.HowTo.PrintSettings
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Print Instantly with Custom Settings
            IronPrint.Printer.Print("document.pdf", new IronPrint.PrintSettings { PaperSize = IronPrint.PaperSize.A4, PaperOrientation = IronPrint.PaperOrientation.Landscape, Dpi = 300, NumberOfCopies = 2, Grayscale = true });
        }
    }
}