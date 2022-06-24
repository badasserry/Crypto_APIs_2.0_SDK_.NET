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
    /// NewConfirmedInternalTransactionsForSpecificAmountRI
    /// </summary>
    [DataContract(Name = "NewConfirmedInternalTransactionsForSpecificAmountRI")]
    public partial class NewConfirmedInternalTransactionsForSpecificAmountRI : IEquatable<NewConfirmedInternalTransactionsForSpecificAmountRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedInternalTransactionsForSpecificAmountRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewConfirmedInternalTransactionsForSpecificAmountRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedInternalTransactionsForSpecificAmountRI" /> class.
        /// </summary>
        /// <param name="amountHigherThan">Represents a specific amount of coins after which the system have to send a callback to customers&#39; callbackUrl. (required).</param>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security)..</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;. (required).</param>
        /// <param name="createdTimestamp">Defines the specific time/date when the subscription was created in Unix Timestamp. (required).</param>
        /// <param name="eventType">Defines the type of the specific event available for the customer to subscribe to for callback notification. (required).</param>
        /// <param name="isActive">Defines whether the subscription is active or not. Set as boolean. (required).</param>
        /// <param name="referenceId">Represents a unique ID used to reference the specific callback subscription. (required).</param>
        public NewConfirmedInternalTransactionsForSpecificAmountRI(long amountHigherThan = default(long), string callbackSecretKey = default(string), string callbackUrl = default(string), int createdTimestamp = default(int), string eventType = default(string), bool isActive = default(bool), string referenceId = default(string))
        {
            this.AmountHigherThan = amountHigherThan;
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new ArgumentNullException("callbackUrl is a required property for NewConfirmedInternalTransactionsForSpecificAmountRI and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            this.CreatedTimestamp = createdTimestamp;
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new ArgumentNullException("eventType is a required property for NewConfirmedInternalTransactionsForSpecificAmountRI and cannot be null");
            }
            this.EventType = eventType;
            this.IsActive = isActive;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null)
            {
                throw new ArgumentNullException("referenceId is a required property for NewConfirmedInternalTransactionsForSpecificAmountRI and cannot be null");
            }
            this.ReferenceId = referenceId;
            this.CallbackSecretKey = callbackSecretKey;
        }

        /// <summary>
        /// Represents a specific amount of coins after which the system have to send a callback to customers&#39; callbackUrl.
        /// </summary>
        /// <value>Represents a specific amount of coins after which the system have to send a callback to customers&#39; callbackUrl.</value>
        [DataMember(Name = "amountHigherThan", IsRequired = true, EmitDefaultValue = false)]
        public long AmountHigherThan { get; set; }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Defines the specific time/date when the subscription was created in Unix Timestamp.
        /// </summary>
        /// <value>Defines the specific time/date when the subscription was created in Unix Timestamp.</value>
        [DataMember(Name = "createdTimestamp", IsRequired = true, EmitDefaultValue = false)]
        public int CreatedTimestamp { get; set; }

        /// <summary>
        /// Defines the type of the specific event available for the customer to subscribe to for callback notification.
        /// </summary>
        /// <value>Defines the type of the specific event available for the customer to subscribe to for callback notification.</value>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Defines whether the subscription is active or not. Set as boolean.
        /// </summary>
        /// <value>Defines whether the subscription is active or not. Set as boolean.</value>
        [DataMember(Name = "isActive", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Represents a unique ID used to reference the specific callback subscription.
        /// </summary>
        /// <value>Represents a unique ID used to reference the specific callback subscription.</value>
        [DataMember(Name = "referenceId", IsRequired = true, EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewConfirmedInternalTransactionsForSpecificAmountRI {\n");
            sb.Append("  AmountHigherThan: ").Append(AmountHigherThan).Append("\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(input as NewConfirmedInternalTransactionsForSpecificAmountRI);
        }

        /// <summary>
        /// Returns true if NewConfirmedInternalTransactionsForSpecificAmountRI instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedInternalTransactionsForSpecificAmountRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedInternalTransactionsForSpecificAmountRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountHigherThan == input.AmountHigherThan ||
                    this.AmountHigherThan.Equals(input.AmountHigherThan)
                ) && 
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
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp)
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
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
                hashCode = (hashCode * 59) + this.AmountHigherThan.GetHashCode();
                if (this.CallbackSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackSecretKey.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedTimestamp.GetHashCode();
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                if (this.ReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
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
