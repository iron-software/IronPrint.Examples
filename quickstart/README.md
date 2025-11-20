# Introduction to IronPrint

***Based on <https://ironsoftware.com/docs/docs/>***


## IronPrint: Comprehensive Printing Solution for .NET Applications

**IronPrint** serves as a robust printing library by Iron Software, supporting numerous platforms such as Windows, macOS, Android, and iOS.

### Compatibility Overview

**IronPrint** offers broad compatibility across various platforms:

#### Supported .NET Versions

- **C#**, **VB.NET**, **F#**
- **.NET 8, 7**, 6, 5, and Core 3.1+
- .NET Framework (4.6.2+)

#### Supported Operating Systems and Environments

- **Windows** (7+, Server 2016+)
- **macOS** (10+)
- **iOS** (11+)
- **Android** API 21+ (v5 "Lollipop")

#### Supported .NET Project Types

- **Mobile** (Xamarin & MAUI & Avalonia)
- **Desktop** (WPF & MAUI & Windows Avalonia)
- **Console** (App & Library)

## Installation Process

### Getting Started with the IronPrint Library

To install the IronPrint package, use the NuGet Package Manager:

```shell
:InstallCmd dotnet add package IronPrint
```

You can also download it directly from the [official IronPrint NuGet page](https://www.nuget.org/packages/IronPrint).

Begin by importing the library with `using IronPrint;` in your C# source file.

## Activating Your License

To activate IronPrint, insert your license or trial key into the `LicenseKey` property of the `License` class right after your imports, before invoking any printing methods:

```csharp
using IronPrint;

// Insert your IronPrint license key below
License.LicenseKey = "your-license-key-here";
```

## Practical Examples

### Basic Document Printing

To print a document, simply supply the path of the file to the `Print` method:

```csharp
using IronPrint;

class Program
{
    static void Main()
    {
        // Path to the document to print
        string filePath = "document.pdf";

        // Call the Print method to start printing
        IronPrint.Print(filePath);
    }
}
```

### Interactive Print Dialog

For printing with a user confirmation dialog, use the `ShowPrintDialog` method:

```csharp
using IronPrint;

class Program
{
    static void Main()
    {
        // Document path for printing
        string filePath = "document.pdf";

        // Display the print dialog before printing
        IronPrint.ShowPrintDialog(filePath);
    }
}
```

### Customizing Print Settings

Customize the printing process by configuring the `PrintSettings` class:

```csharp
using IronPrint;

class Program
{
    static void Main()
    {
        // Setup printing preferences
        PrintSettings settings = new PrintSettings
        {
            Copies = 2,
            Duplex = DuplexMode.Vertical,
            PageOrientation = PageOrientation.Landscape
        };

        // Document path for printing
        string filePath = "document.pdf";

        // Print the document with customized settings
        IronPrint.Print(filePath, settings);
    }
}
```

## Licensing & Support Options

**IronPrint** is a premium library, but free trial licenses are available [here](https://ironsoftware.com/trial-license).

Discover more about Iron Software on our [website](https://ironsoftware.com/) or for assistance, please [reach out to our team](https://ironsoftware.com/contact-us/).

### Support Services by Iron Software

For general inquiries and technical assistance, please contact: <support@ironsoftware.com>.