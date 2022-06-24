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
    /// ListWalletTransactionsRIFungibleTokensInner
    /// </summary>
    [DataContract(Name = "ListWalletTransactionsRI_fungibleTokens_inner")]
    public partial class ListWalletTransactionsRIFungibleTokensInner : IEquatable<ListWalletTransactionsRIFungibleTokensInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRIFungibleTokensInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListWalletTransactionsRIFungibleTokensInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRIFungibleTokensInner" /> class.
        /// </summary>
        /// <param name="amount">Defines the amount of the fungible tokens. (required).</param>
        /// <param name="convertedAmount">Defines the tokens&#39; converted amount value. (required).</param>
        /// <param name="exchangeRateUnit">Represents token&#39;s exchange rate unit. (required).</param>
        /// <param name="name">Defines the token&#39;s name as a string. (required).</param>
        /// <param name="recipient">The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one (required).</param>
        /// <param name="sender">Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender. (required).</param>
        /// <param name="symbol">Defines the symbol of the fungible tokens. (required).</param>
        /// <param name="tokenDecimals">Defines the decimals of the token, i.e. the number of digits that come after the decimal coma of the token. (required).</param>
        /// <param name="type">Defines the specific token type. (required).</param>
        public ListWalletTransactionsRIFungibleTokensInner(string amount = default(string), string convertedAmount = default(string), string exchangeRateUnit = default(string), string name = default(string), string recipient = default(string), string sender = default(string), string symbol = default(string), int tokenDecimals = default(int), string type = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.Amount = amount;
            // to ensure "convertedAmount" is required (not null)
            if (convertedAmount == null)
            {
                throw new ArgumentNullException("convertedAmount is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.ConvertedAmount = convertedAmount;
            // to ensure "exchangeRateUnit" is required (not null)
            if (exchangeRateUnit == null)
            {
                throw new ArgumentNullException("exchangeRateUnit is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.ExchangeRateUnit = exchangeRateUnit;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.Name = name;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.Sender = sender;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.Symbol = symbol;
            this.TokenDecimals = tokenDecimals;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ListWalletTransactionsRIFungibleTokensInner and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Defines the amount of the fungible tokens.
        /// </summary>
        /// <value>Defines the amount of the fungible tokens.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines the tokens&#39; converted amount value.
        /// </summary>
        /// <value>Defines the tokens&#39; converted amount value.</value>
        [DataMember(Name = "convertedAmount", IsRequired = true, EmitDefaultValue = false)]
        public string ConvertedAmount { get; set; }

        /// <summary>
        /// Represents token&#39;s exchange rate unit.
        /// </summary>
        /// <value>Represents token&#39;s exchange rate unit.</value>
        [DataMember(Name = "exchangeRateUnit", IsRequired = true, EmitDefaultValue = false)]
        public string ExchangeRateUnit { get; set; }

        /// <summary>
        /// Defines the token&#39;s name as a string.
        /// </summary>
        /// <value>Defines the token&#39;s name as a string.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one
        /// </summary>
        /// <value>The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender.
        /// </summary>
        /// <value>Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender.</value>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// Defines the symbol of the fungible tokens.
        /// </summary>
        /// <value>Defines the symbol of the fungible tokens.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Defines the decimals of the token, i.e. the number of digits that come after the decimal coma of the token.
        /// </summary>
        /// <value>Defines the decimals of the token, i.e. the number of digits that come after the decimal coma of the token.</value>
        [DataMember(Name = "tokenDecimals", IsRequired = true, EmitDefaultValue = false)]
        public int TokenDecimals { get; set; }

        /// <summary>
        /// Defines the specific token type.
        /// </summary>
        /// <value>Defines the specific token type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListWalletTransactionsRIFungibleTokensInner {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ConvertedAmount: ").Append(ConvertedAmount).Append("\n");
            sb.Append("  ExchangeRateUnit: ").Append(ExchangeRateUnit).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TokenDecimals: ").Append(TokenDecimals).Append("\n");
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
            return this.Equals(input as ListWalletTransactionsRIFungibleTokensInner);
        }

        /// <summary>
        /// Returns true if ListWalletTransactionsRIFungibleTokensInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ListWalletTransactionsRIFungibleTokensInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListWalletTransactionsRIFungibleTokensInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ConvertedAmount == input.ConvertedAmount ||
                    (this.ConvertedAmount != null &&
                    this.ConvertedAmount.Equals(input.ConvertedAmount))
                ) && 
                (
                    this.ExchangeRateUnit == input.ExchangeRateUnit ||
                    (this.ExchangeRateUnit != null &&
                    this.ExchangeRateUnit.Equals(input.ExchangeRateUnit))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.TokenDecimals == input.TokenDecimals ||
                    this.TokenDecimals.Equals(input.TokenDecimals)
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ConvertedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ConvertedAmount.GetHashCode();
                }
                if (this.ExchangeRateUnit != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeRateUnit.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenDecimals.GetHashCode();
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
