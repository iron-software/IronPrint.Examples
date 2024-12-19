# Working with IronPrint License Keys

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## Obtaining a License Key

Leveraging an IronPrint license key empowers you to release your project into production without any limitations or branding watermarks.

You can [purchase a license here](https://ironsoftware.com/csharp/print/licensing/) or opt for a <a class='js-modal-open' data-modal-id='trial-license'>complimentary 30-day trial key here</a>.

--------------------------------------------------------------------------------

## Step 1: Acquire the Latest IronPrint Release



## Step 2: Integrate Your License Key

### Implement your license through code

Incorporate this snippet at the beginning of your application, prior to utilizing IronPrint.

```csharp
IronPrint.License.LicenseKey = "IRONPRINT.MYLICENSE.KEY.1EF01";
```

--------------------------------------------------------------------------------

### Deploy your license with Web.Config or App.Config

For a broad application of your license key via Web.Config or App.Config, insert the following entry in the appSettings section of your config file.

```xml
<configuration>
...
  <appSettings>
    <add key="IronPrint.LicenseKey" value="IRONPRINT.MYLICENSE.KEY.1EF01"/>
  </appSettings>
...
</configuration>
```

Please note, a licensing complication has been recognized with IronPrint versions prior to [2024.3.6](https://www.nuget.org/packages/IronPrint/2024.3.6) for:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

The license key defined in a `Web.config` is **NOT** being recognized by the module. Explore the '[Setting License Key in Web.config](https://ironsoftware.com/csharp/print/troubleshooting/license-key-web.config/)' article for more insights.

Confirm that `IronPrint.License.IsLicensed` evaluates to `true` to validate.

--------------------------------------------------------------------------------

### Configure your license key via a .NET Core appsettings.json file

To universally apply a license key in a .NET Core environment:

- Create a JSON file named appsettings.json in your project's root directory
- Include the 'IronPrint.LicenseKey' key within your JSON config file with the corresponding license key value.
- Ensure the properties for the file are set to _Copy to Output Directory: Copy always_

File: _appsettings.json_

```json
{
    "IronPrint.LicenseKey":"IRONPRINT.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirm Your License Key

### Assess the Installed License Key

To check if the license key is integrated successfully, review the **IsLicensed** property. Use this code:

```csharp
// Verify the license key integration
bool licensed = IronPrint.License.IsLicensed;
```

### Certify the License Key

To confirm your license or trial key's authenticity, utilize this code:

```csharp
// Validate the license key
bool valid = IronPrint.License.IsValidLicense("IRONPRINT.MYLICENSE.KEY.1EF01");
```

If `True`, the key is authentic, allowing you to proceed with IronPrint functionalities. Conversely, `False` signals an invalid key.

--------------------------------------------------------------------------------

## Step 4: Initiate Your Project

To initiate your journey with IronPrint, we recommend navigating through our detailed [Get Started with IronPrint](https://ironsoftware.com/csharp/print/docs/) guide. It provides thorough instructions and examples for mastering IronPrint basics.

--------------------------------------------------------------------------------

## Questions or Require Assistance?

To proceed with IronPrint in live projects, a valid paid or trial license key is necessary, obtainable through [purchasing a license](https://ironsoftware.com/csharp/print/licensing/). For the trial key, visit [this link](https://ironsoftware.com/csharp/print/trial-license).

Explore the IronPrint documentation, tutorials, example code, and license details at the [IronPrint resource hub](https://ironsoftware.com/csharp/print/).

For further inquiries, contact us at <support@ironsoftware.com>.