# Utilizing IronPrint License Keys

***Based on <https://ironsoftware.com/get-started/license-keys/>***


## Acquiring a License Key

Activating an IronPrint license key is essential for deploying your application in a live environment without the limitations of watermarks or other restrictions.

You can [purchase a license key here](https://ironsoftware.com/csharp/print/licensing/) or opt for a [free 30-day trial key](https://ironsoftware.com/trial-license).

--------------------------------------------------------------------------------

## Step 1: Download the Most Recent Version of IronPrint

## Step 2: Implement Your License Key

### Implementing the license through code

Include this code segment at the beginning of your application, prior to utilizing IronPrint. Remember to substitute `YOUR_LICENSE_KEY` with the actual license key you have obtained.

```csharp
using IronPrint;

class Program
{
    static void Main()
    {
        // Initialize the IronPrint license at the application startup
        IronPrint.LicenseKey = "YOUR_LICENSE_KEY";
        
        // Check if the license has been successfully initialized
        if (IronPrint.License.IsLicensed)
        {
            Console.WriteLine("License successfully applied.");
        }
        else
        {
            Console.WriteLine("License application failed.");
        }

        // Proceed with using IronPrint functionalities
        // Insert your application logic here
    }
}
```

--------------------------------------------------------------------------------

### Implementing the license using Web.Config or App.Config

For a global application-wide key using Web.Config or App.Config files, insert the key as shown below into your config file under appSettings.

```xml
<configuration>
  ...
  <appSettings>
    <add key="IronPrint.LicenseKey" value="IRONPRINT.YOURLICENSE.KEY.1EF01"/>
  </appSettings>
  ...
</configuration>
```

There are reported issues with license recognition in IronPrint versions before [2024.3.6](https://www.nuget.org/packages/IronPrint/2024.3.6) particularly affecting:
- **ASP.NET** projects
- **.NET Framework version 4.6.2 and later**

Licenses in a `Web.config` file may not be correctly utilized by the application. For further details, refer to the ['Setting License Key in Web.config'](https://ironsoftware.com/csharp/print/troubleshooting/license-key-web.config/) support guide.

Always confirm that `IronPrint.License.IsLicensed` is `true` to ascertain that the license is properly recognized by your application.

--------------------------------------------------------------------------------

### Applying a license key in a .NET Core `appsettings.json` file

To globally apply a license in a .NET Core setting: 

- Create and place a `appsettings.json` in your project's root directory.
- Insert a `IronPrint.LicenseKey` within your JSON configuration file. The respective value should be your purchased or trial license key.
- Ensure the file's property 'Copy to Output Directory' is set to 'Copy always'.

File: _appsettings.json_

```json
{
    "IronPrint.LicenseKey": "IRONPRINT.YOURLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Verify Your License Key

### Checking the Applied License Key

To confirm the proper application of your license key, leverage the **IsLicensed** property. The following code snippet aids in this verification:

```csharp
using IronPrint;

class LicenseCheck
{
    static void Main()
    {
        // Confirm if the license has been initialized
        bool isLicensed = IronPrint.License.IsLicensed;
        Console.WriteLine(isLicensed ? "License implemented." : "License not implemented.");
    }
}
```

### Confirming the License Key's Validity

To validate your license or trial key, use the code below:

```csharp
using IronPrint;

class ValidateLicense
{
    static void Main()
    {
        // Check the validity of the license or trial key
        bool isValid = IronPrint.License.IsValid;
        Console.WriteLine(isValid ? "License key is valid." : "License key is not valid.");
    }
}
```

A result of **True** indicates the key is valid, allowing the continuous use of IronPrint. A **False** result suggests that the key may be incorrect or invalid.

--------------------------------------------------------------------------------

## Step 4: Getting Started with Your Project

To kickstart your experience with IronPrint, consider exploring our detailed tutorial available at [Getting Started with IronPrint](https://ironsoftware.com/csharp/print/docs/). This guide provides exhaustive instructions and practical examples for beginners.

--------------------------------------------------------------------------------

## Questions or Assistance Required?

For successful implementation of IronPrint in your live projects, it's crucial to acquire either a paid license or a trial key, accessible by [purchasing a license](https://ironsoftware.com/csharp/print/licensing/) or through [this link](https://ironsoftware.com/trial-license).

For an abundant range of code samples, complete tutorials, licensing details, and thorough documentation, make sure to check out the [IronPrint section](https://ironsoftware.com/csharp/print/) on our website.

Should you have any inquiries, please don't hesitate to contact <support@ironsoftware.com>.