using IronPrint;
using System;
using System.Collections.Generic;

// Retrieve printers' name
List<string> printersName = Printer.GetPrinterNames();

foreach (var printer in printersName)
{
    Console.WriteLine(printer);
}
