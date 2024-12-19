# Print Document Tutorial

***Based on <https://ironsoftware.com/tutorials/print-document/>***


IronPrint is an advanced printing library tailored for .NET C# developers looking to embed printing functionality within their applications. Compatible with Windows, macOS, iOS, and Android, IronPrint delivers consistent performance across various operating systems. Ideal for developing applications for desktops, macOS, iOS, or Android, IronPrint streamlines the integration of printing capabilities into your .NET C# projects, offering a robust and intuitive solution to fulfill all your printing requirements.

<h3>Getting Started with IronPrint</h3>

-------------------------

## Table of Contents

- **Print Document**
   - [Silent Printing](#anchor-print-silently)
   - [Interactive Printing](#anchor-print-with-dialog)
- [**Adjusting Print Settings**](#anchor-apply-print-settings)
- **Printer Details**
   - [List of Printer Names](#anchor-get-printer-names)

## Print Document

### Silent Printing

Effortlessly print documents without the print dialog appearing, allowing settings to be applied directly in the code.

```cs
using IronPrint;

// Execute the printing process
Printer.Print("newDoc.pdf");
```

### Interactive Printing

Begin the printing process with a settings dialog, enabling users to modify printing options directly.

```cs
using IronPrint;

// Activate the print dialog
Printer.ShowPrintDialog("newDoc.pdf");
```

## Adjusting Print Settings

Manually tailor print settings to suit specific needs. This functionality supports detailed customization of printing properties via programming.

```cs
using IronPrint;

// Set up printing parameters
PrintSettings printSettings = new PrintSettings();
printSettings.Dpi = 150;
printSettings.NumberOfCopies = 2;
printSettings.PaperOrientation = PaperOrientation.Portrait;

// Execute printing with specified settings
Printer.Print("newDoc.pdf", printSettings);
```

## Printer Details

### List of Printer Names

Identify and list all printers available. Gather the names of installed printers for selection or informational purposes in your software.

```cs
using IronPrint;
using System;
using System.Collections.Generic;

// Fetch names of all printers
List<string> printersName = Printer.GetPrinterNames();

foreach (var printer in printersName)
{
    Console.WriteLine(printer);
}
```