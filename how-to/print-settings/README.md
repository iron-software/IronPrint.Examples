# Configuring Print Settings

***Based on <https://ironsoftware.com/how-to/print-settings/>***


Print settings comprise a group of parameters used to guide the printing of documents. These parameters may include the paper size, whether to print in portrait or landscape mode, the resolution (measured in DPI), the number of copies, printer preference, margins, and whether the printout should be in grayscale. Adjusting these settings allows users to tailor their print outputs to meet specific requirements.

## Quickstart: Utilize IronPrint Settings for Immediate Printing

Begin by constructing a `PrintSettings` object and setting basic properties such as paper size, orientation, DPI, number of copies, and grayscale option. Utilize the `Printer.Print(...)` method to instantly apply these configurations without any intricate preparations.

```cs
:title=Direct Printing with Configured Settings
IronPrint.Printer.Print("document.pdf", new IronPrint.PrintSettings {
    PaperSize = IronPrint.PaperSize.A4,
    PaperOrientation = IronPrint.PaperOrientation.Landscape,
    Dpi = 300,
    NumberOfCopies = 2,
    Grayscale = true
});
```

## Configure Print Settings

To adjust print settings, create an instance of the `PrintSettings` class and configure its attributes according to your preferences. In methods like `Print` or `ShowPrintDialog`, you would pass in your `PrintSettings` instance as an argument. Below is a sample code demonstrating these steps.

```csharp
// Import IronPrint namespace
using IronPrint;

// Create a new PrintSettings object
PrintSettings settings = new PrintSettings();

// Define various print properties
settings.PaperSize = PaperSize.A4;                // A4 paper size
settings.PaperOrientation = PaperOrientation.Landscape; // Landscape orientation
settings.Dpi = 300;                               // 300 DPI resolution
settings.NumberOfCopies = 2;                      // Two copies
settings.PrinterName = "MyPrinter";               // Specific printer name
settings.PaperMargins = new Margins(10, 10, 10, 10); // Uniform 10mm margins
settings.Grayscale = true;                        // Grayscale output

// Apply settings using the Print method
IronPrint.Printer.Print("document-path.pdf", settings);
```

## Comprehensive List of Print Settings

Review the comprehensive list of settings for print configuration:

- **DefaultSettings**: Launches a default instance of `IronPrint.PrintSettings`.
- **PaperSize**: Defines the paper size, with `PrinterDefault` being the initial setting.
- **PaperOrientation**: Sets the orientation, with `Portrait` as the default.
- **Dpi**: Determines the printing resolution, defaulting at 300 DPI. Note that printer capabilities might restrict actual DPI output.
- **NumberOfCopies**: Indicates the desired print copies, defaulting to one. Platform restrictions might affect this setting.
- **PrinterName**: Defines the printer name; if null, the system’s default printer is selected. Note that manually chosen printers in `PrintDialog` will ignore this setting. Use `IronPrint.Printer.GetPrinterNames` or` IronPrint.Printer.GetPrinterNamesAsync` to retrieve a list of printers.
- **PaperMargins**: Specifies print margins in millimeters. If null, printer defaults are used.
- **Grayscale**: Chooses between grayscale and color printing, with color being the default.
- **Flatten**: Flattens the PDF for print, showing all text fields and images, enabled by default.
- **Tray**: Assigns a specific printer tray for the job, ignored if selected in `PrintDialog`. Retrieve trays with `IronPrint.Printer.GetPrinterTrays` or `IronPrint.Printer.GetPrinterTraysAsync`. Default tray selection is null, usually set to the printer’s default unless specified.

This guide covers the basic and advanced options available in the IronPrint library, helping you effectively manage printing tasks.