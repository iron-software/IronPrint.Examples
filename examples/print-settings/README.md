***Based on <https://ironsoftware.com/examples/print-settings/>***

Create an instance of the `PrintSettings` class and tailor it to meet your printing needs. Then, use this **PrintSettings** instance in one of the available printing methods. Here's a guide to some key printing options you can configure:

- **DefaultSettings**: Creates a new `IronPrint.PrintSettings` object with the standard settings.
- **PaperSize**: Determines the size of the paper for the print job.
- **PaperOrientation**: Designates whether the print orientation should be Portrait or Landscape.
- **Dpi**: Denotes the printing resolution in dots per inch. Note: The actual DPI achievable might be restricted by your printer's capabilities.
- **NumberOfCopies**: Specifies how many copies of the document are to be printed. Note: Due to system-specific limitations, the number of reproduced copies might default to one regardless of the number specified in `IronPrint.PrintSettings.NumberOfCopies`.
- **PrinterName**: Identifies the printer that will be used. Note: If the printer is selected through a `PrintDialog`, this setting will be overridden. You can retrieve a list of printers using `IronPrint.Printer.GetPrinterNames` or `IronPrint.Printer.GetPrinterNamesAsync`.
- **PaperMargins**: Sets printing margins in millimeters.
- **Grayscale**: Chooses whether the printing should be in grayscale.
- **Flatten**: This setting flattens the PDF for printing, which is particularly helpful for incorporating the values of form fields and images. By default, this is set to `false`, indicating that the PDF should be flattened prior to printing.
- **Tray**: Specifies the printer tray to use. This setting is ignored if a tray is selected via a `PrintDialog`. Use `IronPrint.Printer.GetPrinterTrays(System.String)` or `IronPrint.Printer.GetPrinterTraysAsync(System.String)` to see available trays. The default is `null`, which utilizes the printer's default tray. Note that this feature is only supported on Windows.