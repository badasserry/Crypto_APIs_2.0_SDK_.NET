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
    /// DeriveAndSyncNewChangeAddressesRBDataItem
    /// </summary>
    [DataContract(Name = "DeriveAndSyncNewChangeAddressesRB_data_item")]
    public partial class DeriveAndSyncNewChangeAddressesRBDataItem : IEquatable<DeriveAndSyncNewChangeAddressesRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeriveAndSyncNewChangeAddressesRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeriveAndSyncNewChangeAddressesRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeriveAndSyncNewChangeAddressesRBDataItem" /> class.
        /// </summary>
        /// <param name="extendedPublicKey">Defines the account extended publicly known key which is used to derive all child public keys. (required).</param>
        public DeriveAndSyncNewChangeAddressesRBDataItem(string extendedPublicKey = default(string))
        {
            // to ensure "extendedPublicKey" is required (not null)
            if (extendedPublicKey == null)
            {
                throw new ArgumentNullException("extendedPublicKey is a required property for DeriveAndSyncNewChangeAddressesRBDataItem and cannot be null");
            }
            this.ExtendedPublicKey = extendedPublicKey;
        }

        /// <summary>
        /// Defines the account extended publicly known key which is used to derive all child public keys.
        /// </summary>
        /// <value>Defines the account extended publicly known key which is used to derive all child public keys.</value>
        [DataMember(Name = "extendedPublicKey", IsRequired = true, EmitDefaultValue = false)]
        public string ExtendedPublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeriveAndSyncNewChangeAddressesRBDataItem {\n");
            sb.Append("  ExtendedPublicKey: ").Append(ExtendedPublicKey).Append("\n");
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
            return this.Equals(input as DeriveAndSyncNewChangeAddressesRBDataItem);
        }

        /// <summary>
        /// Returns true if DeriveAndSyncNewChangeAddressesRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DeriveAndSyncNewChangeAddressesRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeriveAndSyncNewChangeAddressesRBDataItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtendedPublicKey == input.ExtendedPublicKey ||
                    (this.ExtendedPublicKey != null &&
                    this.ExtendedPublicKey.Equals(input.ExtendedPublicKey))
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
                if (this.ExtendedPublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendedPublicKey.GetHashCode();
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