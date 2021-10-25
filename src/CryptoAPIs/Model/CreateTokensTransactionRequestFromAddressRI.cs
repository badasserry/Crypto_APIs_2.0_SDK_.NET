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
    /// CreateTokensTransactionRequestFromAddressRI
    /// </summary>
    [DataContract(Name = "CreateTokensTransactionRequestFromAddressRI")]
    public partial class CreateTokensTransactionRequestFromAddressRI : IEquatable<CreateTokensTransactionRequestFromAddressRI>, IValidatableObject
    {
        /// <summary>
        /// Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
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
        /// Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
        [DataMember(Name = "feePriority", IsRequired = true, EmitDefaultValue = false)]
        public FeePriorityEnum FeePriority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokensTransactionRequestFromAddressRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTokensTransactionRequestFromAddressRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokensTransactionRequestFromAddressRI" /> class.
        /// </summary>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security). (required).</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. (required).</param>
        /// <param name="feePriority">Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;. (required).</param>
        /// <param name="note">Represents an optional note to add a free text in, explaining or providing additional detail on the transaction request..</param>
        /// <param name="recipients">Defines the destination for the transaction, i.e. the recipient(s). (required).</param>
        /// <param name="senders">senders (required).</param>
        /// <param name="tokenTypeSpecificData">tokenTypeSpecificData (required).</param>
        /// <param name="transactionRequestId">Represents a unique identifier of the transaction request (the request sent to make a transaction), which helps in identifying which callback and which &#x60;referenceId&#x60; concern that specific transaction request. (required).</param>
        public CreateTokensTransactionRequestFromAddressRI(string callbackSecretKey = default(string), string callbackUrl = default(string), FeePriorityEnum feePriority = default(FeePriorityEnum), string note = default(string), List<CreateTokensTransactionRequestFromAddressRIRecipients> recipients = default(List<CreateTokensTransactionRequestFromAddressRIRecipients>), CreateTokensTransactionRequestFromAddressRISenders senders = default(CreateTokensTransactionRequestFromAddressRISenders), CreateTokensTransactionRequestFromAddressRIS tokenTypeSpecificData = default(CreateTokensTransactionRequestFromAddressRIS), string transactionRequestId = default(string))
        {
            // to ensure "callbackSecretKey" is required (not null)
            if (callbackSecretKey == null) {
                throw new ArgumentNullException("callbackSecretKey is a required property for CreateTokensTransactionRequestFromAddressRI and cannot be null");
            }
            this.CallbackSecretKey = callbackSecretKey;
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null) {
                throw new ArgumentNullException("callbackUrl is a required property for CreateTokensTransactionRequestFromAddressRI and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            this.FeePriority = feePriority;
            // to ensure "recipients" is required (not null)
            if (recipients == null) {
                throw new ArgumentNullException("recipients is a required property for CreateTokensTransactionRequestFromAddressRI and cannot be null");
            }
            this.Recipients = recipients;
            // to ensure "senders" is required (not null)
            if (senders == null) {
                throw new ArgumentNullException("senders is a required property for CreateTokensTransactionRequestFromAddressRI and cannot be null");
            }
            this.Senders = senders;
            // to ensure "tokenTypeSpecificData" is required (not null)
            if (tokenTypeSpecificData == null) {
                throw new ArgumentNullException("tokenTypeSpecificData is a required property for CreateTokensTransactionRequestFromAddressRI and cannot be null");
            }
            this.TokenTypeSpecificData = tokenTypeSpecificData;
            // to ensure "transactionRequestId" is required (not null)
            if (transactionRequestId == null) {
                throw new ArgumentNullException("transactionRequestId is a required property for CreateTokensTransactionRequestFromAddressRI and cannot be null");
            }
            this.TransactionRequestId = transactionRequestId;
            this.Note = note;
        }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).</value>
        [DataMember(Name = "callbackSecretKey", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Represents an optional note to add a free text in, explaining or providing additional detail on the transaction request.
        /// </summary>
        /// <value>Represents an optional note to add a free text in, explaining or providing additional detail on the transaction request.</value>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Defines the destination for the transaction, i.e. the recipient(s).
        /// </summary>
        /// <value>Defines the destination for the transaction, i.e. the recipient(s).</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<CreateTokensTransactionRequestFromAddressRIRecipients> Recipients { get; set; }

        /// <summary>
        /// Gets or Sets Senders
        /// </summary>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public CreateTokensTransactionRequestFromAddressRISenders Senders { get; set; }

        /// <summary>
        /// Gets or Sets TokenTypeSpecificData
        /// </summary>
        [DataMember(Name = "tokenTypeSpecificData", IsRequired = true, EmitDefaultValue = false)]
        public CreateTokensTransactionRequestFromAddressRIS TokenTypeSpecificData { get; set; }

        /// <summary>
        /// Represents a unique identifier of the transaction request (the request sent to make a transaction), which helps in identifying which callback and which &#x60;referenceId&#x60; concern that specific transaction request.
        /// </summary>
        /// <value>Represents a unique identifier of the transaction request (the request sent to make a transaction), which helps in identifying which callback and which &#x60;referenceId&#x60; concern that specific transaction request.</value>
        [DataMember(Name = "transactionRequestId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTokensTransactionRequestFromAddressRI {\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  FeePriority: ").Append(FeePriority).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  TokenTypeSpecificData: ").Append(TokenTypeSpecificData).Append("\n");
            sb.Append("  TransactionRequestId: ").Append(TransactionRequestId).Append("\n");
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
            return this.Equals(input as CreateTokensTransactionRequestFromAddressRI);
        }

        /// <summary>
        /// Returns true if CreateTokensTransactionRequestFromAddressRI instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTokensTransactionRequestFromAddressRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTokensTransactionRequestFromAddressRI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallbackSecretKey == input.CallbackSecretKey ||
                    (this.CallbackSecretKey != null &&
                    this.CallbackSecretKey.Equals(input.CallbackSecretKey))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.FeePriority == input.FeePriority ||
                    this.FeePriority.Equals(input.FeePriority)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Senders == input.Senders ||
                    (this.Senders != null &&
                    this.Senders.Equals(input.Senders))
                ) && 
                (
                    this.TokenTypeSpecificData == input.TokenTypeSpecificData ||
                    (this.TokenTypeSpecificData != null &&
                    this.TokenTypeSpecificData.Equals(input.TokenTypeSpecificData))
                ) && 
                (
                    this.TransactionRequestId == input.TransactionRequestId ||
                    (this.TransactionRequestId != null &&
                    this.TransactionRequestId.Equals(input.TransactionRequestId))
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
                if (this.CallbackSecretKey != null)
                    hashCode = hashCode * 59 + this.CallbackSecretKey.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                hashCode = hashCode * 59 + this.FeePriority.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Senders != null)
                    hashCode = hashCode * 59 + this.Senders.GetHashCode();
                if (this.TokenTypeSpecificData != null)
                    hashCode = hashCode * 59 + this.TokenTypeSpecificData.GetHashCode();
                if (this.TransactionRequestId != null)
                    hashCode = hashCode * 59 + this.TransactionRequestId.GetHashCode();
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
