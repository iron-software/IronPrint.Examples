# Configuring Print Settings

***Based on <https://ironsoftware.com/how-to/print-settings/>***


Print settings constitute a configuration or a group of parameters that guide the way documents or content are printed. These settings encompass a variety of aspects such as paper size, orientation (e.g., portrait or landscape), print resolution (dots per inch - DPI), number of copies, printer choice, and margins, plus options for grayscale printing. Users can adjust these settings to suit specific printing needs.

### Getting Started with IronPrint

---

## Configuring Print Settings

To set up print settings, create an instance of the `PrintSettings` class and tailor it as desired. When using the `Print` or `ShowPrintDialog` methods, supply the `PrintSettings` object as the second argument. The below code snippet showcases how this can be done.

```cs
using IronPrint;

// Setup of the print settings
PrintSettings settings = new PrintSettings();
settings.Dpi = 150;
settings.NumberOfCopies = 2;
settings.PaperOrientation = PaperOrientation.Portrait;

// Document printing process
Printer.Print("newDoc.pdf", settings);
```

## Summary of Print Settings

Below is a rundown of all the print settings that you can customized:

- **DefaultSettings**: This option provides a new instance of the `IronPrint.PrintSettings` class with preset defaults.
- **PaperSize**: This setting modifies the paper size used by the printer. By default, it's set to `IronPrint.PaperSize.PrinterDefault`.
- **PaperOrientation**: This parameter dictates whether the paper orientation should be Portrait or Landscape, with the default set to Portrait.
- **Dpi**: This represents the desired print resolution, measured in dots per inch. Its default is set at 300 DPI, which is standard for professional printing. Note that the achievable DPI may be constrained by the printer's capabilities.
- **NumberOfCopies**: This specifies how many identical copies should be printed. The standard setting is one copy. On certain platforms, restrictions may apply that affect this setting, potentially leading to just one copy being printed regardless of the specified number.
- **PrinterName**: This identifies the printer that should be used for the task. With `null` as the default, the system's default printer is selected. If a printer is chosen via a PrintDialog, this setting is overridden. To fetch a list of printer names, use `IronPrint.Printer.GetPrinterNames` or `IronPrint.Printer.GetPrinterNamesAsync`.
- **PaperMargins**: This sets the printing margins in millimeters, with `null` indicating default margins provided by the printer.
- **Grayscale**: This option determines if printing should be done in grayscale, where the default is `false`, meaning printing will try to be done in color.
- **Flatten**: If set to `true`, flatens the PDF before printing which helps in displaying form fields and images clearly but defaults to `false`.
- **Tray**: This specifies the printer tray for the paper feed. The default is `null`, indicating the default tray. This property is available only on Windows. If you set a tray via PrintDialog, it will be ignored. Tray options can be checked using `IronPrint.Printer.GetPrinterTrays(System.String)` or `IronPrint.Printer.GetPrinterTraysAsync(System.String)`.