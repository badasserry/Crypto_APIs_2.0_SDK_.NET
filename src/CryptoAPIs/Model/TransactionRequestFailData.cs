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
    /// Specifies all data, as attributes, included into the callback notification, which depends on the &#x60;event&#x60;.
    /// </summary>
    [DataContract(Name = "TransactionRequestFail_data")]
    public partial class TransactionRequestFailData : IEquatable<TransactionRequestFailData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRequestFailData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionRequestFailData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRequestFailData" /> class.
        /// </summary>
        /// <param name="product">Represents the Crypto APIs 2.0 product which sends the callback. (required).</param>
        /// <param name="_event">Defines the specific event, for which a callback subscription is set. (required).</param>
        /// <param name="item">item (required).</param>
        public TransactionRequestFailData(string product = default(string), string _event = default(string), TransactionRequestFailDataItem item = default(TransactionRequestFailDataItem))
        {
            // to ensure "product" is required (not null)
            if (product == null) {
                throw new ArgumentNullException("product is a required property for TransactionRequestFailData and cannot be null");
            }
            this.Product = product;
            // to ensure "_event" is required (not null)
            if (_event == null) {
                throw new ArgumentNullException("_event is a required property for TransactionRequestFailData and cannot be null");
            }
            this.Event = _event;
            // to ensure "item" is required (not null)
            if (item == null) {
                throw new ArgumentNullException("item is a required property for TransactionRequestFailData and cannot be null");
            }
            this.Item = item;
        }

        /// <summary>
        /// Represents the Crypto APIs 2.0 product which sends the callback.
        /// </summary>
        /// <value>Represents the Crypto APIs 2.0 product which sends the callback.</value>
        [DataMember(Name = "product", IsRequired = true, EmitDefaultValue = false)]
        public string Product { get; set; }

        /// <summary>
        /// Defines the specific event, for which a callback subscription is set.
        /// </summary>
        /// <value>Defines the specific event, for which a callback subscription is set.</value>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = false)]
        public string Event { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = false)]
        public TransactionRequestFailDataItem Item { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionRequestFailData {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
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
            return this.Equals(input as TransactionRequestFailData);
        }

        /// <summary>
        /// Returns true if TransactionRequestFailData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRequestFailData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRequestFailData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
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
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
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
