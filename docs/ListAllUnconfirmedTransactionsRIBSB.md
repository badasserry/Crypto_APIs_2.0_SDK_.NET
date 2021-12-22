# CryptoAPIs.Model.ListAllUnconfirmedTransactionsRIBSB
Bitcoin

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locktime** | **int** | Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. | 
**Size** | **int** | Represents the total size of this transaction. | 
**VSize** | **int** | Defines the transaction&#39;s virtual size. | 
**_Version** | **int** | Defines the version of the transaction. | 
**Vin** | [**List&lt;ListAllUnconfirmedTransactionsRIBSBVin&gt;**](ListAllUnconfirmedTransactionsRIBSBVin.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;ListUnconfirmedTransactionsByAddressRIBSBVout&gt;**](ListUnconfirmedTransactionsByAddressRIBSBVout.md) | Represents the transaction outputs. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
