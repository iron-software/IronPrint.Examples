using IronPrint;
namespace IronPrint.Examples.HowTo.PrintSettings
{
    public static class Section1
    {
        public static void Run()
        {
            // Configure print setting
            PrintSettings printSettings = new PrintSettings();
            printSettings.Dpi = 150;
            printSettings.NumberOfCopies = 2;
            printSettings.PaperOrientation = PaperOrientation.Portrait;
            
            // Print the document
            Printer.Print("newDoc.pdf", printSettings);
        }
    }
}