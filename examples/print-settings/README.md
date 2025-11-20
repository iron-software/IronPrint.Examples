***Based on <https://ironsoftware.com/examples/print-settings/>***

Begin by creating an instance of the `PrintSettings` class and modify it as necessary to meet your print requirements. Once configured, use the **PrintSettings** object with any of the available print methods. Detailed descriptions of the different settings available can be found below:

- **`DefaultSettings`**: Creates a new `IronPrint.PrintSettings` instance containing the default values.
- **`PaperSize`**: Defines the paper size that the printer will use.
- **`PaperOrientation`**: Determines the orientation of the paper, such as Portrait or Landscape.
- **`Dpi`**: Indicates the desired printing resolution in dots per inch.
  - **Remarks**: The printer’s capability may limit the actual DPI used during printing.
- **`NumberOfCopies`**: Specifies how many identical copies are to be printed.
  - **Remarks**: Due to platform-specific restrictions, setting multiple copies may not always result in the expected numbers of printed copies; in these scenarios, it might default to printing a single copy.
- **`PrinterName`**: Designates the target printer for the job.
  - **Remarks**: This setting will be overridden if a printer is selected through a PrintDialog. To discover the names of available printers, use `IronPrint.Printer.GetPrinterNames` or `IronPrint.Printer.GetPrinterNamesAsync`.
- **`PaperMargins`**: Adjusts the margins around the printed content in millimeters.
- **`Grayscale`**: Specifies whether the printing should be done in grayscale.
- **`Flatten`**: Flattens the PDF before printing, making it better for presenting form field inputs and images.
  - **Note**: By default, this is set to false, meaning the PDF will be flattened before printing.
- **`Tray`**: Selects the printer tray for use in the print job.
  - **Remarks**: This setting will be bypassed if a tray is chosen through a PrintDialog. To identify available trays, one can utilize `IronPrint.Printer.GetPrinterTrays(System.String)` or `IronPrint.Printer.GetPrinterTraysAsync(System.String)`. By default, it is set to null, which utilizes the standard tray the printer offers. This tray customization feature is only available in Windows systems.

[Explore Detailed Print Settings Guide with IronPrint](https://ironsoftware.com/csharp/print/how-to/print-settings/)