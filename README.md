![Nuget](https://img.shields.io/nuget/v/IronPrint?color=informational&label=latest)![Installs](https://img.shields.io/nuget/dt/IronPrint?color=informational&label=installs&logo=nuget)![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%20522%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)![iOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=ios)![android](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=android&logoColor=white)[![livechat](https://img.shields.io/badge/Live%20Chat:-24/5-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/print/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

## IronPrint - Your Premier C# Library for Printing Documents

[![IronPrint NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPrint-readme/nuget-trial-banner.png)](https://ironsoftware.com/csharp/print/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

[Get Started](https://ironsoftware.com/csharp/print/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Tutorials](https://ironsoftware.com/csharp/print/tutorials/print-document/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Code Examples](https://ironsoftware.com/csharp/print/examples/print/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Licensing](https://ironsoftware.com/csharp/print/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Free Trial](https://ironsoftware.com/csharp/print/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation#trial-license)

IronPrint is expertly crafted by Iron Software to aid C# developers in managing print tasks for PDF files and images within .NET environments.

#### Key Advantages of IronPrint:

  * Supports printing with or without user interaction through print dialogs
  * Intuitive print configuration settings

#### IronPrint ensures compatibility across multiple platforms:

  * Supports .NET Framework 4.6.2 onwards, .NET 3.1 and later versions including .NET 5, 6, 7, and 8
  * Compatible with Windows, macOS, maccatalyst, iOS, and Android

[![IronPrint Cross Platform Compatibility Support Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPrint-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/print/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

For further details, our [API reference](https://ironsoftware.com/csharp/print/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs) and [comprehensive licensing information](https://ironsoftware.com/csharp/print/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#trial-license) are readily accessible on our website.

### How to Utilize IronPrint

To integrate IronPrint into your project, simply install the NuGet package using the command:

```bash
    PM> Install-Package IronPrint
```

After installation, include `using IronPrint;` at the beginning of your C# files. Here is an example to help you get started:

```csharp
    using IronPrint;
    
    // Initiates a print job for a PDF document
    await IronPrint.Printer.PrintAsync("myDocument.pdf");
    // Alternatively, display the print dialog
    await IronPrint.Printer.ShowPrintDialogAsync("myDocument.pdf");
    
    // Retrieves a list of available printers
    var printerList = await IronPrint.Printer.GetPrinterNamesAsync();
```

### Features Overview

[![IronPrint Features](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPrint-readme/features-table.png)](https://ironsoftware.com/csharp/print/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featuresbanner)

### Licensing & Support Details

Explore more about the product via [IronPrint's home page](https://ironsoftware.com/csharp/print/).

For assistance, contact us directly at support@ironsoftware.com.

### Useful Documentation Links

  * API Guide : [https://ironsoftware.com/csharp/print/object-reference/api/](https://ironsoftware.com/csharp/print/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Licensing Info : [https://ironsoftware.com/csharp/print/licensing/](https://ironsoftware.com/csharp/print/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)

Reach out to us at support@ironsoftware.com for direct support from our development team for your commercial projects. We provide extensive backing and licensing options for deployment.