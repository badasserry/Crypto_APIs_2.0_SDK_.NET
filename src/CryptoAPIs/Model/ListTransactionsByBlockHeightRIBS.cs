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
    /// ListTransactionsByBlockHeightRIBS
    /// </summary>
    [JsonConverter(typeof(ListTransactionsByBlockHeightRIBSJsonConverter))]
    [DataContract(Name = "ListTransactionsByBlockHeightRIBS")]
    public partial class ListTransactionsByBlockHeightRIBS : AbstractOpenAPISchema, IEquatable<ListTransactionsByBlockHeightRIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSB.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSBC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSBC.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSBC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSBSC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSBSC.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSBSC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSD" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSD.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSD actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSD2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSD2.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSD2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSE" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSE.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSE actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSEC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSEC.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSEC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSL" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSL.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSL actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBS" /> class
        /// with the <see cref="ListTransactionsByBlockHeightRIBSZ" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListTransactionsByBlockHeightRIBSZ.</param>
        public ListTransactionsByBlockHeightRIBS(ListTransactionsByBlockHeightRIBSZ actualInstance)
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
                if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSBC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSBSC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSD))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSD2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSE))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSEC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSL))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListTransactionsByBlockHeightRIBSZ))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ListTransactionsByBlockHeightRIBSB, ListTransactionsByBlockHeightRIBSBC, ListTransactionsByBlockHeightRIBSBSC, ListTransactionsByBlockHeightRIBSD, ListTransactionsByBlockHeightRIBSD2, ListTransactionsByBlockHeightRIBSE, ListTransactionsByBlockHeightRIBSEC, ListTransactionsByBlockHeightRIBSL, ListTransactionsByBlockHeightRIBSZ");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSB`. If the actual instance is not `ListTransactionsByBlockHeightRIBSB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSB</returns>
        public ListTransactionsByBlockHeightRIBSB GetListTransactionsByBlockHeightRIBSB()
        {
            return (ListTransactionsByBlockHeightRIBSB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSBC`. If the actual instance is not `ListTransactionsByBlockHeightRIBSBC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSBC</returns>
        public ListTransactionsByBlockHeightRIBSBC GetListTransactionsByBlockHeightRIBSBC()
        {
            return (ListTransactionsByBlockHeightRIBSBC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSBSC`. If the actual instance is not `ListTransactionsByBlockHeightRIBSBSC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSBSC</returns>
        public ListTransactionsByBlockHeightRIBSBSC GetListTransactionsByBlockHeightRIBSBSC()
        {
            return (ListTransactionsByBlockHeightRIBSBSC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSD`. If the actual instance is not `ListTransactionsByBlockHeightRIBSD`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSD</returns>
        public ListTransactionsByBlockHeightRIBSD GetListTransactionsByBlockHeightRIBSD()
        {
            return (ListTransactionsByBlockHeightRIBSD)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSD2`. If the actual instance is not `ListTransactionsByBlockHeightRIBSD2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSD2</returns>
        public ListTransactionsByBlockHeightRIBSD2 GetListTransactionsByBlockHeightRIBSD2()
        {
            return (ListTransactionsByBlockHeightRIBSD2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSE`. If the actual instance is not `ListTransactionsByBlockHeightRIBSE`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSE</returns>
        public ListTransactionsByBlockHeightRIBSE GetListTransactionsByBlockHeightRIBSE()
        {
            return (ListTransactionsByBlockHeightRIBSE)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSEC`. If the actual instance is not `ListTransactionsByBlockHeightRIBSEC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSEC</returns>
        public ListTransactionsByBlockHeightRIBSEC GetListTransactionsByBlockHeightRIBSEC()
        {
            return (ListTransactionsByBlockHeightRIBSEC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSL`. If the actual instance is not `ListTransactionsByBlockHeightRIBSL`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSL</returns>
        public ListTransactionsByBlockHeightRIBSL GetListTransactionsByBlockHeightRIBSL()
        {
            return (ListTransactionsByBlockHeightRIBSL)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListTransactionsByBlockHeightRIBSZ`. If the actual instance is not `ListTransactionsByBlockHeightRIBSZ`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBSZ</returns>
        public ListTransactionsByBlockHeightRIBSZ GetListTransactionsByBlockHeightRIBSZ()
        {
            return (ListTransactionsByBlockHeightRIBSZ)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransactionsByBlockHeightRIBS {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ListTransactionsByBlockHeightRIBS.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ListTransactionsByBlockHeightRIBS
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ListTransactionsByBlockHeightRIBS</returns>
        public static ListTransactionsByBlockHeightRIBS FromJson(string jsonString)
        {
            ListTransactionsByBlockHeightRIBS newListTransactionsByBlockHeightRIBS = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newListTransactionsByBlockHeightRIBS;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSB).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSB>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSB>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSB: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSBC).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSBC>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSBC>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSBC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSBC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSBSC).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSBSC>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSBSC>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSBSC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSBSC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSD).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSD>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSD>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSD");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSD: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSD2).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSD2>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSD2>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSD2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSD2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSE).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSE>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSE>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSE");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSE: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSEC).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSEC>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSEC>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSEC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSEC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSL).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSL>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSL>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSL");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSL: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListTransactionsByBlockHeightRIBSZ).GetProperty("AdditionalProperties") == null)
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSZ>(jsonString, ListTransactionsByBlockHeightRIBS.SerializerSettings));
                }
                else
                {
                    newListTransactionsByBlockHeightRIBS = new ListTransactionsByBlockHeightRIBS(JsonConvert.DeserializeObject<ListTransactionsByBlockHeightRIBSZ>(jsonString, ListTransactionsByBlockHeightRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListTransactionsByBlockHeightRIBSZ");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListTransactionsByBlockHeightRIBSZ: {1}", jsonString, exception.ToString()));
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
            return newListTransactionsByBlockHeightRIBS;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTransactionsByBlockHeightRIBS);
        }

        /// <summary>
        /// Returns true if ListTransactionsByBlockHeightRIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTransactionsByBlockHeightRIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTransactionsByBlockHeightRIBS input)
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
    /// Custom JSON converter for ListTransactionsByBlockHeightRIBS
    /// </summary>
    public class ListTransactionsByBlockHeightRIBSJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ListTransactionsByBlockHeightRIBS).GetMethod("ToJson").Invoke(value, null)));
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
                return ListTransactionsByBlockHeightRIBS.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
