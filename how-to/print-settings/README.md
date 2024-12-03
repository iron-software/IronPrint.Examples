# Configuring Print Settings

***Based on <https://ironsoftware.com/how-to/print-settings/>***


Print settings are a group of options that control the specifics of how content is printed. These parameters include aspects such as the size and orientation of the paper, printing resolution measured in DPI (dots per inch), the number of copies to be printed, which printer to use, margins, and whether to print in color or grayscale. These settings are adjustable, catering to diverse printing needs and preferences.

## Adjusting Print Settings

To tailor print settings, you need to create an instance of the `PrintSettings` class and set your desired parameters. When calling the `Print` or `ShowPrintDialog` methods, include the configured `PrintSettings` instance as an argument. The following code snippet demonstrates how to adjust and apply print settings:

```cs
using IronPrint;
namespace ironprint.PrintSettings
{
    public class Section1
    {
        public void Run()
        {
            // Initialization of print settings
            PrintSettings settings = new PrintSettings();
            settings.Dpi = 150;
            settings.NumberOfCopies = 2;
            settings.PaperOrientation = PaperOrientation.Portrait;
            
            // Executing the print command
            Printer.Print("newDoc.pdf", settings);
        }
    }
}
```

## Options for Print Settings

Here are the settings you can manage within your print configurations:

- **DefaultSettings**: Creates a new instance of the `PrintSettings` class, populated with default settings.
- **PaperSize**: Determines the size of paper the printer will use. This typically defaults to `IronPrint.PaperSize.PrinterDefault`.
- **PaperOrientation**: Defines whether the paper should be in Portrait or Landscape orientation. By default, it is set to `PaperOrientation.Portrait`.
- **Dpi**: Sets the printing resolution in DPI. The standard default is 300 DPI, which is typical for high-quality print jobs. However, the printer's capability may limit the actual DPI.
- **NumberOfCopies**: Specifies how many copies of the document should be printed. While the default is typically one copy, not all platforms can necessarily support multiple copies, and sometimes only one copy will be printed despite a higher number set.
- **PrinterName**: Indicates the printer to use. If left as null, the system's default printer is selected. To select a printer manually, options are retrievable via `IronPrint.Printer.GetPrinterNames` or its asynchronous counterpart.
- **PaperMargins**: Configures the printing margins in millimeters. If set to null, the printer defaults are applied.
- **Grayscale**: Decides whether printing will be in grayscale. Color printing is the default unless set to true.
- **Flatten**: Before printing, determines if the PDF should be flattened. This is helpful for ensuring that images and field values in forms are printed correctly. Off by default.
- **Tray**: Selects the specific printer tray to feed paper from. This setting is usually not applied if the tray is selected through `PrintDialog`. Trays can be checked using `IronPrint.Printer.GetPrinterTrays` or its asynchronous method. By default, the system tray setting is used, and this feature is only available on Windows systems.