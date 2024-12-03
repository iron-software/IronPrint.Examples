using IronPrint;
namespace ironprint.PrintDocument
{
    public class Section1
    {
        public void Run()
        {
            // Print the document
            Printer.Print("newDoc.pdf");
        }
    }
}