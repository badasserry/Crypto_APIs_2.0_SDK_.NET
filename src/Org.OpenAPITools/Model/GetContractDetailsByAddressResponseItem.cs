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
    /// GetContractDetailsByAddressResponseItem
    /// </summary>
    [DataContract(Name = "GetContractDetailsByAddressResponseItem")]
    public partial class GetContractDetailsByAddressResponseItem : IEquatable<GetContractDetailsByAddressResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContractDetailsByAddressResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetContractDetailsByAddressResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContractDetailsByAddressResponseItem" /> class.
        /// </summary>
        /// <param name="confirmedBalance">Token balance (required).</param>
        /// <param name="creatorAddress">Token creator (required).</param>
        /// <param name="tokenDecimals">Number of decimals.</param>
        /// <param name="tokenName">Token name.</param>
        /// <param name="tokenSymbol">Token symbol.</param>
        /// <param name="tokenType">Token type.</param>
        /// <param name="tokensBalance">Token balance (required).</param>
        /// <param name="totalSupply">Token total supply (required).</param>
        public GetContractDetailsByAddressResponseItem(string confirmedBalance = default(string), string creatorAddress = default(string), string tokenDecimals = default(string), string tokenName = default(string), string tokenSymbol = default(string), string tokenType = default(string), string tokensBalance = default(string), string totalSupply = default(string))
        {
            // to ensure "confirmedBalance" is required (not null)
            this.ConfirmedBalance = confirmedBalance ?? throw new ArgumentNullException("confirmedBalance is a required property for GetContractDetailsByAddressResponseItem and cannot be null");
            // to ensure "creatorAddress" is required (not null)
            this.CreatorAddress = creatorAddress ?? throw new ArgumentNullException("creatorAddress is a required property for GetContractDetailsByAddressResponseItem and cannot be null");
            // to ensure "tokensBalance" is required (not null)
            this.TokensBalance = tokensBalance ?? throw new ArgumentNullException("tokensBalance is a required property for GetContractDetailsByAddressResponseItem and cannot be null");
            // to ensure "totalSupply" is required (not null)
            this.TotalSupply = totalSupply ?? throw new ArgumentNullException("totalSupply is a required property for GetContractDetailsByAddressResponseItem and cannot be null");
            this.TokenDecimals = tokenDecimals;
            this.TokenName = tokenName;
            this.TokenSymbol = tokenSymbol;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Token balance
        /// </summary>
        /// <value>Token balance</value>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public string ConfirmedBalance { get; set; }

        /// <summary>
        /// Token creator
        /// </summary>
        /// <value>Token creator</value>
        [DataMember(Name = "creatorAddress", IsRequired = true, EmitDefaultValue = false)]
        public string CreatorAddress { get; set; }

        /// <summary>
        /// Number of decimals
        /// </summary>
        /// <value>Number of decimals</value>
        [DataMember(Name = "tokenDecimals", EmitDefaultValue = false)]
        public string TokenDecimals { get; set; }

        /// <summary>
        /// Token name
        /// </summary>
        /// <value>Token name</value>
        [DataMember(Name = "tokenName", EmitDefaultValue = false)]
        public string TokenName { get; set; }

        /// <summary>
        /// Token symbol
        /// </summary>
        /// <value>Token symbol</value>
        [DataMember(Name = "tokenSymbol", EmitDefaultValue = false)]
        public string TokenSymbol { get; set; }

        /// <summary>
        /// Token type
        /// </summary>
        /// <value>Token type</value>
        [DataMember(Name = "tokenType", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Token balance
        /// </summary>
        /// <value>Token balance</value>
        [DataMember(Name = "tokensBalance", IsRequired = true, EmitDefaultValue = false)]
        public string TokensBalance { get; set; }

        /// <summary>
        /// Token total supply
        /// </summary>
        /// <value>Token total supply</value>
        [DataMember(Name = "totalSupply", IsRequired = true, EmitDefaultValue = false)]
        public string TotalSupply { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetContractDetailsByAddressResponseItem {\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
            sb.Append("  CreatorAddress: ").Append(CreatorAddress).Append("\n");
            sb.Append("  TokenDecimals: ").Append(TokenDecimals).Append("\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
            sb.Append("  TokenSymbol: ").Append(TokenSymbol).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  TokensBalance: ").Append(TokensBalance).Append("\n");
            sb.Append("  TotalSupply: ").Append(TotalSupply).Append("\n");
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
            return this.Equals(input as GetContractDetailsByAddressResponseItem);
        }

        /// <summary>
        /// Returns true if GetContractDetailsByAddressResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContractDetailsByAddressResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContractDetailsByAddressResponseItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfirmedBalance == input.ConfirmedBalance ||
                    (this.ConfirmedBalance != null &&
                    this.ConfirmedBalance.Equals(input.ConfirmedBalance))
                ) && 
                (
                    this.CreatorAddress == input.CreatorAddress ||
                    (this.CreatorAddress != null &&
                    this.CreatorAddress.Equals(input.CreatorAddress))
                ) && 
                (
                    this.TokenDecimals == input.TokenDecimals ||
                    (this.TokenDecimals != null &&
                    this.TokenDecimals.Equals(input.TokenDecimals))
                ) && 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
                ) && 
                (
                    this.TokenSymbol == input.TokenSymbol ||
                    (this.TokenSymbol != null &&
                    this.TokenSymbol.Equals(input.TokenSymbol))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.TokensBalance == input.TokensBalance ||
                    (this.TokensBalance != null &&
                    this.TokensBalance.Equals(input.TokensBalance))
                ) && 
                (
                    this.TotalSupply == input.TotalSupply ||
                    (this.TotalSupply != null &&
                    this.TotalSupply.Equals(input.TotalSupply))
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
                if (this.ConfirmedBalance != null)
                    hashCode = hashCode * 59 + this.ConfirmedBalance.GetHashCode();
                if (this.CreatorAddress != null)
                    hashCode = hashCode * 59 + this.CreatorAddress.GetHashCode();
                if (this.TokenDecimals != null)
                    hashCode = hashCode * 59 + this.TokenDecimals.GetHashCode();
                if (this.TokenName != null)
                    hashCode = hashCode * 59 + this.TokenName.GetHashCode();
                if (this.TokenSymbol != null)
                    hashCode = hashCode * 59 + this.TokenSymbol.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.TokensBalance != null)
                    hashCode = hashCode * 59 + this.TokensBalance.GetHashCode();
                if (this.TotalSupply != null)
                    hashCode = hashCode * 59 + this.TotalSupply.GetHashCode();
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
