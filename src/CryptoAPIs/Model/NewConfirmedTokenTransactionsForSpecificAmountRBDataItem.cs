/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: developers@cryptoapis.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CryptoAPIs.Client.OpenAPIDateConverter;

namespace CryptoAPIs.Model
{
    /// <summary>
    /// NewConfirmedTokenTransactionsForSpecificAmountRBDataItem
    /// </summary>
    [DataContract(Name = "NewConfirmedTokenTransactionsForSpecificAmountRB_data_item")]
    public partial class NewConfirmedTokenTransactionsForSpecificAmountRBDataItem : IEquatable<NewConfirmedTokenTransactionsForSpecificAmountRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedTokenTransactionsForSpecificAmountRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewConfirmedTokenTransactionsForSpecificAmountRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedTokenTransactionsForSpecificAmountRBDataItem" /> class.
        /// </summary>
        /// <param name="allowDuplicates">Specifies a flag that permits or denies the creation of duplicate addresses. (default to false).</param>
        /// <param name="amountHigherThan">Represents a specific amount of tokens after which the system have to send a callback to customers&#39; callbackUrl. (required).</param>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs 2.0. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security)..</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;. (required).</param>
        /// <param name="contractAddress">Represents the contract address of the token, which controls its logic. It is not the address that holds the tokens. (required).</param>
        public NewConfirmedTokenTransactionsForSpecificAmountRBDataItem(bool allowDuplicates = false, long amountHigherThan = default(long), string callbackSecretKey = default(string), string callbackUrl = default(string), string contractAddress = default(string))
        {
            this.AmountHigherThan = amountHigherThan;
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new ArgumentNullException("callbackUrl is a required property for NewConfirmedTokenTransactionsForSpecificAmountRBDataItem and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for NewConfirmedTokenTransactionsForSpecificAmountRBDataItem and cannot be null");
            }
            this.ContractAddress = contractAddress;
            this.AllowDuplicates = allowDuplicates;
            this.CallbackSecretKey = callbackSecretKey;
        }

        /// <summary>
        /// Specifies a flag that permits or denies the creation of duplicate addresses.
        /// </summary>
        /// <value>Specifies a flag that permits or denies the creation of duplicate addresses.</value>
        [DataMember(Name = "allowDuplicates", EmitDefaultValue = true)]
        public bool AllowDuplicates { get; set; }

        /// <summary>
        /// Represents a specific amount of tokens after which the system have to send a callback to customers&#39; callbackUrl.
        /// </summary>
        /// <value>Represents a specific amount of tokens after which the system have to send a callback to customers&#39; callbackUrl.</value>
        [DataMember(Name = "amountHigherThan", IsRequired = true, EmitDefaultValue = false)]
        public long AmountHigherThan { get; set; }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs 2.0. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs 2.0. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Represents the contract address of the token, which controls its logic. It is not the address that holds the tokens.
        /// </summary>
        /// <value>Represents the contract address of the token, which controls its logic. It is not the address that holds the tokens.</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewConfirmedTokenTransactionsForSpecificAmountRBDataItem {\n");
            sb.Append("  AllowDuplicates: ").Append(AllowDuplicates).Append("\n");
            sb.Append("  AmountHigherThan: ").Append(AmountHigherThan).Append("\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewConfirmedTokenTransactionsForSpecificAmountRBDataItem);
        }

        /// <summary>
        /// Returns true if NewConfirmedTokenTransactionsForSpecificAmountRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedTokenTransactionsForSpecificAmountRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedTokenTransactionsForSpecificAmountRBDataItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowDuplicates == input.AllowDuplicates ||
                    this.AllowDuplicates.Equals(input.AllowDuplicates)
                ) && 
                (
                    this.AmountHigherThan == input.AmountHigherThan ||
                    this.AmountHigherThan.Equals(input.AmountHigherThan)
                ) && 
                (
                    this.CallbackSecretKey == input.CallbackSecretKey ||
                    (this.CallbackSecretKey != null &&
                    this.CallbackSecretKey.Equals(input.CallbackSecretKey))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.AllowDuplicates.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountHigherThan.GetHashCode();
                if (this.CallbackSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackSecretKey.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
