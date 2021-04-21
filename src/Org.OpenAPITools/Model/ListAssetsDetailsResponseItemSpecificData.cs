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
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Represents a specific asset&#39;s data depending on its type (whether it is \&quot;crypto\&quot; or \&quot;fiat\&quot;).
    /// </summary>
    [JsonConverter(typeof(ListAssetsDetailsResponseItemSpecificDataJsonConverter))]
    [DataContract(Name = "ListAssetsDetailsResponseItemSpecificData")]
    public partial class ListAssetsDetailsResponseItemSpecificData : AbstractOpenAPISchema, IEquatable<ListAssetsDetailsResponseItemSpecificData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetsDetailsResponseItemSpecificData" /> class
        /// with the <see cref="ListAssetsDetailsResponseItemSpecificDataCryptoTypeData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAssetsDetailsResponseItemSpecificDataCryptoTypeData.</param>
        public ListAssetsDetailsResponseItemSpecificData(ListAssetsDetailsResponseItemSpecificDataCryptoTypeData actualInstance)
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
                if (value.GetType() == typeof(ListAssetsDetailsResponseItemSpecificDataCryptoTypeData))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ListAssetsDetailsResponseItemSpecificDataCryptoTypeData");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ListAssetsDetailsResponseItemSpecificDataCryptoTypeData`. If the actual instanct is not `ListAssetsDetailsResponseItemSpecificDataCryptoTypeData`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAssetsDetailsResponseItemSpecificDataCryptoTypeData</returns>
        public ListAssetsDetailsResponseItemSpecificDataCryptoTypeData GetListAssetsDetailsResponseItemSpecificDataCryptoTypeData()
        {
            return (ListAssetsDetailsResponseItemSpecificDataCryptoTypeData)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetsDetailsResponseItemSpecificData {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ListAssetsDetailsResponseItemSpecificData.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ListAssetsDetailsResponseItemSpecificData
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ListAssetsDetailsResponseItemSpecificData</returns>
        public static ListAssetsDetailsResponseItemSpecificData FromJson(string jsonString)
        {
            ListAssetsDetailsResponseItemSpecificData newListAssetsDetailsResponseItemSpecificData = null;

            if (jsonString == null)
            {
                return newListAssetsDetailsResponseItemSpecificData;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAssetsDetailsResponseItemSpecificDataCryptoTypeData).GetProperty("AdditionalProperties") == null)
                {
                    newListAssetsDetailsResponseItemSpecificData = new ListAssetsDetailsResponseItemSpecificData(JsonConvert.DeserializeObject<ListAssetsDetailsResponseItemSpecificDataCryptoTypeData>(jsonString, ListAssetsDetailsResponseItemSpecificData.SerializerSettings));
                }
                else
                {
                    newListAssetsDetailsResponseItemSpecificData = new ListAssetsDetailsResponseItemSpecificData(JsonConvert.DeserializeObject<ListAssetsDetailsResponseItemSpecificDataCryptoTypeData>(jsonString, ListAssetsDetailsResponseItemSpecificData.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAssetsDetailsResponseItemSpecificDataCryptoTypeData");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into ListAssetsDetailsResponseItemSpecificDataCryptoTypeData: {1}", jsonString, exception.ToString()));
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
            return newListAssetsDetailsResponseItemSpecificData;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetsDetailsResponseItemSpecificData);
        }

        /// <summary>
        /// Returns true if ListAssetsDetailsResponseItemSpecificData instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAssetsDetailsResponseItemSpecificData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAssetsDetailsResponseItemSpecificData input)
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
    /// Custom JSON converter for ListAssetsDetailsResponseItemSpecificData
    /// </summary>
    public class ListAssetsDetailsResponseItemSpecificDataJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((String)(typeof(ListAssetsDetailsResponseItemSpecificData).GetMethod("ToJson").Invoke(value, null)));
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
                return ListAssetsDetailsResponseItemSpecificData.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
