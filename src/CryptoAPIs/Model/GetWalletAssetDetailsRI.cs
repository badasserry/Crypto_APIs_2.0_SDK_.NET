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
    /// GetWalletAssetDetailsRI
    /// </summary>
    [DataContract(Name = "GetWalletAssetDetailsRI")]
    public partial class GetWalletAssetDetailsRI : IEquatable<GetWalletAssetDetailsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletAssetDetailsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWalletAssetDetailsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletAssetDetailsRI" /> class.
        /// </summary>
        /// <param name="confirmedBalance">confirmedBalance (required).</param>
        /// <param name="depositAddressesCount">Specifies the count of deposit addresses in the Wallet. (required).</param>
        /// <param name="fungibleTokens">Represents fungible tokens&#39;es detailed information (required).</param>
        /// <param name="name">Defines the name of the Wallet given to it by the user. (required).</param>
        /// <param name="nonFungibleTokens">Represents non-fungible tokens&#39;es detailed information. (required).</param>
        /// <param name="recievedConfirmedAmount">recievedConfirmedAmount (required).</param>
        /// <param name="sentConfirmedAmount">sentConfirmedAmount (required).</param>
        public GetWalletAssetDetailsRI(GetWalletAssetDetailsRIConfirmedBalance confirmedBalance = default(GetWalletAssetDetailsRIConfirmedBalance), int depositAddressesCount = default(int), List<GetWalletAssetDetailsRIFungibleTokensInner> fungibleTokens = default(List<GetWalletAssetDetailsRIFungibleTokensInner>), string name = default(string), List<GetWalletAssetDetailsRINonFungibleTokensInner> nonFungibleTokens = default(List<GetWalletAssetDetailsRINonFungibleTokensInner>), GetWalletAssetDetailsRIRecievedConfirmedAmount recievedConfirmedAmount = default(GetWalletAssetDetailsRIRecievedConfirmedAmount), GetWalletAssetDetailsRISentConfirmedAmount sentConfirmedAmount = default(GetWalletAssetDetailsRISentConfirmedAmount))
        {
            // to ensure "confirmedBalance" is required (not null)
            if (confirmedBalance == null)
            {
                throw new ArgumentNullException("confirmedBalance is a required property for GetWalletAssetDetailsRI and cannot be null");
            }
            this.ConfirmedBalance = confirmedBalance;
            this.DepositAddressesCount = depositAddressesCount;
            // to ensure "fungibleTokens" is required (not null)
            if (fungibleTokens == null)
            {
                throw new ArgumentNullException("fungibleTokens is a required property for GetWalletAssetDetailsRI and cannot be null");
            }
            this.FungibleTokens = fungibleTokens;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetWalletAssetDetailsRI and cannot be null");
            }
            this.Name = name;
            // to ensure "nonFungibleTokens" is required (not null)
            if (nonFungibleTokens == null)
            {
                throw new ArgumentNullException("nonFungibleTokens is a required property for GetWalletAssetDetailsRI and cannot be null");
            }
            this.NonFungibleTokens = nonFungibleTokens;
            // to ensure "recievedConfirmedAmount" is required (not null)
            if (recievedConfirmedAmount == null)
            {
                throw new ArgumentNullException("recievedConfirmedAmount is a required property for GetWalletAssetDetailsRI and cannot be null");
            }
            this.RecievedConfirmedAmount = recievedConfirmedAmount;
            // to ensure "sentConfirmedAmount" is required (not null)
            if (sentConfirmedAmount == null)
            {
                throw new ArgumentNullException("sentConfirmedAmount is a required property for GetWalletAssetDetailsRI and cannot be null");
            }
            this.SentConfirmedAmount = sentConfirmedAmount;
        }

        /// <summary>
        /// Gets or Sets ConfirmedBalance
        /// </summary>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public GetWalletAssetDetailsRIConfirmedBalance ConfirmedBalance { get; set; }

        /// <summary>
        /// Specifies the count of deposit addresses in the Wallet.
        /// </summary>
        /// <value>Specifies the count of deposit addresses in the Wallet.</value>
        [DataMember(Name = "depositAddressesCount", IsRequired = true, EmitDefaultValue = false)]
        public int DepositAddressesCount { get; set; }

        /// <summary>
        /// Represents fungible tokens&#39;es detailed information
        /// </summary>
        /// <value>Represents fungible tokens&#39;es detailed information</value>
        [DataMember(Name = "fungibleTokens", IsRequired = true, EmitDefaultValue = false)]
        public List<GetWalletAssetDetailsRIFungibleTokensInner> FungibleTokens { get; set; }

        /// <summary>
        /// Defines the name of the Wallet given to it by the user.
        /// </summary>
        /// <value>Defines the name of the Wallet given to it by the user.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Represents non-fungible tokens&#39;es detailed information.
        /// </summary>
        /// <value>Represents non-fungible tokens&#39;es detailed information.</value>
        [DataMember(Name = "nonFungibleTokens", IsRequired = true, EmitDefaultValue = false)]
        public List<GetWalletAssetDetailsRINonFungibleTokensInner> NonFungibleTokens { get; set; }

        /// <summary>
        /// Gets or Sets RecievedConfirmedAmount
        /// </summary>
        [DataMember(Name = "recievedConfirmedAmount", IsRequired = true, EmitDefaultValue = false)]
        public GetWalletAssetDetailsRIRecievedConfirmedAmount RecievedConfirmedAmount { get; set; }

        /// <summary>
        /// Gets or Sets SentConfirmedAmount
        /// </summary>
        [DataMember(Name = "sentConfirmedAmount", IsRequired = true, EmitDefaultValue = false)]
        public GetWalletAssetDetailsRISentConfirmedAmount SentConfirmedAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWalletAssetDetailsRI {\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
            sb.Append("  DepositAddressesCount: ").Append(DepositAddressesCount).Append("\n");
            sb.Append("  FungibleTokens: ").Append(FungibleTokens).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NonFungibleTokens: ").Append(NonFungibleTokens).Append("\n");
            sb.Append("  RecievedConfirmedAmount: ").Append(RecievedConfirmedAmount).Append("\n");
            sb.Append("  SentConfirmedAmount: ").Append(SentConfirmedAmount).Append("\n");
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
            return this.Equals(input as GetWalletAssetDetailsRI);
        }

        /// <summary>
        /// Returns true if GetWalletAssetDetailsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWalletAssetDetailsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWalletAssetDetailsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfirmedBalance == input.ConfirmedBalance ||
                    (this.ConfirmedBalance != null &&
                    this.ConfirmedBalance.Equals(input.ConfirmedBalance))
                ) && 
                (
                    this.DepositAddressesCount == input.DepositAddressesCount ||
                    this.DepositAddressesCount.Equals(input.DepositAddressesCount)
                ) && 
                (
                    this.FungibleTokens == input.FungibleTokens ||
                    this.FungibleTokens != null &&
                    input.FungibleTokens != null &&
                    this.FungibleTokens.SequenceEqual(input.FungibleTokens)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NonFungibleTokens == input.NonFungibleTokens ||
                    this.NonFungibleTokens != null &&
                    input.NonFungibleTokens != null &&
                    this.NonFungibleTokens.SequenceEqual(input.NonFungibleTokens)
                ) && 
                (
                    this.RecievedConfirmedAmount == input.RecievedConfirmedAmount ||
                    (this.RecievedConfirmedAmount != null &&
                    this.RecievedConfirmedAmount.Equals(input.RecievedConfirmedAmount))
                ) && 
                (
                    this.SentConfirmedAmount == input.SentConfirmedAmount ||
                    (this.SentConfirmedAmount != null &&
                    this.SentConfirmedAmount.Equals(input.SentConfirmedAmount))
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
                {
                    hashCode = (hashCode * 59) + this.ConfirmedBalance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DepositAddressesCount.GetHashCode();
                if (this.FungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.FungibleTokens.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NonFungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.NonFungibleTokens.GetHashCode();
                }
                if (this.RecievedConfirmedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RecievedConfirmedAmount.GetHashCode();
                }
                if (this.SentConfirmedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SentConfirmedAmount.GetHashCode();
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
