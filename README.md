# IronPrint.Examples

Runnable C# examples for [IronPrint](https://ironsoftware.com/csharp/print/?utm_source=github), a .NET printing library that sends PDFs, images, and documents to physical and virtual printers without shelling out to an external viewer.

## Install

```bash
dotnet add package IronPrint
```

## Quickstart

```csharp
using IronPrint;

License.LicenseKey = "YOUR-LICENSE-KEY";

// Print silently to the default printer
Printer.Print("invoice.pdf");
```

`Printer.ShowPrintDialog(path)` prints through the platform dialog instead, and `Printer.GetPrinterNames()` returns the printers the machine can see. To control the job, pass a `PrintSettings` — paper size, orientation, DPI, number of copies, grayscale, and the target printer name.

Without a license key, printed output includes a watermark.

## What's in this repo

Each folder contains a self-contained .NET project you can open and run:

- `examples/` — focused snippets demonstrating individual features
- `get-started/` — license-key setup
- `how-to/` — task-oriented guides, including printing from an ASP.NET web application
- `quickstart/` — an end-to-end project scaffold
- `tutorials/` — a longer walkthrough covering document printing end to end

## Common tasks covered

- Silent printing to the default or a named printer
- Printing through the platform print dialog
- Enumerating the printers available on the machine
- `PrintSettings`: paper size, orientation, DPI, number of copies, grayscale, margins
- Printing PDFs and images
- Printing from an ASP.NET web application

## Platform support

.NET 7, .NET 6, .NET Core 3.1, and .NET Framework 4.6.2+, including the .NET MAUI target frameworks for Windows, macOS, Mac Catalyst, iOS, and Android. See the [documentation](https://ironsoftware.com/csharp/print/docs/?utm_source=github) for environment-specific notes.

## Documentation and support

- Full documentation: [ironsoftware.com/csharp/print/docs](https://ironsoftware.com/csharp/print/docs/?utm_source=github)
- API reference: [ironsoftware.com/csharp/print/object-reference/api](https://ironsoftware.com/csharp/print/object-reference/api/?utm_source=github)
- Issues with these examples: file directly on this repository
- Product support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

## About

This repository is maintained by [Iron Software](https://ironsoftware.com/?utm_source=github). IronPrint is a commercial library — see [licensing](https://ironsoftware.com/csharp/print/licensing/?utm_source=github) for terms and trial details.
