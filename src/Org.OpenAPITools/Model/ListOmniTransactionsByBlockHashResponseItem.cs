/*
 * Crypto APIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: bizdev@cryptoapis.io
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ListOmniTransactionsByBlockHashResponseItem
    /// </summary>
    [DataContract(Name = "ListOmniTransactionsByBlockHashResponseItem")]
    public partial class ListOmniTransactionsByBlockHashResponseItem : IEquatable<ListOmniTransactionsByBlockHashResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOmniTransactionsByBlockHashResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListOmniTransactionsByBlockHashResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOmniTransactionsByBlockHashResponseItem" /> class.
        /// </summary>
        /// <param name="amount">Defines the amount of the sent tokens. (required).</param>
        /// <param name="divisible">Defines whether the attribute can be divisible or not, as boolean. E.g., if it is \&quot;true\&quot;, the attribute is divisible. (required).</param>
        /// <param name="minedInBlockHash">Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. (required).</param>
        /// <param name="minedInBlockHeight">Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block. (required).</param>
        /// <param name="positionInBlock">Represents the index position of the transaction in the specific block. (required).</param>
        /// <param name="propertyId">Represents the identifier of the tokens to send. (required).</param>
        /// <param name="recipients">Represents an object of addresses that receive the transactions. (required).</param>
        /// <param name="senders">Represents an object of addresses that provide the funds. (required).</param>
        /// <param name="timestamp">Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. (required).</param>
        /// <param name="transactionId">Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain. (required).</param>
        /// <param name="type">Defines the type of the transaction as a string. (required).</param>
        /// <param name="typeInt">Defines the type of the transaction as a number. (required).</param>
        /// <param name="valid">Defines whether the transaction is valid or not, as boolean. E.g., if it is \&quot;true\&quot;, the transaction is valid. (required).</param>
        /// <param name="version">Defines the specific version. (required).</param>
        /// <param name="fee">fee (required).</param>
        public ListOmniTransactionsByBlockHashResponseItem(string amount = default(string), bool divisible = default(bool), string minedInBlockHash = default(string), int minedInBlockHeight = default(int), int positionInBlock = default(int), int propertyId = default(int), List<ListOmniTransactionsByAddressResponseItemRecipients> recipients = default(List<ListOmniTransactionsByAddressResponseItemRecipients>), List<ListOmniTransactionsByAddressResponseItemSenders> senders = default(List<ListOmniTransactionsByAddressResponseItemSenders>), int timestamp = default(int), string transactionId = default(string), string type = default(string), int typeInt = default(int), bool valid = default(bool), int version = default(int), ListOmniTransactionsByBlockHashResponseItemFee fee = default(ListOmniTransactionsByBlockHashResponseItemFee))
        {
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount is a required property for ListOmniTransactionsByBlockHashResponseItem and cannot be null");
            this.Divisible = divisible;
            // to ensure "minedInBlockHash" is required (not null)
            this.MinedInBlockHash = minedInBlockHash ?? throw new ArgumentNullException("minedInBlockHash is a required property for ListOmniTransactionsByBlockHashResponseItem and cannot be null");
            this.MinedInBlockHeight = minedInBlockHeight;
            this.PositionInBlock = positionInBlock;
            this.PropertyId = propertyId;
            // to ensure "recipients" is required (not null)
            this.Recipients = recipients ?? throw new ArgumentNullException("recipients is a required property for ListOmniTransactionsByBlockHashResponseItem and cannot be null");
            // to ensure "senders" is required (not null)
            this.Senders = senders ?? throw new ArgumentNullException("senders is a required property for ListOmniTransactionsByBlockHashResponseItem and cannot be null");
            this.Timestamp = timestamp;
            // to ensure "transactionId" is required (not null)
            this.TransactionId = transactionId ?? throw new ArgumentNullException("transactionId is a required property for ListOmniTransactionsByBlockHashResponseItem and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ListOmniTransactionsByBlockHashResponseItem and cannot be null");
            this.TypeInt = typeInt;
            this.Valid = valid;
            this.Version = version;
            // to ensure "fee" is required (not null)
            this.Fee = fee ?? throw new ArgumentNullException("fee is a required property for ListOmniTransactionsByBlockHashResponseItem and cannot be null");
        }

        /// <summary>
        /// Defines the amount of the sent tokens.
        /// </summary>
        /// <value>Defines the amount of the sent tokens.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines whether the attribute can be divisible or not, as boolean. E.g., if it is \&quot;true\&quot;, the attribute is divisible.
        /// </summary>
        /// <value>Defines whether the attribute can be divisible or not, as boolean. E.g., if it is \&quot;true\&quot;, the attribute is divisible.</value>
        [DataMember(Name = "divisible", IsRequired = true, EmitDefaultValue = true)]
        public bool Divisible { get; set; }

        /// <summary>
        /// Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
        /// </summary>
        /// <value>Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.</value>
        [DataMember(Name = "minedInBlockHash", IsRequired = true, EmitDefaultValue = false)]
        public string MinedInBlockHash { get; set; }

        /// <summary>
        /// Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.
        /// </summary>
        /// <value>Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.</value>
        [DataMember(Name = "minedInBlockHeight", IsRequired = true, EmitDefaultValue = false)]
        public int MinedInBlockHeight { get; set; }

        /// <summary>
        /// Represents the index position of the transaction in the specific block.
        /// </summary>
        /// <value>Represents the index position of the transaction in the specific block.</value>
        [DataMember(Name = "positionInBlock", IsRequired = true, EmitDefaultValue = false)]
        public int PositionInBlock { get; set; }

        /// <summary>
        /// Represents the identifier of the tokens to send.
        /// </summary>
        /// <value>Represents the identifier of the tokens to send.</value>
        [DataMember(Name = "propertyId", IsRequired = true, EmitDefaultValue = false)]
        public int PropertyId { get; set; }

        /// <summary>
        /// Represents an object of addresses that receive the transactions.
        /// </summary>
        /// <value>Represents an object of addresses that receive the transactions.</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<ListOmniTransactionsByAddressResponseItemRecipients> Recipients { get; set; }

        /// <summary>
        /// Represents an object of addresses that provide the funds.
        /// </summary>
        /// <value>Represents an object of addresses that provide the funds.</value>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public List<ListOmniTransactionsByAddressResponseItemSenders> Senders { get; set; }

        /// <summary>
        /// Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.
        /// </summary>
        /// <value>Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain.
        /// </summary>
        /// <value>Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Defines the type of the transaction as a string.
        /// </summary>
        /// <value>Defines the type of the transaction as a string.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Defines the type of the transaction as a number.
        /// </summary>
        /// <value>Defines the type of the transaction as a number.</value>
        [DataMember(Name = "typeInt", IsRequired = true, EmitDefaultValue = false)]
        public int TypeInt { get; set; }

        /// <summary>
        /// Defines whether the transaction is valid or not, as boolean. E.g., if it is \&quot;true\&quot;, the transaction is valid.
        /// </summary>
        /// <value>Defines whether the transaction is valid or not, as boolean. E.g., if it is \&quot;true\&quot;, the transaction is valid.</value>
        [DataMember(Name = "valid", IsRequired = true, EmitDefaultValue = true)]
        public bool Valid { get; set; }

        /// <summary>
        /// Defines the specific version.
        /// </summary>
        /// <value>Defines the specific version.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int Version { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = false)]
        public ListOmniTransactionsByBlockHashResponseItemFee Fee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOmniTransactionsByBlockHashResponseItem {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Divisible: ").Append(Divisible).Append("\n");
            sb.Append("  MinedInBlockHash: ").Append(MinedInBlockHash).Append("\n");
            sb.Append("  MinedInBlockHeight: ").Append(MinedInBlockHeight).Append("\n");
            sb.Append("  PositionInBlock: ").Append(PositionInBlock).Append("\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeInt: ").Append(TypeInt).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
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
            return this.Equals(input as ListOmniTransactionsByBlockHashResponseItem);
        }

        /// <summary>
        /// Returns true if ListOmniTransactionsByBlockHashResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOmniTransactionsByBlockHashResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOmniTransactionsByBlockHashResponseItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Divisible == input.Divisible ||
                    this.Divisible.Equals(input.Divisible)
                ) && 
                (
                    this.MinedInBlockHash == input.MinedInBlockHash ||
                    (this.MinedInBlockHash != null &&
                    this.MinedInBlockHash.Equals(input.MinedInBlockHash))
                ) && 
                (
                    this.MinedInBlockHeight == input.MinedInBlockHeight ||
                    this.MinedInBlockHeight.Equals(input.MinedInBlockHeight)
                ) && 
                (
                    this.PositionInBlock == input.PositionInBlock ||
                    this.PositionInBlock.Equals(input.PositionInBlock)
                ) && 
                (
                    this.PropertyId == input.PropertyId ||
                    this.PropertyId.Equals(input.PropertyId)
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Senders == input.Senders ||
                    this.Senders != null &&
                    input.Senders != null &&
                    this.Senders.SequenceEqual(input.Senders)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TypeInt == input.TypeInt ||
                    this.TypeInt.Equals(input.TypeInt)
                ) && 
                (
                    this.Valid == input.Valid ||
                    this.Valid.Equals(input.Valid)
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Divisible.GetHashCode();
                if (this.MinedInBlockHash != null)
                    hashCode = hashCode * 59 + this.MinedInBlockHash.GetHashCode();
                hashCode = hashCode * 59 + this.MinedInBlockHeight.GetHashCode();
                hashCode = hashCode * 59 + this.PositionInBlock.GetHashCode();
                hashCode = hashCode * 59 + this.PropertyId.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Senders != null)
                    hashCode = hashCode * 59 + this.Senders.GetHashCode();
                hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.TypeInt.GetHashCode();
                hashCode = hashCode * 59 + this.Valid.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
