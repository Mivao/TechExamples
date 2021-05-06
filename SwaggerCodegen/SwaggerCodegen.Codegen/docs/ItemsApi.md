# IO.Swagger.Api.ItemsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiItemsIdDelete**](ItemsApi.md#apiitemsiddelete) | **DELETE** /api/Items/{Id} | Deletes an item from the database
[**ApiItemsIdGet**](ItemsApi.md#apiitemsidget) | **GET** /api/Items/{Id} | Gets an Item based on a supplied Id.
[**ApiItemsPost**](ItemsApi.md#apiitemspost) | **POST** /api/Items | Adds a new Item to the database
[**ApiItemsPut**](ItemsApi.md#apiitemsput) | **PUT** /api/Items | Updates an existing Item

<a name="apiitemsiddelete"></a>
# **ApiItemsIdDelete**
> void ApiItemsIdDelete (int? id)

Deletes an item from the database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiItemsIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new ItemsApi();
            var id = 56;  // int? | 

            try
            {
                // Deletes an item from the database
                apiInstance.ApiItemsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.ApiItemsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiitemsidget"></a>
# **ApiItemsIdGet**
> Item ApiItemsIdGet (int? id)

Gets an Item based on a supplied Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiItemsIdGetExample
    {
        public void main()
        {
            var apiInstance = new ItemsApi();
            var id = 56;  // int? | 

            try
            {
                // Gets an Item based on a supplied Id.
                Item result = apiInstance.ApiItemsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.ApiItemsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**Item**](Item.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiitemspost"></a>
# **ApiItemsPost**
> Item ApiItemsPost (Item body = null)

Adds a new Item to the database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiItemsPostExample
    {
        public void main()
        {
            var apiInstance = new ItemsApi();
            var body = new Item(); // Item |  (optional) 

            try
            {
                // Adds a new Item to the database
                Item result = apiInstance.ApiItemsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.ApiItemsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Item**](Item.md)|  | [optional] 

### Return type

[**Item**](Item.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiitemsput"></a>
# **ApiItemsPut**
> void ApiItemsPut (Item body = null)

Updates an existing Item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiItemsPutExample
    {
        public void main()
        {
            var apiInstance = new ItemsApi();
            var body = new Item(); // Item |  (optional) 

            try
            {
                // Updates an existing Item
                apiInstance.ApiItemsPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.ApiItemsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Item**](Item.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
