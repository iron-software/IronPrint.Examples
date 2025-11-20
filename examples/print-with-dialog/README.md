***Based on <https://ironsoftware.com/examples/print-with-dialog/>***

Activate the settings dialog for printing the document using the `ShowPrintDialog` method. This is particularly useful for displaying GUI print settings.

Consider the following C# example:

### Explanation

- **`PrintDocument` Creation:** Initiate a `PrintDocument` object which is essential for processing the document printing.
- **Event Handling:** Attach an event handler (`PrintDocument_PrintPage`) to control the printing process for each page.
- **`PrintDialog` Configuration:** Set up a `PrintDialog` associated with the `PrintDocument` that permits users to adjust their print settings.
- **Initiating Printing:** Display the print dialog through `ShowDialog()`. If the user approves the settings by selecting OK, the print job progresses to the printer with `printDocument.Print()`.
- **`PrintPage` Event:** In the `PrintDocument_PrintPage` event handler, specify the content to be printed on each page utilizing graphic methods like `DrawString` to append text to the page.

[Learn more about customizing print settings with IronPrint](https://ironsoftware.com/csharp/print/how-to/print-settings/).