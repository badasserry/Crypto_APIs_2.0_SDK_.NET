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
    /// GetBlockDetailsByBlockHeightRI
    /// </summary>
    [DataContract(Name = "GetBlockDetailsByBlockHeightRI")]
    public partial class GetBlockDetailsByBlockHeightRI : IEquatable<GetBlockDetailsByBlockHeightRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHeightRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetBlockDetailsByBlockHeightRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHeightRI" /> class.
        /// </summary>
        /// <param name="hash">Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. (required).</param>
        /// <param name="height">Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. (required).</param>
        /// <param name="nextBlockHash">Represents the hash of the next block. When this is the last block of the blockchain this value will be an empty string. (required).</param>
        /// <param name="previousBlockHash">Represents the hash of the previous block, also known as the parent block. (required).</param>
        /// <param name="timestamp">Defines the exact date/time when this block was mined in Unix (required).</param>
        /// <param name="transactionsCount">Represents the total number of all transactions as part of this block. (required).</param>
        /// <param name="blockchainSpecific">blockchainSpecific (required).</param>
        public GetBlockDetailsByBlockHeightRI(string hash = default(string), int height = default(int), string nextBlockHash = default(string), string previousBlockHash = default(string), int timestamp = default(int), int transactionsCount = default(int), GetBlockDetailsByBlockHeightRIBS blockchainSpecific = default(GetBlockDetailsByBlockHeightRIBS))
        {
            // to ensure "hash" is required (not null)
            if (hash == null) {
                throw new ArgumentNullException("hash is a required property for GetBlockDetailsByBlockHeightRI and cannot be null");
            }
            this.Hash = hash;
            this.Height = height;
            // to ensure "nextBlockHash" is required (not null)
            if (nextBlockHash == null) {
                throw new ArgumentNullException("nextBlockHash is a required property for GetBlockDetailsByBlockHeightRI and cannot be null");
            }
            this.NextBlockHash = nextBlockHash;
            // to ensure "previousBlockHash" is required (not null)
            if (previousBlockHash == null) {
                throw new ArgumentNullException("previousBlockHash is a required property for GetBlockDetailsByBlockHeightRI and cannot be null");
            }
            this.PreviousBlockHash = previousBlockHash;
            this.Timestamp = timestamp;
            this.TransactionsCount = transactionsCount;
            // to ensure "blockchainSpecific" is required (not null)
            if (blockchainSpecific == null) {
                throw new ArgumentNullException("blockchainSpecific is a required property for GetBlockDetailsByBlockHeightRI and cannot be null");
            }
            this.BlockchainSpecific = blockchainSpecific;
        }

        /// <summary>
        /// Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
        /// </summary>
        /// <value>Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.</value>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;.
        /// </summary>
        /// <value>Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;.</value>
        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Represents the hash of the next block. When this is the last block of the blockchain this value will be an empty string.
        /// </summary>
        /// <value>Represents the hash of the next block. When this is the last block of the blockchain this value will be an empty string.</value>
        [DataMember(Name = "nextBlockHash", IsRequired = true, EmitDefaultValue = false)]
        public string NextBlockHash { get; set; }

        /// <summary>
        /// Represents the hash of the previous block, also known as the parent block.
        /// </summary>
        /// <value>Represents the hash of the previous block, also known as the parent block.</value>
        [DataMember(Name = "previousBlockHash", IsRequired = true, EmitDefaultValue = false)]
        public string PreviousBlockHash { get; set; }

        /// <summary>
        /// Defines the exact date/time when this block was mined in Unix
        /// </summary>
        /// <value>Defines the exact date/time when this block was mined in Unix</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Represents the total number of all transactions as part of this block.
        /// </summary>
        /// <value>Represents the total number of all transactions as part of this block.</value>
        [DataMember(Name = "transactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int TransactionsCount { get; set; }

        /// <summary>
        /// Gets or Sets BlockchainSpecific
        /// </summary>
        [DataMember(Name = "blockchainSpecific", IsRequired = true, EmitDefaultValue = false)]
        public GetBlockDetailsByBlockHeightRIBS BlockchainSpecific { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBlockDetailsByBlockHeightRI {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  NextBlockHash: ").Append(NextBlockHash).Append("\n");
            sb.Append("  PreviousBlockHash: ").Append(PreviousBlockHash).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionsCount: ").Append(TransactionsCount).Append("\n");
            sb.Append("  BlockchainSpecific: ").Append(BlockchainSpecific).Append("\n");
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
            return this.Equals(input as GetBlockDetailsByBlockHeightRI);
        }

        /// <summary>
        /// Returns true if GetBlockDetailsByBlockHeightRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockDetailsByBlockHeightRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockDetailsByBlockHeightRI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.NextBlockHash == input.NextBlockHash ||
                    (this.NextBlockHash != null &&
                    this.NextBlockHash.Equals(input.NextBlockHash))
                ) && 
                (
                    this.PreviousBlockHash == input.PreviousBlockHash ||
                    (this.PreviousBlockHash != null &&
                    this.PreviousBlockHash.Equals(input.PreviousBlockHash))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.TransactionsCount == input.TransactionsCount ||
                    this.TransactionsCount.Equals(input.TransactionsCount)
                ) && 
                (
                    this.BlockchainSpecific == input.BlockchainSpecific ||
                    (this.BlockchainSpecific != null &&
                    this.BlockchainSpecific.Equals(input.BlockchainSpecific))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.NextBlockHash != null)
                    hashCode = hashCode * 59 + this.NextBlockHash.GetHashCode();
                if (this.PreviousBlockHash != null)
                    hashCode = hashCode * 59 + this.PreviousBlockHash.GetHashCode();
                hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionsCount.GetHashCode();
                if (this.BlockchainSpecific != null)
                    hashCode = hashCode * 59 + this.BlockchainSpecific.GetHashCode();
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
