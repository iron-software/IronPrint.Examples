using IronPrint;
namespace IronPrint.Examples.Tutorial.PrintDocument
{
    public static class Section2
    {
        public static void Run()
        {
            // Show print dialog
            Printer.ShowPrintDialog("newDoc.pdf");
        }
    }
}