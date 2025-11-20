# How to Implement Printing in an ASP.NET Web Application

***Based on <https://ironsoftware.com/how-to/aspnet-web-application-framework/>***


Implementing print functionality in web applications often presents practical challenges. While web technologies typically operate asynchronously, print operations are inherently synchronous and can disrupt the seamless user experience. Thankfully, IronPrint offers a powerful solution with its `PrintAsync` method, designed for use in web environments. This tutorial will explore how to employ this functionality within an ASP.NET Core application to enable document printing without blocking the main application flow.

## Quickstart: Async PDF Printing with IronPrint in ASP.NET

Jump straight into asynchronous PDF printing with IronPrint's `PrintAsync` API. This concise example below illustrates how you can initiate printing with just a single line in your controller, thus eliminating any interruption to your application's performance.

```cs
:title=Print a PDF Asynchronously in Moments
await IronPrint.Printer.PrintAsync("Basic.pdf");
```

## Guide to Asynchronous PDF Printing in ASP.NET

The following sections demonstrate the setup required to print PDF files asynchronously within an **ASP.NET Web Application (.NET Framework)**. By implementing the `PrintAsync` method, we avoid freezing the UI, an issue common with traditional synchronous print operations.

### Setting Up a Print Button

Begin by adding a print button to your "Index.cshtml" or main page, which activates the print mechanism when pressed. Below is the implementation detail:

```html
@{
    ViewBag.Title = "Home Page";
}

<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">ASP.NET</h1>
        <p>
            
            <a class="btn btn-primary btn-md" onclick="location.href='@Url.Action("PrintPdf", "Home")'">Print PDF</a>
        </p>
    </section>
</main>
```

![Index page](https://ironsoftware.com/static-assets/print/how-to/aspnet-web-application-framework/index-page.webp)

<hr>

### Configuring PrintAsync in the Controller

Implement the `PrintAsync` method within your `HomeController`. This method ensures that the printing process is conducted asynchronously, improving the application's overall responsiveness.

```csharp
using IronPrint;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        // Action method to manage the print process without blocking the main thread
        public async Task<ActionResult> PrintPdf()
        {
            // Execute the asynchronous print operation
            await IronPrint.Printer.PrintAsync("Basic.pdf").ConfigureAwait(false);

            // Provide a response view, such as a confirmation or a return to the main page
            return View(); // Update with the desired return view
        }
    }
}
```

By utilizing the `PrintAsync` feature of IronPrint, developers can integrate robust print functionalities into their ASP.NET applications without degrading the user's experience, demonstrating a seamless integration of backend operations with frontend responsiveness.