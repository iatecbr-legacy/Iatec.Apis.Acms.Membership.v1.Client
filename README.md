# Iatec.Apis.Acms.Membership.v1.Client - the C# library for the Acms Api

The documentation for the ACMS Api

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Iatec.Apis.Acms.Membership.v1.Client.Api;
using Iatec.Apis.Acms.Membership.v1.Client.Client;
using Iatec.Apis.Acms.Membership.v1.Client.Model;
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Iatec.Apis.Acms.Membership.v1.Client.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Iatec.Apis.Acms.Membership.v1.Client.Api;
using Iatec.Apis.Acms.Membership.v1.Client.Client;
using Iatec.Apis.Acms.Membership.v1.Client.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var apiInstance = new ChurchsApi();
            var id = id_example;  // Guid? | The specific ID of a church (optional) 
            var abbreviation = abbreviation_example;  // string | Search by this abbreviation (optional) 
            var lastUpdateDate = lastUpdateDate_example;  // string | Filter by the date of the last update (optional) 

            try
            {
                // Get many churchs
                List<ChurchModel> result = apiInstance.GetMany(id, abbreviation, lastUpdateDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChurchsApi.GetMany: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://sad-us-fm-1.acms.live.ws.acmsnet.org/public/api/Membership/V1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ChurchsApi* | [**GetMany**](docs/ChurchsApi.md#getmany) | **GET** /arms | Get many churchs


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressModel](docs/AddressModel.md)
 - [Model.ChurchModel](docs/ChurchModel.md)
 - [Model.CityModel](docs/CityModel.md)
 - [Model.CountryModel](docs/CountryModel.md)
 - [Model.CultureModel](docs/CultureModel.md)
 - [Model.FeatureModel](docs/FeatureModel.md)
 - [Model.ParentEntityModel](docs/ParentEntityModel.md)
 - [Model.PastorModel](docs/PastorModel.md)
 - [Model.PictureModel](docs/PictureModel.md)
 - [Model.ServiceTimeModel](docs/ServiceTimeModel.md)
 - [Model.StateModel](docs/StateModel.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: app-key
- **Location**: HTTP header

