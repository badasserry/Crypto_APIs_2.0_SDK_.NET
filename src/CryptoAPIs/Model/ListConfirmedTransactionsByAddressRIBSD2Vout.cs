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
    /// ListConfirmedTransactionsByAddressRIBSD2Vout
    /// </summary>
    [DataContract(Name = "ListConfirmedTransactionsByAddressRIBSD2_vout")]
    public partial class ListConfirmedTransactionsByAddressRIBSD2Vout : IEquatable<ListConfirmedTransactionsByAddressRIBSD2Vout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressRIBSD2Vout" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListConfirmedTransactionsByAddressRIBSD2Vout() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressRIBSD2Vout" /> class.
        /// </summary>
        /// <param name="isSpent">Defines whether the output is spent or not. (required).</param>
        /// <param name="scriptPubKey">scriptPubKey (required).</param>
        /// <param name="value">Represents the sent/received amount. (required).</param>
        public ListConfirmedTransactionsByAddressRIBSD2Vout(bool isSpent = default(bool), ListConfirmedTransactionsByAddressRIBSD2ScriptPubKey scriptPubKey = default(ListConfirmedTransactionsByAddressRIBSD2ScriptPubKey), string value = default(string))
        {
            this.IsSpent = isSpent;
            // to ensure "scriptPubKey" is required (not null)
            if (scriptPubKey == null) {
                throw new ArgumentNullException("scriptPubKey is a required property for ListConfirmedTransactionsByAddressRIBSD2Vout and cannot be null");
            }
            this.ScriptPubKey = scriptPubKey;
            // to ensure "value" is required (not null)
            if (value == null) {
                throw new ArgumentNullException("value is a required property for ListConfirmedTransactionsByAddressRIBSD2Vout and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Defines whether the output is spent or not.
        /// </summary>
        /// <value>Defines whether the output is spent or not.</value>
        [DataMember(Name = "isSpent", IsRequired = true, EmitDefaultValue = true)]
        public bool IsSpent { get; set; }

        /// <summary>
        /// Gets or Sets ScriptPubKey
        /// </summary>
        [DataMember(Name = "scriptPubKey", IsRequired = true, EmitDefaultValue = false)]
        public ListConfirmedTransactionsByAddressRIBSD2ScriptPubKey ScriptPubKey { get; set; }

        /// <summary>
        /// Represents the sent/received amount.
        /// </summary>
        /// <value>Represents the sent/received amount.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfirmedTransactionsByAddressRIBSD2Vout {\n");
            sb.Append("  IsSpent: ").Append(IsSpent).Append("\n");
            sb.Append("  ScriptPubKey: ").Append(ScriptPubKey).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ListConfirmedTransactionsByAddressRIBSD2Vout);
        }

        /// <summary>
        /// Returns true if ListConfirmedTransactionsByAddressRIBSD2Vout instances are equal
        /// </summary>
        /// <param name="input">Instance of ListConfirmedTransactionsByAddressRIBSD2Vout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListConfirmedTransactionsByAddressRIBSD2Vout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsSpent == input.IsSpent ||
                    this.IsSpent.Equals(input.IsSpent)
                ) && 
                (
                    this.ScriptPubKey == input.ScriptPubKey ||
                    (this.ScriptPubKey != null &&
                    this.ScriptPubKey.Equals(input.ScriptPubKey))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = hashCode * 59 + this.IsSpent.GetHashCode();
                if (this.ScriptPubKey != null)
                    hashCode = hashCode * 59 + this.ScriptPubKey.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
