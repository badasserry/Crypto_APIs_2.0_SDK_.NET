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
    /// BroadcastTransactionSuccess
    /// </summary>
    [DataContract(Name = "BroadcastTransactionSuccess")]
    public partial class BroadcastTransactionSuccess : IEquatable<BroadcastTransactionSuccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastTransactionSuccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BroadcastTransactionSuccess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastTransactionSuccess" /> class.
        /// </summary>
        /// <param name="apiVersion">Specifies the version of the API that incorporates this endpoint. (required).</param>
        /// <param name="referenceId">Represents a unique identifier that serves as reference to the specific request which prompts a callback, e.g. Blockchain Events Subscription, Blockchain Automation, etc. (required).</param>
        /// <param name="idempotencyKey">Specifies a unique ID generated by the system and attached to each callback. It is used by the server to recognize consecutive requests with the same data with the purpose not to perform the same operation twice. (required).</param>
        /// <param name="data">data (required).</param>
        public BroadcastTransactionSuccess(string apiVersion = default(string), string referenceId = default(string), string idempotencyKey = default(string), BroadcastTransactionSuccessData data = default(BroadcastTransactionSuccessData))
        {
            // to ensure "apiVersion" is required (not null)
            if (apiVersion == null) {
                throw new ArgumentNullException("apiVersion is a required property for BroadcastTransactionSuccess and cannot be null");
            }
            this.ApiVersion = apiVersion;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null) {
                throw new ArgumentNullException("referenceId is a required property for BroadcastTransactionSuccess and cannot be null");
            }
            this.ReferenceId = referenceId;
            // to ensure "idempotencyKey" is required (not null)
            if (idempotencyKey == null) {
                throw new ArgumentNullException("idempotencyKey is a required property for BroadcastTransactionSuccess and cannot be null");
            }
            this.IdempotencyKey = idempotencyKey;
            // to ensure "data" is required (not null)
            if (data == null) {
                throw new ArgumentNullException("data is a required property for BroadcastTransactionSuccess and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Specifies the version of the API that incorporates this endpoint.
        /// </summary>
        /// <value>Specifies the version of the API that incorporates this endpoint.</value>
        [DataMember(Name = "apiVersion", IsRequired = true, EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Represents a unique identifier that serves as reference to the specific request which prompts a callback, e.g. Blockchain Events Subscription, Blockchain Automation, etc.
        /// </summary>
        /// <value>Represents a unique identifier that serves as reference to the specific request which prompts a callback, e.g. Blockchain Events Subscription, Blockchain Automation, etc.</value>
        [DataMember(Name = "referenceId", IsRequired = true, EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Specifies a unique ID generated by the system and attached to each callback. It is used by the server to recognize consecutive requests with the same data with the purpose not to perform the same operation twice.
        /// </summary>
        /// <value>Specifies a unique ID generated by the system and attached to each callback. It is used by the server to recognize consecutive requests with the same data with the purpose not to perform the same operation twice.</value>
        [DataMember(Name = "idempotencyKey", IsRequired = true, EmitDefaultValue = false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public BroadcastTransactionSuccessData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastTransactionSuccess {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as BroadcastTransactionSuccess);
        }

        /// <summary>
        /// Returns true if BroadcastTransactionSuccess instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastTransactionSuccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastTransactionSuccess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.IdempotencyKey == input.IdempotencyKey ||
                    (this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(input.IdempotencyKey))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.IdempotencyKey != null)
                    hashCode = hashCode * 59 + this.IdempotencyKey.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
