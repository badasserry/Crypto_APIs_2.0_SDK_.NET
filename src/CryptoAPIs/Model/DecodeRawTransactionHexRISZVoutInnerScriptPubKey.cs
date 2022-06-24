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
    /// Represents the script public key.
    /// </summary>
    [DataContract(Name = "DecodeRawTransactionHexRISZ_vout_inner_scriptPubKey")]
    public partial class DecodeRawTransactionHexRISZVoutInnerScriptPubKey : IEquatable<DecodeRawTransactionHexRISZVoutInnerScriptPubKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISZVoutInnerScriptPubKey" /> class.
        /// </summary>
        /// <param name="address">Represents the address which send the amount..</param>
        /// <param name="asm">Represents the assembly of the script public key of the address..</param>
        /// <param name="hex">Represents the hex of the script public key of the address..</param>
        /// <param name="type">Represents the script type..</param>
        public DecodeRawTransactionHexRISZVoutInnerScriptPubKey(string address = default(string), string asm = default(string), string hex = default(string), string type = default(string))
        {
            this.Address = address;
            this.Asm = asm;
            this.Hex = hex;
            this.Type = type;
        }

        /// <summary>
        /// Represents the address which send the amount.
        /// </summary>
        /// <value>Represents the address which send the amount.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Represents the assembly of the script public key of the address.
        /// </summary>
        /// <value>Represents the assembly of the script public key of the address.</value>
        [DataMember(Name = "asm", EmitDefaultValue = false)]
        public string Asm { get; set; }

        /// <summary>
        /// Represents the hex of the script public key of the address.
        /// </summary>
        /// <value>Represents the hex of the script public key of the address.</value>
        [DataMember(Name = "hex", EmitDefaultValue = false)]
        public string Hex { get; set; }

        /// <summary>
        /// Represents the script type.
        /// </summary>
        /// <value>Represents the script type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DecodeRawTransactionHexRISZVoutInnerScriptPubKey {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Asm: ").Append(Asm).Append("\n");
            sb.Append("  Hex: ").Append(Hex).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as DecodeRawTransactionHexRISZVoutInnerScriptPubKey);
        }

        /// <summary>
        /// Returns true if DecodeRawTransactionHexRISZVoutInnerScriptPubKey instances are equal
        /// </summary>
        /// <param name="input">Instance of DecodeRawTransactionHexRISZVoutInnerScriptPubKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecodeRawTransactionHexRISZVoutInnerScriptPubKey input)
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
                    this.Asm == input.Asm ||
                    (this.Asm != null &&
                    this.Asm.Equals(input.Asm))
                ) && 
                (
                    this.Hex == input.Hex ||
                    (this.Hex != null &&
                    this.Hex.Equals(input.Hex))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Asm != null)
                {
                    hashCode = (hashCode * 59) + this.Asm.GetHashCode();
                }
                if (this.Hex != null)
                {
                    hashCode = (hashCode * 59) + this.Hex.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
