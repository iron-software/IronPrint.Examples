using IronPrint;
namespace ironprint.PrintDocument
{
    public class Section2
    {
        public void Run()
        {
            // Show print dialog
            Printer.ShowPrintDialog("newDoc.pdf");
        }
    }
}