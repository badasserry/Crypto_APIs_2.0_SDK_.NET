# CryptoAPIs.Api.InternalApi

All URIs are relative to *https://rest.cryptoapis.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInternalTransactionByTransactionHashAndOperationId**](InternalApi.md#getinternaltransactionbytransactionhashandoperationid) | **GET** /blockchain-data/{blockchain}/{network}/transactions/{transactionHash}/internal/{operationId} | Get Internal Transaction by Transaction Hash and Operation Id
[**ListInternalTransactionDetailsByTransactionHash**](InternalApi.md#listinternaltransactiondetailsbytransactionhash) | **GET** /blockchain-data/{blockchain}/{network}/transactions/{transactionHash}/internal | List Internal Transaction Details by Transaction Hash


<a name="getinternaltransactionbytransactionhashandoperationid"></a>
# **GetInternalTransactionByTransactionHashAndOperationId**
> GetInternalTransactionByTransactionHashAndOperationIdR GetInternalTransactionByTransactionHashAndOperationId (string blockchain, string network, string operationId, string transactionHash, string context = null)

Get Internal Transaction by Transaction Hash and Operation Id

Through this endpoint customers can obtain detailed information about a specific Internal Transaction by using the attributes `transactionHash`  (the parent transaction's Hash) and `operationId` (type trace address).    An internal transaction is the result of a smart contract being triggered by an EOA or a subsequent contract call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetInternalTransactionByTransactionHashAndOperationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InternalApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (default to ethereum)
            var network = mainnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks. (default to ropsten)
            var operationId = call_4;  // string | Represents the unique internal transaction ID in regards to the parent transaction (type trace address).
            var transactionHash = 0x92bb77e16444e0417c8b50dfab68e89c7ad27d4140a766c3bbd4d0ac195f12fc;  // string | String identifier of the parent transaction of the internal transaction represented in CryptoAPIs.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get Internal Transaction by Transaction Hash and Operation Id
                GetInternalTransactionByTransactionHashAndOperationIdR result = apiInstance.GetInternalTransactionByTransactionHashAndOperationId(blockchain, network, operationId, transactionHash, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalApi.GetInternalTransactionByTransactionHashAndOperationId: " + e.Message );
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
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | [default to ethereum]
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | [default to ropsten]
 **operationId** | **string**| Represents the unique internal transaction ID in regards to the parent transaction (type trace address). | 
 **transactionHash** | **string**| String identifier of the parent transaction of the internal transaction represented in CryptoAPIs. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 

### Return type

[**GetInternalTransactionByTransactionHashAndOperationIdR**](GetInternalTransactionByTransactionHashAndOperationIdR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **404** | The specified internal transaction has not been found on the specific blockchain. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinternaltransactiondetailsbytransactionhash"></a>
# **ListInternalTransactionDetailsByTransactionHash**
> ListInternalTransactionDetailsByTransactionHashR ListInternalTransactionDetailsByTransactionHash (string blockchain, string network, string transactionHash, string context = null, int? limit = null, int? offset = null)

List Internal Transaction Details by Transaction Hash

Through this endpoint customers can list internal transactions along with their details by a specific attribute `transactionHash`, which is the parent transaction's Hash.    An internal transaction is the result of a smart contract being triggered by an EOA or a subsequent contract call.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListInternalTransactionDetailsByTransactionHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InternalApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (default to ethereum)
            var network = mainnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks. (default to mainnet)
            var transactionHash = 0x5d4ea0471b70de09fa3d6a4bc32f703ec44483bffa4d6169fa0a36c6a1dc108a;  // string | String identifier of the parent transaction of the internal transaction represented in CryptoAPIs.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // int? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 10;  // int? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List Internal Transaction Details by Transaction Hash
                ListInternalTransactionDetailsByTransactionHashR result = apiInstance.ListInternalTransactionDetailsByTransactionHash(blockchain, network, transactionHash, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalApi.ListInternalTransactionDetailsByTransactionHash: " + e.Message );
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
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | [default to ethereum]
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | [default to mainnet]
 **transactionHash** | **string**| String identifier of the parent transaction of the internal transaction represented in CryptoAPIs. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **limit** | **int?**| Defines how many items should be returned in the response per page basis. | [optional] [default to 50]
 **offset** | **int?**| The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0]

### Return type

[**ListInternalTransactionDetailsByTransactionHashR**](ListInternalTransactionDetailsByTransactionHashR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been sussessful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
