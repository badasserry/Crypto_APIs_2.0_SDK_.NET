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
using System.Reflection;

namespace CryptoAPIs.Model
{
    /// <summary>
    /// TokensForwardingSuccessToken
    /// </summary>
    [JsonConverter(typeof(TokensForwardingSuccessTokenJsonConverter))]
    [DataContract(Name = "TokensForwardingSuccessToken")]
    public partial class TokensForwardingSuccessToken : AbstractOpenAPISchema, IEquatable<TokensForwardingSuccessToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensForwardingSuccessToken" /> class
        /// with the <see cref="TokensForwardingSuccessErc20" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TokensForwardingSuccessErc20.</param>
        public TokensForwardingSuccessToken(TokensForwardingSuccessErc20 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensForwardingSuccessToken" /> class
        /// with the <see cref="TokensForwardingSuccessErc721" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TokensForwardingSuccessErc721.</param>
        public TokensForwardingSuccessToken(TokensForwardingSuccessErc721 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensForwardingSuccessToken" /> class
        /// with the <see cref="TokensForwardingSuccessOmni" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TokensForwardingSuccessOmni.</param>
        public TokensForwardingSuccessToken(TokensForwardingSuccessOmni actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(TokensForwardingSuccessErc20))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TokensForwardingSuccessErc721))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TokensForwardingSuccessOmni))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: TokensForwardingSuccessErc20, TokensForwardingSuccessErc721, TokensForwardingSuccessOmni");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `TokensForwardingSuccessErc20`. If the actual instance is not `TokensForwardingSuccessErc20`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TokensForwardingSuccessErc20</returns>
        public TokensForwardingSuccessErc20 GetTokensForwardingSuccessErc20()
        {
            return (TokensForwardingSuccessErc20)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TokensForwardingSuccessErc721`. If the actual instance is not `TokensForwardingSuccessErc721`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TokensForwardingSuccessErc721</returns>
        public TokensForwardingSuccessErc721 GetTokensForwardingSuccessErc721()
        {
            return (TokensForwardingSuccessErc721)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TokensForwardingSuccessOmni`. If the actual instance is not `TokensForwardingSuccessOmni`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TokensForwardingSuccessOmni</returns>
        public TokensForwardingSuccessOmni GetTokensForwardingSuccessOmni()
        {
            return (TokensForwardingSuccessOmni)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokensForwardingSuccessToken {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, TokensForwardingSuccessToken.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TokensForwardingSuccessToken
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TokensForwardingSuccessToken</returns>
        public static TokensForwardingSuccessToken FromJson(string jsonString)
        {
            TokensForwardingSuccessToken newTokensForwardingSuccessToken = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTokensForwardingSuccessToken;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TokensForwardingSuccessErc20).GetProperty("AdditionalProperties") == null)
                {
                    newTokensForwardingSuccessToken = new TokensForwardingSuccessToken(JsonConvert.DeserializeObject<TokensForwardingSuccessErc20>(jsonString, TokensForwardingSuccessToken.SerializerSettings));
                }
                else
                {
                    newTokensForwardingSuccessToken = new TokensForwardingSuccessToken(JsonConvert.DeserializeObject<TokensForwardingSuccessErc20>(jsonString, TokensForwardingSuccessToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TokensForwardingSuccessErc20");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TokensForwardingSuccessErc20: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TokensForwardingSuccessErc721).GetProperty("AdditionalProperties") == null)
                {
                    newTokensForwardingSuccessToken = new TokensForwardingSuccessToken(JsonConvert.DeserializeObject<TokensForwardingSuccessErc721>(jsonString, TokensForwardingSuccessToken.SerializerSettings));
                }
                else
                {
                    newTokensForwardingSuccessToken = new TokensForwardingSuccessToken(JsonConvert.DeserializeObject<TokensForwardingSuccessErc721>(jsonString, TokensForwardingSuccessToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TokensForwardingSuccessErc721");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TokensForwardingSuccessErc721: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TokensForwardingSuccessOmni).GetProperty("AdditionalProperties") == null)
                {
                    newTokensForwardingSuccessToken = new TokensForwardingSuccessToken(JsonConvert.DeserializeObject<TokensForwardingSuccessOmni>(jsonString, TokensForwardingSuccessToken.SerializerSettings));
                }
                else
                {
                    newTokensForwardingSuccessToken = new TokensForwardingSuccessToken(JsonConvert.DeserializeObject<TokensForwardingSuccessOmni>(jsonString, TokensForwardingSuccessToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TokensForwardingSuccessOmni");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TokensForwardingSuccessOmni: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newTokensForwardingSuccessToken;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokensForwardingSuccessToken);
        }

        /// <summary>
        /// Returns true if TokensForwardingSuccessToken instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensForwardingSuccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensForwardingSuccessToken input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for TokensForwardingSuccessToken
    /// </summary>
    public class TokensForwardingSuccessTokenJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TokensForwardingSuccessToken).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return TokensForwardingSuccessToken.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
