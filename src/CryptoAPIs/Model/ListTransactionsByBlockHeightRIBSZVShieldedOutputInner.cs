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
    /// ListTransactionsByBlockHeightRIBSZVShieldedOutputInner
    /// </summary>
    [DataContract(Name = "ListTransactionsByBlockHeightRIBSZ_vShieldedOutput_inner")]
    public partial class ListTransactionsByBlockHeightRIBSZVShieldedOutputInner : IEquatable<ListTransactionsByBlockHeightRIBSZVShieldedOutputInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBSZVShieldedOutputInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListTransactionsByBlockHeightRIBSZVShieldedOutputInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBSZVShieldedOutputInner" /> class.
        /// </summary>
        /// <param name="cmu">Represents the 𝑢-coordinate of the note commitment for the output note. (required).</param>
        /// <param name="cv">Defines a value commitment to the value of the input note. (required).</param>
        /// <param name="encCipherText">Represents a ciphertext component for the encrypted output note. (required).</param>
        /// <param name="ephemeralKey">Represents an encoding of an ephemeral Jubjub public key. (required).</param>
        /// <param name="outCipherText">Represents a ciphertext component that allows the holder of the outgoing cipher key to recover the diversified transmission key pkd and ephemeral private key esk, hence the entire note plaintext. (required).</param>
        /// <param name="proof">Represents the proof (required).</param>
        public ListTransactionsByBlockHeightRIBSZVShieldedOutputInner(string cmu = default(string), string cv = default(string), string encCipherText = default(string), string ephemeralKey = default(string), string outCipherText = default(string), string proof = default(string))
        {
            // to ensure "cmu" is required (not null)
            if (cmu == null)
            {
                throw new ArgumentNullException("cmu is a required property for ListTransactionsByBlockHeightRIBSZVShieldedOutputInner and cannot be null");
            }
            this.Cmu = cmu;
            // to ensure "cv" is required (not null)
            if (cv == null)
            {
                throw new ArgumentNullException("cv is a required property for ListTransactionsByBlockHeightRIBSZVShieldedOutputInner and cannot be null");
            }
            this.Cv = cv;
            // to ensure "encCipherText" is required (not null)
            if (encCipherText == null)
            {
                throw new ArgumentNullException("encCipherText is a required property for ListTransactionsByBlockHeightRIBSZVShieldedOutputInner and cannot be null");
            }
            this.EncCipherText = encCipherText;
            // to ensure "ephemeralKey" is required (not null)
            if (ephemeralKey == null)
            {
                throw new ArgumentNullException("ephemeralKey is a required property for ListTransactionsByBlockHeightRIBSZVShieldedOutputInner and cannot be null");
            }
            this.EphemeralKey = ephemeralKey;
            // to ensure "outCipherText" is required (not null)
            if (outCipherText == null)
            {
                throw new ArgumentNullException("outCipherText is a required property for ListTransactionsByBlockHeightRIBSZVShieldedOutputInner and cannot be null");
            }
            this.OutCipherText = outCipherText;
            // to ensure "proof" is required (not null)
            if (proof == null)
            {
                throw new ArgumentNullException("proof is a required property for ListTransactionsByBlockHeightRIBSZVShieldedOutputInner and cannot be null");
            }
            this.Proof = proof;
        }

        /// <summary>
        /// Represents the 𝑢-coordinate of the note commitment for the output note.
        /// </summary>
        /// <value>Represents the 𝑢-coordinate of the note commitment for the output note.</value>
        [DataMember(Name = "cmu", IsRequired = true, EmitDefaultValue = false)]
        public string Cmu { get; set; }

        /// <summary>
        /// Defines a value commitment to the value of the input note.
        /// </summary>
        /// <value>Defines a value commitment to the value of the input note.</value>
        [DataMember(Name = "cv", IsRequired = true, EmitDefaultValue = false)]
        public string Cv { get; set; }

        /// <summary>
        /// Represents a ciphertext component for the encrypted output note.
        /// </summary>
        /// <value>Represents a ciphertext component for the encrypted output note.</value>
        [DataMember(Name = "encCipherText", IsRequired = true, EmitDefaultValue = false)]
        public string EncCipherText { get; set; }

        /// <summary>
        /// Represents an encoding of an ephemeral Jubjub public key.
        /// </summary>
        /// <value>Represents an encoding of an ephemeral Jubjub public key.</value>
        [DataMember(Name = "ephemeralKey", IsRequired = true, EmitDefaultValue = false)]
        public string EphemeralKey { get; set; }

        /// <summary>
        /// Represents a ciphertext component that allows the holder of the outgoing cipher key to recover the diversified transmission key pkd and ephemeral private key esk, hence the entire note plaintext.
        /// </summary>
        /// <value>Represents a ciphertext component that allows the holder of the outgoing cipher key to recover the diversified transmission key pkd and ephemeral private key esk, hence the entire note plaintext.</value>
        [DataMember(Name = "outCipherText", IsRequired = true, EmitDefaultValue = false)]
        public string OutCipherText { get; set; }

        /// <summary>
        /// Represents the proof
        /// </summary>
        /// <value>Represents the proof</value>
        [DataMember(Name = "proof", IsRequired = true, EmitDefaultValue = false)]
        public string Proof { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListTransactionsByBlockHeightRIBSZVShieldedOutputInner {\n");
            sb.Append("  Cmu: ").Append(Cmu).Append("\n");
            sb.Append("  Cv: ").Append(Cv).Append("\n");
            sb.Append("  EncCipherText: ").Append(EncCipherText).Append("\n");
            sb.Append("  EphemeralKey: ").Append(EphemeralKey).Append("\n");
            sb.Append("  OutCipherText: ").Append(OutCipherText).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
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
            return this.Equals(input as ListTransactionsByBlockHeightRIBSZVShieldedOutputInner);
        }

        /// <summary>
        /// Returns true if ListTransactionsByBlockHeightRIBSZVShieldedOutputInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTransactionsByBlockHeightRIBSZVShieldedOutputInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTransactionsByBlockHeightRIBSZVShieldedOutputInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cmu == input.Cmu ||
                    (this.Cmu != null &&
                    this.Cmu.Equals(input.Cmu))
                ) && 
                (
                    this.Cv == input.Cv ||
                    (this.Cv != null &&
                    this.Cv.Equals(input.Cv))
                ) && 
                (
                    this.EncCipherText == input.EncCipherText ||
                    (this.EncCipherText != null &&
                    this.EncCipherText.Equals(input.EncCipherText))
                ) && 
                (
                    this.EphemeralKey == input.EphemeralKey ||
                    (this.EphemeralKey != null &&
                    this.EphemeralKey.Equals(input.EphemeralKey))
                ) && 
                (
                    this.OutCipherText == input.OutCipherText ||
                    (this.OutCipherText != null &&
                    this.OutCipherText.Equals(input.OutCipherText))
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
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
                if (this.Cmu != null)
                {
                    hashCode = (hashCode * 59) + this.Cmu.GetHashCode();
                }
                if (this.Cv != null)
                {
                    hashCode = (hashCode * 59) + this.Cv.GetHashCode();
                }
                if (this.EncCipherText != null)
                {
                    hashCode = (hashCode * 59) + this.EncCipherText.GetHashCode();
                }
                if (this.EphemeralKey != null)
                {
                    hashCode = (hashCode * 59) + this.EphemeralKey.GetHashCode();
                }
                if (this.OutCipherText != null)
                {
                    hashCode = (hashCode * 59) + this.OutCipherText.GetHashCode();
                }
                if (this.Proof != null)
                {
                    hashCode = (hashCode * 59) + this.Proof.GetHashCode();
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
