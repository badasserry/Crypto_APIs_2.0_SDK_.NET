/*
 * Crypto APIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: bizdev@cryptoapis.io
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines an &#x60;item&#x60; as one result.
    /// </summary>
    [DataContract(Name = "TokensForwardingFail_data_item")]
    public partial class TokensForwardingFailDataItem : IEquatable<TokensForwardingFailDataItem>, IValidatableObject
    {
        /// <summary>
        /// Represents the error code received for the failed token forwarding.
        /// </summary>
        /// <value>Represents the error code received for the failed token forwarding.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorCodeEnum
        {
            /// <summary>
            /// Enum NOTENOUGHCREDITS for value: NOT_ENOUGH_CREDITS
            /// </summary>
            [EnumMember(Value = "NOT_ENOUGH_CREDITS")]
            NOTENOUGHCREDITS = 1,

            /// <summary>
            /// Enum FEEADDRESSOUTOFFUNDS for value: FEE_ADDRESS_OUT_OF_FUNDS
            /// </summary>
            [EnumMember(Value = "FEE_ADDRESS_OUT_OF_FUNDS")]
            FEEADDRESSOUTOFFUNDS = 2,

            /// <summary>
            /// Enum WRONGADDRESSCREDENTIALS for value: WRONG_ADDRESS_CREDENTIALS
            /// </summary>
            [EnumMember(Value = "WRONG_ADDRESS_CREDENTIALS")]
            WRONGADDRESSCREDENTIALS = 3

        }


        /// <summary>
        /// Represents the error code received for the failed token forwarding.
        /// </summary>
        /// <value>Represents the error code received for the failed token forwarding.</value>
        [DataMember(Name = "errorCode", IsRequired = true, EmitDefaultValue = false)]
        public ErrorCodeEnum ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensForwardingFailDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokensForwardingFailDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensForwardingFailDataItem" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. (required).</param>
        /// <param name="fromAddress">Represents the hash of the address that provides the tokens. (required).</param>
        /// <param name="toAddress">Represents the hash of the address to forward the tokens to. (required).</param>
        /// <param name="triggerTransactionId">Defines the unique Transaction ID that triggered the token forwarding. (required).</param>
        /// <param name="errorCode">Represents the error code received for the failed token forwarding. (required).</param>
        /// <param name="errorMessage">Represents the error message received for the failed token forwarding. (required).</param>
        public TokensForwardingFailDataItem(string blockchain = default(string), string network = default(string), string fromAddress = default(string), string toAddress = default(string), string triggerTransactionId = default(string), ErrorCodeEnum errorCode = default(ErrorCodeEnum), string errorMessage = default(string))
        {
            // to ensure "blockchain" is required (not null)
            this.Blockchain = blockchain ?? throw new ArgumentNullException("blockchain is a required property for TokensForwardingFailDataItem and cannot be null");
            // to ensure "network" is required (not null)
            this.Network = network ?? throw new ArgumentNullException("network is a required property for TokensForwardingFailDataItem and cannot be null");
            // to ensure "fromAddress" is required (not null)
            this.FromAddress = fromAddress ?? throw new ArgumentNullException("fromAddress is a required property for TokensForwardingFailDataItem and cannot be null");
            // to ensure "toAddress" is required (not null)
            this.ToAddress = toAddress ?? throw new ArgumentNullException("toAddress is a required property for TokensForwardingFailDataItem and cannot be null");
            // to ensure "triggerTransactionId" is required (not null)
            this.TriggerTransactionId = triggerTransactionId ?? throw new ArgumentNullException("triggerTransactionId is a required property for TokensForwardingFailDataItem and cannot be null");
            this.ErrorCode = errorCode;
            // to ensure "errorMessage" is required (not null)
            this.ErrorMessage = errorMessage ?? throw new ArgumentNullException("errorMessage is a required property for TokensForwardingFailDataItem and cannot be null");
        }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Represents the hash of the address that provides the tokens.
        /// </summary>
        /// <value>Represents the hash of the address that provides the tokens.</value>
        [DataMember(Name = "fromAddress", IsRequired = true, EmitDefaultValue = false)]
        public string FromAddress { get; set; }

        /// <summary>
        /// Represents the hash of the address to forward the tokens to.
        /// </summary>
        /// <value>Represents the hash of the address to forward the tokens to.</value>
        [DataMember(Name = "toAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// Defines the unique Transaction ID that triggered the token forwarding.
        /// </summary>
        /// <value>Defines the unique Transaction ID that triggered the token forwarding.</value>
        [DataMember(Name = "triggerTransactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TriggerTransactionId { get; set; }

        /// <summary>
        /// Represents the error message received for the failed token forwarding.
        /// </summary>
        /// <value>Represents the error message received for the failed token forwarding.</value>
        [DataMember(Name = "errorMessage", IsRequired = true, EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokensForwardingFailDataItem {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  TriggerTransactionId: ").Append(TriggerTransactionId).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as TokensForwardingFailDataItem);
        }

        /// <summary>
        /// Returns true if TokensForwardingFailDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensForwardingFailDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensForwardingFailDataItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.ToAddress == input.ToAddress ||
                    (this.ToAddress != null &&
                    this.ToAddress.Equals(input.ToAddress))
                ) && 
                (
                    this.TriggerTransactionId == input.TriggerTransactionId ||
                    (this.TriggerTransactionId != null &&
                    this.TriggerTransactionId.Equals(input.TriggerTransactionId))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.Blockchain != null)
                    hashCode = hashCode * 59 + this.Blockchain.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.FromAddress != null)
                    hashCode = hashCode * 59 + this.FromAddress.GetHashCode();
                if (this.ToAddress != null)
                    hashCode = hashCode * 59 + this.ToAddress.GetHashCode();
                if (this.TriggerTransactionId != null)
                    hashCode = hashCode * 59 + this.TriggerTransactionId.GetHashCode();
                hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
