using System.Collections.Generic;
using IronPrint;
namespace IronPrint.Examples.Tutorial.PrintDocument
{
    public static class Section4
    {
        public static void Run()
        {
            // Retrieve printers' name
            List<string> printersName = Printer.GetPrinterNames();
            
            foreach (var printer in printersName)
            {
                Console.WriteLine(printer);
            }
        }
    }
}