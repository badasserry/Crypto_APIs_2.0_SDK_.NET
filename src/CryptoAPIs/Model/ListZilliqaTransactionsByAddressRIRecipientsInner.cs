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
    /// ListZilliqaTransactionsByAddressRIRecipientsInner
    /// </summary>
    [DataContract(Name = "ListZilliqaTransactionsByAddressRI_recipients_inner")]
    public partial class ListZilliqaTransactionsByAddressRIRecipientsInner : IEquatable<ListZilliqaTransactionsByAddressRIRecipientsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListZilliqaTransactionsByAddressRIRecipientsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListZilliqaTransactionsByAddressRIRecipientsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListZilliqaTransactionsByAddressRIRecipientsInner" /> class.
        /// </summary>
        /// <param name="address">Represents the recipient&#39;s address. (required).</param>
        /// <param name="amount">Represents the received amount. (required).</param>
        public ListZilliqaTransactionsByAddressRIRecipientsInner(string address = default(string), string amount = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for ListZilliqaTransactionsByAddressRIRecipientsInner and cannot be null");
            }
            this.Address = address;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ListZilliqaTransactionsByAddressRIRecipientsInner and cannot be null");
            }
            this.Amount = amount;
        }

        /// <summary>
        /// Represents the recipient&#39;s address.
        /// </summary>
        /// <value>Represents the recipient&#39;s address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Represents the received amount.
        /// </summary>
        /// <value>Represents the received amount.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListZilliqaTransactionsByAddressRIRecipientsInner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as ListZilliqaTransactionsByAddressRIRecipientsInner);
        }

        /// <summary>
        /// Returns true if ListZilliqaTransactionsByAddressRIRecipientsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ListZilliqaTransactionsByAddressRIRecipientsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListZilliqaTransactionsByAddressRIRecipientsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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