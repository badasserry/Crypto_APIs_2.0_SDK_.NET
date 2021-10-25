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
    /// CreateCoinsTransactionFromAddressForWholeAmountRBData
    /// </summary>
    [DataContract(Name = "CreateCoinsTransactionFromAddressForWholeAmountRB_data")]
    public partial class CreateCoinsTransactionFromAddressForWholeAmountRBData : IEquatable<CreateCoinsTransactionFromAddressForWholeAmountRBData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinsTransactionFromAddressForWholeAmountRBData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCoinsTransactionFromAddressForWholeAmountRBData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinsTransactionFromAddressForWholeAmountRBData" /> class.
        /// </summary>
        /// <param name="item">item (required).</param>
        public CreateCoinsTransactionFromAddressForWholeAmountRBData(CreateCoinsTransactionFromAddressForWholeAmountRBDataItem item = default(CreateCoinsTransactionFromAddressForWholeAmountRBDataItem))
        {
            // to ensure "item" is required (not null)
            if (item == null) {
                throw new ArgumentNullException("item is a required property for CreateCoinsTransactionFromAddressForWholeAmountRBData and cannot be null");
            }
            this.Item = item;
        }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = false)]
        public CreateCoinsTransactionFromAddressForWholeAmountRBDataItem Item { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCoinsTransactionFromAddressForWholeAmountRBData {\n");
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
            return this.Equals(input as CreateCoinsTransactionFromAddressForWholeAmountRBData);
        }

        /// <summary>
        /// Returns true if CreateCoinsTransactionFromAddressForWholeAmountRBData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCoinsTransactionFromAddressForWholeAmountRBData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCoinsTransactionFromAddressForWholeAmountRBData input)
        {
            if (input == null)
                return false;

            return 
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
