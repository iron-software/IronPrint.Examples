# How to Execute Printing in ASP.NET Web Applications

***Based on <https://ironsoftware.com/how-to/aspnet-web-application-framework/>***


Printing in web applications often presents a challenge, particularly when needing a document as the output. Integrating a printing function can be tricky, especially since many web applications employ asynchronous operations and a synchronous printing process might disrupt functionality. Fortunately, there is a solution. With IronPrint, the `PrintAsync` method comes to the rescue, specifically designed for use in web applications. This guide will explore utilizing the `PrintAsync` method alongside ASP.NET Core to replicate a typical web app printing scenario.

### Begin with IronPrint

------

## Example: Asynchronous PDF Printing Within ASP.NET Web Applications

This section showcases how to utilize the `PrintAsync` method to print PDF files asynchronously within an ASP.NET Web Application (.NET Framework) environment. By implementing `PrintAsync`, the print task is executed asynchronously, ensuring the application remains operational without freezing the UI, unlike the conventional synchronous `Print` methods.

### How to Add a Print Button

On your homepage view file, "Index.cshtml", incorporate a button that, when clicked, triggers a specific action. This button will call an `ActionResult` method within your controller. Here’s the implementation:

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

![The Index Page](https://ironsoftware.com/static-assets/print/how-to/aspnet-web-application-framework/index-page.webp)

---

### Setting Up `PrintAsync` in Your Controller

Below is how to configure the `PrintAsync` method in your **HomeController**. This function enables asynchronous printing operations, contributing to improved application responsiveness:

```cs
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
            return View();
        }

        public ActionResult PrintPdf()
        {
            // Implement your printer logic here
            Printer.PrintAsync("Basic.pdf").Wait();

            return View();
        }
    }
}
```
This completes the walkthrough on implementing asynchronous print functionality within an ASP.NET web application using IronPrint’s `PrintAsync` method. This method ensures that your application can continue to operate smoothly without interruption during the printing process.