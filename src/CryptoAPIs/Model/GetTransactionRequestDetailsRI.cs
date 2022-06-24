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
    /// GetTransactionRequestDetailsRI
    /// </summary>
    [DataContract(Name = "GetTransactionRequestDetailsRI")]
    public partial class GetTransactionRequestDetailsRI : IEquatable<GetTransactionRequestDetailsRI>, IValidatableObject
    {
        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlockchainEnum
        {
            /// <summary>
            /// Enum Bitcoin for value: bitcoin
            /// </summary>
            [EnumMember(Value = "bitcoin")]
            Bitcoin = 1,

            /// <summary>
            /// Enum BitcoinCash for value: bitcoin-cash
            /// </summary>
            [EnumMember(Value = "bitcoin-cash")]
            BitcoinCash = 2,

            /// <summary>
            /// Enum Litecoin for value: litecoin
            /// </summary>
            [EnumMember(Value = "litecoin")]
            Litecoin = 3,

            /// <summary>
            /// Enum Dogecoin for value: dogecoin
            /// </summary>
            [EnumMember(Value = "dogecoin")]
            Dogecoin = 4,

            /// <summary>
            /// Enum Dash for value: dash
            /// </summary>
            [EnumMember(Value = "dash")]
            Dash = 5,

            /// <summary>
            /// Enum Ethereum for value: ethereum
            /// </summary>
            [EnumMember(Value = "ethereum")]
            Ethereum = 6,

            /// <summary>
            /// Enum EthereumClassic for value: ethereum-classic
            /// </summary>
            [EnumMember(Value = "ethereum-classic")]
            EthereumClassic = 7,

            /// <summary>
            /// Enum Xrp for value: xrp
            /// </summary>
            [EnumMember(Value = "xrp")]
            Xrp = 8,

            /// <summary>
            /// Enum Zcash for value: zcash
            /// </summary>
            [EnumMember(Value = "zcash")]
            Zcash = 9

        }


        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public BlockchainEnum Blockchain { get; set; }
        /// <summary>
        /// Defines the priority for the fee, if it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Defines the priority for the fee, if it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeePriorityEnum
        {
            /// <summary>
            /// Enum Slow for value: slow
            /// </summary>
            [EnumMember(Value = "slow")]
            Slow = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2,

            /// <summary>
            /// Enum Fast for value: fast
            /// </summary>
            [EnumMember(Value = "fast")]
            Fast = 3

        }


        /// <summary>
        /// Defines the priority for the fee, if it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Defines the priority for the fee, if it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
        [DataMember(Name = "feePriority", IsRequired = true, EmitDefaultValue = false)]
        public FeePriorityEnum FeePriority { get; set; }
        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkEnum
        {
            /// <summary>
            /// Enum Mainnet for value: mainnet
            /// </summary>
            [EnumMember(Value = "mainnet")]
            Mainnet = 1,

            /// <summary>
            /// Enum Testnet for value: testnet
            /// </summary>
            [EnumMember(Value = "testnet")]
            Testnet = 2,

            /// <summary>
            /// Enum Ropsten for value: ropsten
            /// </summary>
            [EnumMember(Value = "ropsten")]
            Ropsten = 3,

            /// <summary>
            /// Enum Mordor for value: mordor
            /// </summary>
            [EnumMember(Value = "mordor")]
            Mordor = 4

        }


        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public NetworkEnum Network { get; set; }
        /// <summary>
        /// Defines the status of the transaction request, e.g. pending.
        /// </summary>
        /// <value>Defines the status of the transaction request, e.g. pending.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionRequestStatusEnum
        {
            /// <summary>
            /// Enum Created for value: created
            /// </summary>
            [EnumMember(Value = "created")]
            Created = 1,

            /// <summary>
            /// Enum AwaitApproval for value: await-approval
            /// </summary>
            [EnumMember(Value = "await-approval")]
            AwaitApproval = 2,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 3,

            /// <summary>
            /// Enum Prepared for value: prepared
            /// </summary>
            [EnumMember(Value = "prepared")]
            Prepared = 4,

            /// <summary>
            /// Enum Signed for value: signed
            /// </summary>
            [EnumMember(Value = "signed")]
            Signed = 5,

            /// <summary>
            /// Enum Broadcasted for value: broadcasted
            /// </summary>
            [EnumMember(Value = "broadcasted")]
            Broadcasted = 6,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 7,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 8,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 9,

            /// <summary>
            /// Enum Mined for value: mined
            /// </summary>
            [EnumMember(Value = "mined")]
            Mined = 10

        }


        /// <summary>
        /// Defines the status of the transaction request, e.g. pending.
        /// </summary>
        /// <value>Defines the status of the transaction request, e.g. pending.</value>
        [DataMember(Name = "transactionRequestStatus", IsRequired = true, EmitDefaultValue = false)]
        public TransactionRequestStatusEnum TransactionRequestStatus { get; set; }
        /// <summary>
        /// Defines the transaction type, if it is for coins or tokens.
        /// </summary>
        /// <value>Defines the transaction type, if it is for coins or tokens.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionTypeEnum
        {
            /// <summary>
            /// Enum Coin for value: coin
            /// </summary>
            [EnumMember(Value = "coin")]
            Coin = 1,

            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 2

        }


        /// <summary>
        /// Defines the transaction type, if it is for coins or tokens.
        /// </summary>
        /// <value>Defines the transaction type, if it is for coins or tokens.</value>
        [DataMember(Name = "transactionType", IsRequired = true, EmitDefaultValue = false)]
        public TransactionTypeEnum TransactionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionRequestDetailsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionRequestDetailsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionRequestDetailsRI" /> class.
        /// </summary>
        /// <param name="additionalDetails">Defines an optional note for additional details. (required).</param>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="feePriority">Defines the priority for the fee, if it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. (required).</param>
        /// <param name="recipients">Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. (required).</param>
        /// <param name="totalTransactionAmount">Defines the total transaction amount. (required).</param>
        /// <param name="transactionId">Represents the unique identifier of a transaction, i.e. it could be transactionId in UTXO-based protocols like Bitcoin, and transaction hash in Ethereum blockchain..</param>
        /// <param name="transactionRequestStatus">Defines the status of the transaction request, e.g. pending. (required).</param>
        /// <param name="transactionType">Defines the transaction type, if it is for coins or tokens. (required).</param>
        /// <param name="unit">Defines the unit of the amount. (required).</param>
        /// <param name="walletId">Defines the unique ID of the Wallet. (required).</param>
        public GetTransactionRequestDetailsRI(string additionalDetails = default(string), BlockchainEnum blockchain = default(BlockchainEnum), FeePriorityEnum feePriority = default(FeePriorityEnum), NetworkEnum network = default(NetworkEnum), List<GetTransactionRequestDetailsRIRecipientsInner> recipients = default(List<GetTransactionRequestDetailsRIRecipientsInner>), string totalTransactionAmount = default(string), string transactionId = default(string), TransactionRequestStatusEnum transactionRequestStatus = default(TransactionRequestStatusEnum), TransactionTypeEnum transactionType = default(TransactionTypeEnum), string unit = default(string), string walletId = default(string))
        {
            // to ensure "additionalDetails" is required (not null)
            if (additionalDetails == null)
            {
                throw new ArgumentNullException("additionalDetails is a required property for GetTransactionRequestDetailsRI and cannot be null");
            }
            this.AdditionalDetails = additionalDetails;
            this.Blockchain = blockchain;
            this.FeePriority = feePriority;
            this.Network = network;
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients is a required property for GetTransactionRequestDetailsRI and cannot be null");
            }
            this.Recipients = recipients;
            // to ensure "totalTransactionAmount" is required (not null)
            if (totalTransactionAmount == null)
            {
                throw new ArgumentNullException("totalTransactionAmount is a required property for GetTransactionRequestDetailsRI and cannot be null");
            }
            this.TotalTransactionAmount = totalTransactionAmount;
            this.TransactionRequestStatus = transactionRequestStatus;
            this.TransactionType = transactionType;
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new ArgumentNullException("unit is a required property for GetTransactionRequestDetailsRI and cannot be null");
            }
            this.Unit = unit;
            // to ensure "walletId" is required (not null)
            if (walletId == null)
            {
                throw new ArgumentNullException("walletId is a required property for GetTransactionRequestDetailsRI and cannot be null");
            }
            this.WalletId = walletId;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Defines an optional note for additional details.
        /// </summary>
        /// <value>Defines an optional note for additional details.</value>
        [DataMember(Name = "additionalDetails", IsRequired = true, EmitDefaultValue = false)]
        public string AdditionalDetails { get; set; }

        /// <summary>
        /// Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.
        /// </summary>
        /// <value>Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionRequestDetailsRIRecipientsInner> Recipients { get; set; }

        /// <summary>
        /// Defines the total transaction amount.
        /// </summary>
        /// <value>Defines the total transaction amount.</value>
        [DataMember(Name = "totalTransactionAmount", IsRequired = true, EmitDefaultValue = false)]
        public string TotalTransactionAmount { get; set; }

        /// <summary>
        /// Represents the unique identifier of a transaction, i.e. it could be transactionId in UTXO-based protocols like Bitcoin, and transaction hash in Ethereum blockchain.
        /// </summary>
        /// <value>Represents the unique identifier of a transaction, i.e. it could be transactionId in UTXO-based protocols like Bitcoin, and transaction hash in Ethereum blockchain.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Defines the unit of the amount.
        /// </summary>
        /// <value>Defines the unit of the amount.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Defines the unique ID of the Wallet.
        /// </summary>
        /// <value>Defines the unique ID of the Wallet.</value>
        [DataMember(Name = "walletId", IsRequired = true, EmitDefaultValue = false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionRequestDetailsRI {\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  FeePriority: ").Append(FeePriority).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  TotalTransactionAmount: ").Append(TotalTransactionAmount).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionRequestStatus: ").Append(TransactionRequestStatus).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
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
            return this.Equals(input as GetTransactionRequestDetailsRI);
        }

        /// <summary>
        /// Returns true if GetTransactionRequestDetailsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionRequestDetailsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionRequestDetailsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalDetails == input.AdditionalDetails ||
                    (this.AdditionalDetails != null &&
                    this.AdditionalDetails.Equals(input.AdditionalDetails))
                ) && 
                (
                    this.Blockchain == input.Blockchain ||
                    this.Blockchain.Equals(input.Blockchain)
                ) && 
                (
                    this.FeePriority == input.FeePriority ||
                    this.FeePriority.Equals(input.FeePriority)
                ) && 
                (
                    this.Network == input.Network ||
                    this.Network.Equals(input.Network)
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.TotalTransactionAmount == input.TotalTransactionAmount ||
                    (this.TotalTransactionAmount != null &&
                    this.TotalTransactionAmount.Equals(input.TotalTransactionAmount))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TransactionRequestStatus == input.TransactionRequestStatus ||
                    this.TransactionRequestStatus.Equals(input.TransactionRequestStatus)
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    this.TransactionType.Equals(input.TransactionType)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
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
                if (this.AdditionalDetails != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalDetails.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Blockchain.GetHashCode();
                hashCode = (hashCode * 59) + this.FeePriority.GetHashCode();
                hashCode = (hashCode * 59) + this.Network.GetHashCode();
                if (this.Recipients != null)
                {
                    hashCode = (hashCode * 59) + this.Recipients.GetHashCode();
                }
                if (this.TotalTransactionAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTransactionAmount.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransactionRequestStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.TransactionType.GetHashCode();
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                if (this.WalletId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletId.GetHashCode();
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
