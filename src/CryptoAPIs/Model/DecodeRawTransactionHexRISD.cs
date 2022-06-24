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
    /// Dash
    /// </summary>
    [DataContract(Name = "DecodeRawTransactionHexRISD")]
    public partial class DecodeRawTransactionHexRISD : IEquatable<DecodeRawTransactionHexRISD>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISD" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecodeRawTransactionHexRISD() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISD" /> class.
        /// </summary>
        /// <param name="locktime">Represents the time at which a particular transaction can be added to the blockchain. (required).</param>
        /// <param name="transactionHash">Represents the same as transactionId for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols hash is different from transactionId for SegWit transactions. (required).</param>
        /// <param name="vSize">Represents the virtual size of this transaction. (required).</param>
        /// <param name="version">Represents transaction version number. (required).</param>
        /// <param name="vin">Represents the transaction inputs. (required).</param>
        /// <param name="vout">Represents the transaction outputs. (required).</param>
        /// <param name="weight">Represents the size of a block, measured in weight units and including the segwit discount..</param>
        public DecodeRawTransactionHexRISD(int locktime = default(int), string transactionHash = default(string), int vSize = default(int), int version = default(int), List<DecodeRawTransactionHexRISDVinInner> vin = default(List<DecodeRawTransactionHexRISDVinInner>), List<DecodeRawTransactionHexRISDVoutInner> vout = default(List<DecodeRawTransactionHexRISDVoutInner>), int weight = default(int))
        {
            this.Locktime = locktime;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for DecodeRawTransactionHexRISD and cannot be null");
            }
            this.TransactionHash = transactionHash;
            this.VSize = vSize;
            this._Version = version;
            // to ensure "vin" is required (not null)
            if (vin == null)
            {
                throw new ArgumentNullException("vin is a required property for DecodeRawTransactionHexRISD and cannot be null");
            }
            this.Vin = vin;
            // to ensure "vout" is required (not null)
            if (vout == null)
            {
                throw new ArgumentNullException("vout is a required property for DecodeRawTransactionHexRISD and cannot be null");
            }
            this.Vout = vout;
            this.Weight = weight;
        }

        /// <summary>
        /// Represents the time at which a particular transaction can be added to the blockchain.
        /// </summary>
        /// <value>Represents the time at which a particular transaction can be added to the blockchain.</value>
        [DataMember(Name = "locktime", IsRequired = true, EmitDefaultValue = false)]
        public int Locktime { get; set; }

        /// <summary>
        /// Represents the same as transactionId for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols hash is different from transactionId for SegWit transactions.
        /// </summary>
        /// <value>Represents the same as transactionId for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols hash is different from transactionId for SegWit transactions.</value>
        [DataMember(Name = "transactionHash", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Represents the virtual size of this transaction.
        /// </summary>
        /// <value>Represents the virtual size of this transaction.</value>
        [DataMember(Name = "vSize", IsRequired = true, EmitDefaultValue = false)]
        public int VSize { get; set; }

        /// <summary>
        /// Represents transaction version number.
        /// </summary>
        /// <value>Represents transaction version number.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Represents the transaction inputs.
        /// </summary>
        /// <value>Represents the transaction inputs.</value>
        [DataMember(Name = "vin", IsRequired = true, EmitDefaultValue = false)]
        public List<DecodeRawTransactionHexRISDVinInner> Vin { get; set; }

        /// <summary>
        /// Represents the transaction outputs.
        /// </summary>
        /// <value>Represents the transaction outputs.</value>
        [DataMember(Name = "vout", IsRequired = true, EmitDefaultValue = false)]
        public List<DecodeRawTransactionHexRISDVoutInner> Vout { get; set; }

        /// <summary>
        /// Represents the size of a block, measured in weight units and including the segwit discount.
        /// </summary>
        /// <value>Represents the size of a block, measured in weight units and including the segwit discount.</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public int Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DecodeRawTransactionHexRISD {\n");
            sb.Append("  Locktime: ").Append(Locktime).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  VSize: ").Append(VSize).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Vin: ").Append(Vin).Append("\n");
            sb.Append("  Vout: ").Append(Vout).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as DecodeRawTransactionHexRISD);
        }

        /// <summary>
        /// Returns true if DecodeRawTransactionHexRISD instances are equal
        /// </summary>
        /// <param name="input">Instance of DecodeRawTransactionHexRISD to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecodeRawTransactionHexRISD input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locktime == input.Locktime ||
                    this.Locktime.Equals(input.Locktime)
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.VSize == input.VSize ||
                    this.VSize.Equals(input.VSize)
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
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
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
                hashCode = (hashCode * 59) + this.Locktime.GetHashCode();
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VSize.GetHashCode();
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.Vin != null)
                {
                    hashCode = (hashCode * 59) + this.Vin.GetHashCode();
                }
                if (this.Vout != null)
                {
                    hashCode = (hashCode * 59) + this.Vout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
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
