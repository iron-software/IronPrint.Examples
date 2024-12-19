***Based on <https://ironsoftware.com/examples/print-settings/>***

Begin by creating an instance of the `IronPrint.PrintSettings` class and set it up based on your needs. Once configured, use these settings by passing the `PrintSettings` object to a print function. Here's a breakdown of what each print setting controls:

- **DefaultSettings**: Creates a new `PrintSettings` instance from IronPrint, preset with default parameters.
- **PaperSize**: Adjusts the paper size for the print job.
- **PaperOrientation**: Defines whether the paper should be oriented as Portrait or Landscape.
- **Dpi**: Sets the desired printing resolution in dots per inch, noting that the actual resolution might be constrained by your chosen printer’s capabilities.
- **NumberOfCopies**: Specifies how many copies of the document to print. Note that on some platforms, there might be constraints that lead to a discrepancy between the intended and actual number of copies printed. Under such circumstances, `PrintSettings.NumberOfCopies` may default to printing just a single copy.
- **PrinterName**: Determines which printer will be used to print. If you set the printer using a `PrintDialog`, this preference will be overridden. You can fetch a list of available printers using `IronPrint.Printer.GetPrinterNames` or `IronPrint.Printer.GetPrinterNamesAsync`.
- **PaperMargins**: Designates the print margins in millimeters.
- **Grayscale**: Option to print in grayscale instead of full color.
- **Flatten**: This option flattens the PDF before printing, making form fields and images part of the document itself, rather than interactive elements. By default, this is set to false, which means the PDF will be flattened before printing.
- **Tray**: Sets which printer tray to use for the paper feed. If selected through a `PrintDialog`, this setting will not apply. The list of available trays can be found using `IronPrint.Printer.GetPrinterTrays(string)` or `IronPrint.Printer.GetPrinterTraysAsync(string)`. The default setting is null, which utilizes the standard tray offered by the printer. This setting is available only on Windows.

Visit [Iron Software](https://www.ironsoftware.com) to delve into additional details and functionalities for each setting.