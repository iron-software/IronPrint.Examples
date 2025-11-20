# Print Document Tutorial

***Based on <https://ironsoftware.com/tutorials/print-document/>***


IronPrint offers a robust printing library that enables .NET C# developers to easily incorporate printing functionalities into their applications. The library supports multiple platforms including Windows, macOS, iOS, and Android, ensuring consistent and dependable performance across various devices. For developers working on desktop, macOS, or mobile environments using iOS and Android, IronPrint provides a straightforward and effective approach to integrate printing capabilities within the .NET C# framework.

*as-heading:2(Quickstart: Silently Print a Document with IronPrint)*

Initiate printing with just a single line of code—no dialogs, no interruptions. Utilize `IronPrint.Printer.Print(...)` to directly send PDFs or images to the printer with either default or tailored settings.

```cs
:title=Effortlessly Print Your Document – Explore IronPrint
IronPrint.Printer.Print("path/to/your/document.pdf");
```

----

## Table of Contents

- **Print Document**
   - [Print Silently](#anchor-print-silently)
   - [Print With Dialog](#anchor-print-with-dialog)
- [**Apply Print Settings**](#anchor-apply-print-settings)
- **Get Printer Information**
   - [Get Printer Names](#anchor-get-printer-names)

## Print Document

### Print Silently

Achieve document printing seamlessly without the need for a print dialog. Configure the print settings directly in your code.

```csharp
// Directly execute a document print job without interface interruptions.
// Customize your print job and settings as needed.

using System;
using IronPrint;

public class SilentPrint
{
    public static void Main()
    {
        // Instantiate a print document
        var document = new PrintDocument("sample-document.pdf");

        // Prepare a silent print job
        var printJob = new PrintJob(document);

        // Configure settings as required
        // For instance: specify printer, number of copies, etc.
        
        // Perform the print job
        printJob.PrintSilently();
    }
}
```

### Print With Dialog

Begin the print process with a settings dialog, allowing users to interactively modify print options.

```csharp
// Initiate a print job with a dialog for user interaction.

using System;
using IronPrint;

public class DialogPrint
{
    public static void Main()
    {
        // Initialize a print document
        var document = new PrintDocument("sample-document.pdf");

        // Set up a print job with a dialog
        var printJob = new PrintJob(document);

        // Carry out the print job while displaying print options
        printJob.PrintWithDialog();
    }
}
```

## Apply Print Settings

Programmatically tailor print settings to suit specific needs. This section offers guidance on how to refine print configurations via code.

```csharp
// Demonstrates how to set custom print settings programmatically.

using System;
using IronPrint;

public class PrintSettingsExample
{
    public static void Main()
    {
        // Establish a print document
        var document = new PrintDocument("sample-document.pdf");

        // Formulate a print job
        var printJob = new PrintJob(document);

        // Define custom print settings such as duplex, color mode, etc.
        var settings = new PrintSettings
        {
            ColorMode = ColorMode.Color,
            DuplexMode = DuplexMode.OneSided,
            Copies = 2
        };

        // Implement settings in print job
        printJob.ApplySettings(settings);

        // Execute the print
        printJob.PrintSilently();
    }
}
```

## Get Printer Information

### Get Printer Names

Retrieve a list of all accessible printers. Collecting printer names allows for informed choices or dynamic selection within your application.

```csharp
// Fetch and display the list of printer names available on your system.

using System;
using IronPrint;

public class PrinterInfo
{
    public static void Main()
    {
        // Obtain a list of printer names
        var printerNames = PrinterSettings.GetAvailablePrinters();

        // Output each printer name to the console
        Console.WriteLine("Available Printers:");
        foreach (var name in printerNames)
        {
            Console.WriteLine(name);
        }
    }
}
```