# Okta.Sdk.Api.SchemaApi

All URIs are relative to *https://subdomain.okta.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApplicationLayout**](SchemaApi.md#getapplicationlayout) | **GET** /api/v1/meta/layouts/apps/{appName} | Retrieve the UI Layout for an Application
[**GetApplicationUserSchema**](SchemaApi.md#getapplicationuserschema) | **GET** /api/v1/meta/schemas/apps/{appInstanceId}/default | Retrieve the default Application User Schema for an Application
[**GetGroupSchema**](SchemaApi.md#getgroupschema) | **GET** /api/v1/meta/schemas/group/default | Retrieve the default Group Schema
[**GetLogStreamSchema**](SchemaApi.md#getlogstreamschema) | **GET** /api/v1/meta/schemas/logStream/{logStreamType} | Retrieve the Log Stream Schema for the schema type
[**GetUserSchema**](SchemaApi.md#getuserschema) | **GET** /api/v1/meta/schemas/user/{schemaId} | Retrieve a User Schema
[**ListLogStreamSchemas**](SchemaApi.md#listlogstreamschemas) | **GET** /api/v1/meta/schemas/logStream | List the Log Stream Schemas
[**UpdateApplicationUserProfile**](SchemaApi.md#updateapplicationuserprofile) | **POST** /api/v1/meta/schemas/apps/{appInstanceId}/default | Update the default Application User Schema for an Application
[**UpdateGroupSchema**](SchemaApi.md#updategroupschema) | **POST** /api/v1/meta/schemas/group/default | Update the default Group Schema
[**UpdateUserProfile**](SchemaApi.md#updateuserprofile) | **POST** /api/v1/meta/schemas/user/{schemaId} | Update a User Schema


<a name="getapplicationlayout"></a>
# **GetApplicationLayout**
> ApplicationLayout GetApplicationLayout (string appName)

Retrieve the UI Layout for an Application

Takes an Application name as an input parameter and retrieves the App Instance page Layout for that Application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetApplicationLayoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);
            var appName = "appName_example";  // string | 

            try
            {
                // Retrieve the UI Layout for an Application
                ApplicationLayout result = apiInstance.GetApplicationLayout(appName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetApplicationLayout: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appName** | **string**|  | 

### Return type

[**ApplicationLayout**](ApplicationLayout.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationuserschema"></a>
# **GetApplicationUserSchema**
> UserSchema GetApplicationUserSchema (string appInstanceId)

Retrieve the default Application User Schema for an Application

Fetches the Schema for an App User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetApplicationUserSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);
            var appInstanceId = "appInstanceId_example";  // string | 

            try
            {
                // Retrieve the default Application User Schema for an Application
                UserSchema result = apiInstance.GetApplicationUserSchema(appInstanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetApplicationUserSchema: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appInstanceId** | **string**|  | 

### Return type

[**UserSchema**](UserSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupschema"></a>
# **GetGroupSchema**
> GroupSchema GetGroupSchema ()

Retrieve the default Group Schema

Fetches the group schema

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetGroupSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);

            try
            {
                // Retrieve the default Group Schema
                GroupSchema result = apiInstance.GetGroupSchema();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetGroupSchema: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GroupSchema**](GroupSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlogstreamschema"></a>
# **GetLogStreamSchema**
> LogStreamSchema GetLogStreamSchema (LogStreamType logStreamType)

Retrieve the Log Stream Schema for the schema type

Retrieves the schema for a Log Stream type. The `logStreamType` element in the URL specifies the Log Stream type, which is either `aws_eventbridge` or `splunk_cloud_logstreaming`. Use the `aws_eventbridge` literal to retrieve the AWS EventBridge type schema, and use the `splunk_cloud_logstreaming` literal retrieve the Splunk Cloud type schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetLogStreamSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);
            var logStreamType = (LogStreamType) "aws_eventbridge";  // LogStreamType | 

            try
            {
                // Retrieve the Log Stream Schema for the schema type
                LogStreamSchema result = apiInstance.GetLogStreamSchema(logStreamType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetLogStreamSchema: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logStreamType** | **LogStreamType**|  | 

### Return type

[**LogStreamSchema**](LogStreamSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserschema"></a>
# **GetUserSchema**
> UserSchema GetUserSchema (string schemaId)

Retrieve a User Schema

Fetches the schema for a Schema Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetUserSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);
            var schemaId = "schemaId_example";  // string | 

            try
            {
                // Retrieve a User Schema
                UserSchema result = apiInstance.GetUserSchema(schemaId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetUserSchema: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaId** | **string**|  | 

### Return type

[**UserSchema**](UserSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlogstreamschemas"></a>
# **ListLogStreamSchemas**
> List&lt;LogStreamSchema&gt; ListLogStreamSchemas ()

List the Log Stream Schemas

Lists the schema for all log stream types visible for this org.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListLogStreamSchemasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);

            try
            {
                // List the Log Stream Schemas
                List<LogStreamSchema> result = apiInstance.ListLogStreamSchemas().ToListAsync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.ListLogStreamSchemas: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;LogStreamSchema&gt;**](LogStreamSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapplicationuserprofile"></a>
# **UpdateApplicationUserProfile**
> UserSchema UpdateApplicationUserProfile (string appInstanceId, UserSchema body = null)

Update the default Application User Schema for an Application

Partial updates on the User Profile properties of the Application User Schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateApplicationUserProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);
            var appInstanceId = "appInstanceId_example";  // string | 
            var body = new UserSchema(); // UserSchema |  (optional) 

            try
            {
                // Update the default Application User Schema for an Application
                UserSchema result = apiInstance.UpdateApplicationUserProfile(appInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.UpdateApplicationUserProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appInstanceId** | **string**|  | 
 **body** | [**UserSchema**](UserSchema.md)|  | [optional] 

### Return type

[**UserSchema**](UserSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupschema"></a>
# **UpdateGroupSchema**
> GroupSchema UpdateGroupSchema (GroupSchema groupSchema = null)

Update the default Group Schema

Updates, adds or removes one or more custom Group Profile properties in the schema

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateGroupSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);
            var groupSchema = new GroupSchema(); // GroupSchema |  (optional) 

            try
            {
                // Update the default Group Schema
                GroupSchema result = apiInstance.UpdateGroupSchema(groupSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.UpdateGroupSchema: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupSchema** | [**GroupSchema**](GroupSchema.md)|  | [optional] 

### Return type

[**GroupSchema**](GroupSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserprofile"></a>
# **UpdateUserProfile**
> UserSchema UpdateUserProfile (string schemaId, UserSchema userSchema)

Update a User Schema

Partial updates on the User Profile properties of the user schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateUserProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi(config);
            var schemaId = "schemaId_example";  // string | 
            var userSchema = new UserSchema(); // UserSchema | 

            try
            {
                // Update a User Schema
                UserSchema result = apiInstance.UpdateUserProfile(schemaId, userSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.UpdateUserProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaId** | **string**|  | 
 **userSchema** | [**UserSchema**](UserSchema.md)|  | 

### Return type

[**UserSchema**](UserSchema.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

