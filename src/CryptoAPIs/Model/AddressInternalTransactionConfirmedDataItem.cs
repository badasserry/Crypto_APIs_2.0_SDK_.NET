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
    /// Defines an &#x60;item&#x60; as one result.
    /// </summary>
    [DataContract(Name = "AddressInternalTransactionConfirmed_data_item")]
    public partial class AddressInternalTransactionConfirmedDataItem : IEquatable<AddressInternalTransactionConfirmedDataItem>, IValidatableObject
    {
        /// <summary>
        /// Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.
        /// </summary>
        /// <value>Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Incoming for value: incoming
            /// </summary>
            [EnumMember(Value = "incoming")]
            Incoming = 1,

            /// <summary>
            /// Enum Outgoing for value: outgoing
            /// </summary>
            [EnumMember(Value = "outgoing")]
            Outgoing = 2

        }


        /// <summary>
        /// Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.
        /// </summary>
        /// <value>Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.</value>
        [DataMember(Name = "direction", IsRequired = true, EmitDefaultValue = false)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressInternalTransactionConfirmedDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressInternalTransactionConfirmedDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressInternalTransactionConfirmedDataItem" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. (required).</param>
        /// <param name="address">Defines the specific address of the internal transaction. (required).</param>
        /// <param name="minedInBlock">minedInBlock (required).</param>
        /// <param name="parentTransactionId">Defines the Parent Transaction&#39;s unique ID. (required).</param>
        /// <param name="operationId">Defines the specific operation&#39;s unique ID. (required).</param>
        /// <param name="amount">Defines the amount of coins sent with the confirmed transaction. (required).</param>
        /// <param name="unit">Defines the unit of the transaction, e.g. Gwei. (required).</param>
        /// <param name="direction">Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;. (required).</param>
        public AddressInternalTransactionConfirmedDataItem(string blockchain = default(string), string network = default(string), string address = default(string), AddressInternalTransactionConfirmedDataItemMinedInBlock minedInBlock = default(AddressInternalTransactionConfirmedDataItemMinedInBlock), string parentTransactionId = default(string), string operationId = default(string), string amount = default(string), string unit = default(string), DirectionEnum direction = default(DirectionEnum))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null) {
                throw new ArgumentNullException("blockchain is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "network" is required (not null)
            if (network == null) {
                throw new ArgumentNullException("network is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.Network = network;
            // to ensure "address" is required (not null)
            if (address == null) {
                throw new ArgumentNullException("address is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.Address = address;
            // to ensure "minedInBlock" is required (not null)
            if (minedInBlock == null) {
                throw new ArgumentNullException("minedInBlock is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.MinedInBlock = minedInBlock;
            // to ensure "parentTransactionId" is required (not null)
            if (parentTransactionId == null) {
                throw new ArgumentNullException("parentTransactionId is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.ParentTransactionId = parentTransactionId;
            // to ensure "operationId" is required (not null)
            if (operationId == null) {
                throw new ArgumentNullException("operationId is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.OperationId = operationId;
            // to ensure "amount" is required (not null)
            if (amount == null) {
                throw new ArgumentNullException("amount is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.Amount = amount;
            // to ensure "unit" is required (not null)
            if (unit == null) {
                throw new ArgumentNullException("unit is a required property for AddressInternalTransactionConfirmedDataItem and cannot be null");
            }
            this.Unit = unit;
            this.Direction = direction;
        }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Defines the specific address of the internal transaction.
        /// </summary>
        /// <value>Defines the specific address of the internal transaction.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets MinedInBlock
        /// </summary>
        [DataMember(Name = "minedInBlock", IsRequired = true, EmitDefaultValue = false)]
        public AddressInternalTransactionConfirmedDataItemMinedInBlock MinedInBlock { get; set; }

        /// <summary>
        /// Defines the Parent Transaction&#39;s unique ID.
        /// </summary>
        /// <value>Defines the Parent Transaction&#39;s unique ID.</value>
        [DataMember(Name = "parentTransactionId", IsRequired = true, EmitDefaultValue = false)]
        public string ParentTransactionId { get; set; }

        /// <summary>
        /// Defines the specific operation&#39;s unique ID.
        /// </summary>
        /// <value>Defines the specific operation&#39;s unique ID.</value>
        [DataMember(Name = "operationId", IsRequired = true, EmitDefaultValue = false)]
        public string OperationId { get; set; }

        /// <summary>
        /// Defines the amount of coins sent with the confirmed transaction.
        /// </summary>
        /// <value>Defines the amount of coins sent with the confirmed transaction.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines the unit of the transaction, e.g. Gwei.
        /// </summary>
        /// <value>Defines the unit of the transaction, e.g. Gwei.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressInternalTransactionConfirmedDataItem {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  MinedInBlock: ").Append(MinedInBlock).Append("\n");
            sb.Append("  ParentTransactionId: ").Append(ParentTransactionId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as AddressInternalTransactionConfirmedDataItem);
        }

        /// <summary>
        /// Returns true if AddressInternalTransactionConfirmedDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressInternalTransactionConfirmedDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressInternalTransactionConfirmedDataItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.MinedInBlock == input.MinedInBlock ||
                    (this.MinedInBlock != null &&
                    this.MinedInBlock.Equals(input.MinedInBlock))
                ) && 
                (
                    this.ParentTransactionId == input.ParentTransactionId ||
                    (this.ParentTransactionId != null &&
                    this.ParentTransactionId.Equals(input.ParentTransactionId))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                if (this.Blockchain != null)
                {
                    hashCode = (hashCode * 59) + this.Blockchain.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.MinedInBlock != null)
                {
                    hashCode = (hashCode * 59) + this.MinedInBlock.GetHashCode();
                }
                if (this.ParentTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentTransactionId.GetHashCode();
                }
                if (this.OperationId != null)
                {
                    hashCode = (hashCode * 59) + this.OperationId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
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