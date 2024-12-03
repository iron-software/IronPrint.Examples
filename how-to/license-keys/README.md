# Utilizing IronPrint License Keys

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## Obtaining a License Key

To ensure that your project runs live without any restrictions or watermarks, securing an IronPrint license key is essential.

You can [purchase a license here](https://ironsoftware.com/csharp/print/licensing/) or obtain a <a class='js-modal-open' data-modal-id='trial-license'>free 30-day trial key here</a>.


--------------------------------------------------------------------------------

## Step 1: Acquire the Latest IronPrint Release



## Step 2: Implement Your License Key

### Implement your license in code

To enable the license, insert the following snippet at the start-up of your application, prior to utilizing IronPrint.

```csharp
using IronPrint;
namespace ironprint.LicenseKeys
{
    public class Bootstrapper
    {
        public void Initialize()
        {
            IronPrint.License.LicenseKey = "IRONPRINT.MYLICENSE.KEY.1EF01";
        }
    }
}
```

--------------------------------------------------------------------------------

### Implement your license using Web.Config or App.Config

For applying the license key across your entire application via Web.Config or App.Config, insert this line in your `appSettings`.

```xml
<configuration>
...
  <appSettings>
    <add key="IronPrint.LicenseKey" value="IRONPRINT.MYLICENSE.KEY.1EF01"/>
  </appSettings>
...
</configuration>
```

Note that IronPrint versions prior to [2024.3.6](https://www.nuget.org/packages/IronPrint/2024.3.6) may encounter an issue in:
- **ASP.NET** projects
- **.NET Framework versions >= 4.6.2**

Where the `Web.config` file’s license key may not be recognized. For more details, refer to the '[Setting License Key in Web.config](https://ironsoftware.com/csharp/print/troubleshooting/license-key-web.config/)' guide.

Ensure that `IronPrint.License.IsLicensed` yields `true` to confirm licensing status.

--------------------------------------------------------------------------------

### Implement your license key in a .NET Core appsettings.json file

To distribute the license key system-wide in a .NET Core application:

- Create a JSON file named appsettings.json at the root of your project
- Include an 'IronPrint.LicenseKey' entry in your JSON config with your license key as its value.
- Set the file properties to _Copy to Output Directory: Copy always_

File: _appsettings.json_

```json
{
    "IronPrint.LicenseKey":"IRONPRINT.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirm Your License Key

### Verify the Activated License Key

Check the implementation of the license key by querying the **IsLicensed** attribute. Utilize this code example:

```csharp
using IronPrint;
namespace ironprint.LicenseKeys
{
    public class Validator
    {
        public void Check()
        {
            // Verify the license key implementation
            bool licensed = IronPrint.License.IsLicensed;
        }
    }
}
```

### Ensure the License Key’s Validity

To ascertain the authenticity of your license or trial key, use this code snippet:

```csharp
using IronPrint;
namespace ironprint.LicenseKeys
{
    public class LicenseChecker
    {
        public void Validate()
        {
            // Evaluate the validity of the license key string
            bool valid = IronPrint.License.IsValidLicense("IRONPRINT.MYLICENSE.KEY.1EF01");
        }
    }
}
```

A return value of **True** implies the key is valid, enabling you to continue using IronPrint confidently. A value of **False**, on the other hand, indicates an invalid key.

--------------------------------------------------------------------------------

## Step 4: Initiating Your Project

To smoothly start with IronPrint, consider following our detailed tutorial on [Get Started with IronPrint](https://ironsoftware.com/csharp/print/docs/). This guide offers extensive instructions and examples for mastering the basics of IronPrint.

--------------------------------------------------------------------------------

## Questions or Requiring Support?

For implementing IronPrint in live projects, acquiring a valid paid or trial license key is mandatory, available via [purchasing a license](https://ironsoftware.com/csharp/print/licensing/). For trial licenses, click [this link](https://ironsoftware.com/trial-license).

Explore further with an array of code examples, detailed tutorials, comprehensive licensing information, and extensive documentation at the [IronPrint section](https://ironsoftware.com/csharp/print/) of our site.

For inquiries, do not hesitate to contact <support@ironsoftware.com>.