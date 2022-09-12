/*
 * CryptoAPIs
 *
 * Crypto APIs is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2021-03-20
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
    /// ListSyncedAddressesRI
    /// </summary>
    [DataContract(Name = "ListSyncedAddressesRI")]
    public partial class ListSyncedAddressesRI : IEquatable<ListSyncedAddressesRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSyncedAddressesRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListSyncedAddressesRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSyncedAddressesRI" /> class.
        /// </summary>
        /// <param name="address">Represents the address. (required).</param>
        /// <param name="index">Represents the index position of the transaction in the specific block. (required).</param>
        public ListSyncedAddressesRI(string address = default(string), long index = default(long))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for ListSyncedAddressesRI and cannot be null");
            }
            this.Address = address;
            this.Index = index;
        }

        /// <summary>
        /// Represents the address.
        /// </summary>
        /// <value>Represents the address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Represents the index position of the transaction in the specific block.
        /// </summary>
        /// <value>Represents the index position of the transaction in the specific block.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = false)]
        public long Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListSyncedAddressesRI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as ListSyncedAddressesRI);
        }

        /// <summary>
        /// Returns true if ListSyncedAddressesRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSyncedAddressesRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSyncedAddressesRI input)
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
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
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