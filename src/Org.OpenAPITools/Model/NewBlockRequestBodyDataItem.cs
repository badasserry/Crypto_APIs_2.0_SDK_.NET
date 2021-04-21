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
    /// NewBlockRequestBodyDataItem
    /// </summary>
    [DataContract(Name = "NewBlockRequestBody_data_item")]
    public partial class NewBlockRequestBodyDataItem : IEquatable<NewBlockRequestBodyDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewBlockRequestBodyDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewBlockRequestBodyDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewBlockRequestBodyDataItem" /> class.
        /// </summary>
        /// <param name="allowDuplicates">Specifies a flag that permits or denies the creation of duplicate addresses. (default to false).</param>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs..</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. (required).</param>
        public NewBlockRequestBodyDataItem(bool allowDuplicates = false, string callbackSecretKey = default(string), string callbackUrl = default(string))
        {
            // to ensure "callbackUrl" is required (not null)
            this.CallbackUrl = callbackUrl ?? throw new ArgumentNullException("callbackUrl is a required property for NewBlockRequestBodyDataItem and cannot be null");
            this.AllowDuplicates = allowDuplicates;
            this.CallbackSecretKey = callbackSecretKey;
        }

        /// <summary>
        /// Specifies a flag that permits or denies the creation of duplicate addresses.
        /// </summary>
        /// <value>Specifies a flag that permits or denies the creation of duplicate addresses.</value>
        [DataMember(Name = "allowDuplicates", EmitDefaultValue = true)]
        public bool AllowDuplicates { get; set; }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewBlockRequestBodyDataItem {\n");
            sb.Append("  AllowDuplicates: ").Append(AllowDuplicates).Append("\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
            return this.Equals(input as NewBlockRequestBodyDataItem);
        }

        /// <summary>
        /// Returns true if NewBlockRequestBodyDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NewBlockRequestBodyDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewBlockRequestBodyDataItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowDuplicates == input.AllowDuplicates ||
                    this.AllowDuplicates.Equals(input.AllowDuplicates)
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
                hashCode = hashCode * 59 + this.AllowDuplicates.GetHashCode();
                if (this.CallbackSecretKey != null)
                    hashCode = hashCode * 59 + this.CallbackSecretKey.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
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
