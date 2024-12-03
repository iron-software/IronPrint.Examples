using System.Collections.Generic;
using IronPrint;
namespace ironprint.PrintDocument
{
    public class Section4
    {
        public void Run()
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