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
    /// Bitcoin Cash
    /// </summary>
    [DataContract(Name = "ListUnconfirmedTransactionsByAddressRIBSBC")]
    public partial class ListUnconfirmedTransactionsByAddressRIBSBC : IEquatable<ListUnconfirmedTransactionsByAddressRIBSBC>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUnconfirmedTransactionsByAddressRIBSBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListUnconfirmedTransactionsByAddressRIBSBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUnconfirmedTransactionsByAddressRIBSBC" /> class.
        /// </summary>
        /// <param name="locktime">Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. (required).</param>
        /// <param name="size">Represents the total size of this transaction. (required).</param>
        /// <param name="version">Represents the transaction&#39;s version number. (required).</param>
        /// <param name="vin">Represents the transaction inputs. (required).</param>
        /// <param name="vout">Represents the transaction outputs. (required).</param>
        public ListUnconfirmedTransactionsByAddressRIBSBC(int locktime = default(int), int size = default(int), int version = default(int), List<ListUnconfirmedTransactionsByAddressRIBSBCVin> vin = default(List<ListUnconfirmedTransactionsByAddressRIBSBCVin>), List<ListUnconfirmedTransactionsByAddressRIBSBCVout> vout = default(List<ListUnconfirmedTransactionsByAddressRIBSBCVout>))
        {
            this.Locktime = locktime;
            this.Size = size;
            this._Version = version;
            // to ensure "vin" is required (not null)
            if (vin == null) {
                throw new ArgumentNullException("vin is a required property for ListUnconfirmedTransactionsByAddressRIBSBC and cannot be null");
            }
            this.Vin = vin;
            // to ensure "vout" is required (not null)
            if (vout == null) {
                throw new ArgumentNullException("vout is a required property for ListUnconfirmedTransactionsByAddressRIBSBC and cannot be null");
            }
            this.Vout = vout;
        }

        /// <summary>
        /// Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid.
        /// </summary>
        /// <value>Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid.</value>
        [DataMember(Name = "locktime", IsRequired = true, EmitDefaultValue = false)]
        public int Locktime { get; set; }

        /// <summary>
        /// Represents the total size of this transaction.
        /// </summary>
        /// <value>Represents the total size of this transaction.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Represents the transaction&#39;s version number.
        /// </summary>
        /// <value>Represents the transaction&#39;s version number.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Represents the transaction inputs.
        /// </summary>
        /// <value>Represents the transaction inputs.</value>
        [DataMember(Name = "vin", IsRequired = true, EmitDefaultValue = false)]
        public List<ListUnconfirmedTransactionsByAddressRIBSBCVin> Vin { get; set; }

        /// <summary>
        /// Represents the transaction outputs.
        /// </summary>
        /// <value>Represents the transaction outputs.</value>
        [DataMember(Name = "vout", IsRequired = true, EmitDefaultValue = false)]
        public List<ListUnconfirmedTransactionsByAddressRIBSBCVout> Vout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUnconfirmedTransactionsByAddressRIBSBC {\n");
            sb.Append("  Locktime: ").Append(Locktime).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Vin: ").Append(Vin).Append("\n");
            sb.Append("  Vout: ").Append(Vout).Append("\n");
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
            return this.Equals(input as ListUnconfirmedTransactionsByAddressRIBSBC);
        }

        /// <summary>
        /// Returns true if ListUnconfirmedTransactionsByAddressRIBSBC instances are equal
        /// </summary>
        /// <param name="input">Instance of ListUnconfirmedTransactionsByAddressRIBSBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListUnconfirmedTransactionsByAddressRIBSBC input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Locktime == input.Locktime ||
                    this.Locktime.Equals(input.Locktime)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Vin == input.Vin ||
                    this.Vin != null &&
                    input.Vin != null &&
                    this.Vin.SequenceEqual(input.Vin)
                ) && 
                (
                    this.Vout == input.Vout ||
                    this.Vout != null &&
                    input.Vout != null &&
                    this.Vout.SequenceEqual(input.Vout)
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
                hashCode = hashCode * 59 + this.Locktime.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Vin != null)
                    hashCode = hashCode * 59 + this.Vin.GetHashCode();
                if (this.Vout != null)
                    hashCode = hashCode * 59 + this.Vout.GetHashCode();
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
