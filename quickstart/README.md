# Introduction to IronPrint

***Based on <https://ironsoftware.com/docs/docs/>***


## IronPrint: Comprehensive Printing Solution for .NET Developers

**IronPrint** is a robust printing library created by Iron Software, tailored for use across various platforms including Windows, macOS, Android, and iOS.

### Compatibility Overview

**IronPrint** offers extensive compatibility across different platforms and .NET versions:

#### Supported .NET Versions

- **C#**, **VB.NET**, **F#**
- Versions **.NET 8, 7**, 6, 5, and Core 3.1+
- .NET Framework (version 4.6.2 and newer)

#### Supported Operating Systems and Environments

- **Windows** (Version 7 and newer, Server 2016 and later)
- **macOS** (Version 10 and above)
- **iOS** (Version 11 and up)
- **Android** API 21+ (Version 5 "Lollipop" onwards)

#### Supported .NET Project Types

- **Mobile Applications** (using Xamarin, MAUI, and Avalonia)
- **Desktop Applications** (employing WPF, MAUI, and Windows Avalonia)
- **Console Applications** (both App and Library types)

## Installation Process

### Setting Up IronPrint Library

To install the IronPrint library quickly, execute the following command:

```shell
Install-Package IronPrint
```

Alternatively, you can download it directly from the [official IronPrint NuGet page](https://www.nuget.org/packages/IronPrint).

Before using the library capabilities, remember to add `using IronPrint;` to the top of your C# source file.

## License Key Activation

Activate your IronPrint library by inserting a valid license or trial key into your project. Assign the key to the `LicenseKey` property of the `License` class immediately following the import directives:

```csharp
IronPrint.License.LicenseKey = "IRONPRINT.MYLICENSE.KEY.1EF01";
```

## Programming Examples

### Document Printing

Easily print documents by providing the file path to the `Print` method.

```csharp
using IronPrint;

// Initiates document printing
Printer.Print("newDoc.pdf");
```

### Printing with a Dialog

Invoke the `ShowPrintDialog` method to display the print dialog during the print operation.

```csharp
using IronPrint;

// Displays the print dialog before printing
Printer.ShowPrintDialog("newDoc.pdf");
```

### Customizing Print Settings

Instantiate and configure a `PrintSettings` instance to modify print configurations. Afterwards, pass the object to the print method.

```csharp
using IronPrint;

// Configuring the print settings
PrintSettings printSettings = new PrintSettings();
printSettings.Dpi = 150;
printSettings.NumberOfCopies = 2;
printSettings.PaperOrientation = PaperOrientation.Portrait;

// Document printing with customized settings
Printer.Print("newDoc.pdf", printSettings);
```

## Licenses and Support Options

**IronPrint** is a commercially licensed product, albeit it offers free trial licenses available [here](https://ironsoftware.com/trial-license).

Visit the Iron Software official site for more details: <https://ironsoftware.com/>. For further assistance and queries, please [contact our support](https://ironsoftware.com/#live-chat-support).

### Providing Support

For all types of support and technical queries, reach out to us via email at: <support@ironsoftware.com>