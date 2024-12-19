using IronPrint;
namespace IronPrint.Examples.Tutorial.PrintDocument
{
    public static class Section1
    {
        public static void Run()
        {
            // Print the document
            Printer.Print("newDoc.pdf");
        }
    }
}