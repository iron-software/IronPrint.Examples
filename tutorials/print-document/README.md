# Print Document Guide

***Based on <https://ironsoftware.com/tutorials/print-document/>***


IronPrint is a robust library engineered to enable .NET C# developers to easily embed printing functionality within their applications. It is compatible with a wide array of platforms, including Windows, macOS, iOS, and Android, ensuring consistent operation across different operating systems. IronPrint streamlines the addition of print capabilities to your apps, whether they're designed for desktop environments, the Apple macOS sphere, or mobile devices like iOS and Android. This makes IronPrint an all-encompassing, straightforward solution for your .NET C# printing requirements.

## Table of Contents

- **Print Document**
   - [Silent Printing](#anchor-print-silently)
   - [Interactive Printing with Dialog](#anchor-print-with-dialog)
- [**Customize Print Settings**](#anchor-apply-print-settings)
- **Retrieve Printer Details**
   - [Fetch Printer Names](#anchor-get-printer-names)

## Print Document

### Silent Printing

Execute document printing directly, omitting the print dialog, allowing settings to be applied programmatically.

```cs
using IronPrint;
namespace ironprint.PrintDocument
{
    public class Section1
    {
        public void Execute()
        {
            // Execute printing
            Printer.Print("newDoc.pdf");
        }
    }
}
```

### Interactive Printing with Dialog

Start the printing process while displaying the settings dialog, letting users modify print options interactively.

```cs
using IronPrint;
namespace ironprint.PrintDocument
{
    public class Section2
    {
        public void Execute()
        {
            // Display print dialog
            Printer.ShowPrintDialog("newDoc.pdf");
        }
    }
}
```

## Customize Print Settings

Adjust the print settings programmatically to fulfill specific requirements. This allows for precise control over the printing parameters.

```cs
using IronPrint;
namespace ironprint.PrintDocument
{
    public class Section3
    {
        public void Execute()
        {
            // Setup print configuration
            PrintSettings printSettings = new PrintSettings();
            printSettings.Dpi = 150;
            printSettings.NumberOfCopies = 2;
            printSettings.PaperOrientation = PaperOrientation.Portrait;
            
            // Execute document printing
            Printer.Print("newDoc.pdf", printSettings);
        }
    }
}
```

## Retrieve Printer Details

### Fetch Printer Names

Obtain a catalog of all operational printers. This function gathers the names of printers installed on the system for either informational purposes or to enable dynamic selection in your software.

```cs
using System.Collections.Generic;
using IronPrint;
namespace ironprint.PrintDocument
{
    public class Section4
    {
        public void Execute()
        {
            // Collect printer names
            List<string> printersName = Printer.GetPrinterNames();
            
            foreach (var printer in printersName)
            {
                Console.WriteLine(printer);
            }
        }
    }
}
```