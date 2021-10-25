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
    /// GetTransactionDetailsByTransactionIDRIBS
    /// </summary>
    [JsonConverter(typeof(GetTransactionDetailsByTransactionIDRIBSJsonConverter))]
    [DataContract(Name = "GetTransactionDetailsByTransactionIDRIBS")]
    public partial class GetTransactionDetailsByTransactionIDRIBS : AbstractOpenAPISchema, IEquatable<GetTransactionDetailsByTransactionIDRIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSB.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSBC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSBC.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSBC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSBSC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSBSC.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSBSC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSD" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSD.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSD actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSD2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSD2.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSD2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSE" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSE.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSE actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSEC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSEC.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSEC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBS" /> class
        /// with the <see cref="GetTransactionDetailsByTransactionIDRIBSL" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetTransactionDetailsByTransactionIDRIBSL.</param>
        public GetTransactionDetailsByTransactionIDRIBS(GetTransactionDetailsByTransactionIDRIBSL actualInstance)
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
                if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSBC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSBSC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSD))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSD2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSE))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSEC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetTransactionDetailsByTransactionIDRIBSL))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GetTransactionDetailsByTransactionIDRIBSB, GetTransactionDetailsByTransactionIDRIBSBC, GetTransactionDetailsByTransactionIDRIBSBSC, GetTransactionDetailsByTransactionIDRIBSD, GetTransactionDetailsByTransactionIDRIBSD2, GetTransactionDetailsByTransactionIDRIBSE, GetTransactionDetailsByTransactionIDRIBSEC, GetTransactionDetailsByTransactionIDRIBSL");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSB`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSB</returns>
        public GetTransactionDetailsByTransactionIDRIBSB GetGetTransactionDetailsByTransactionIDRIBSB()
        {
            return (GetTransactionDetailsByTransactionIDRIBSB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSBC`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSBC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSBC</returns>
        public GetTransactionDetailsByTransactionIDRIBSBC GetGetTransactionDetailsByTransactionIDRIBSBC()
        {
            return (GetTransactionDetailsByTransactionIDRIBSBC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSBSC`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSBSC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSBSC</returns>
        public GetTransactionDetailsByTransactionIDRIBSBSC GetGetTransactionDetailsByTransactionIDRIBSBSC()
        {
            return (GetTransactionDetailsByTransactionIDRIBSBSC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSD`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSD`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSD</returns>
        public GetTransactionDetailsByTransactionIDRIBSD GetGetTransactionDetailsByTransactionIDRIBSD()
        {
            return (GetTransactionDetailsByTransactionIDRIBSD)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSD2`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSD2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSD2</returns>
        public GetTransactionDetailsByTransactionIDRIBSD2 GetGetTransactionDetailsByTransactionIDRIBSD2()
        {
            return (GetTransactionDetailsByTransactionIDRIBSD2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSE`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSE`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSE</returns>
        public GetTransactionDetailsByTransactionIDRIBSE GetGetTransactionDetailsByTransactionIDRIBSE()
        {
            return (GetTransactionDetailsByTransactionIDRIBSE)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSEC`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSEC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSEC</returns>
        public GetTransactionDetailsByTransactionIDRIBSEC GetGetTransactionDetailsByTransactionIDRIBSEC()
        {
            return (GetTransactionDetailsByTransactionIDRIBSEC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetTransactionDetailsByTransactionIDRIBSL`. If the actual instance is not `GetTransactionDetailsByTransactionIDRIBSL`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBSL</returns>
        public GetTransactionDetailsByTransactionIDRIBSL GetGetTransactionDetailsByTransactionIDRIBSL()
        {
            return (GetTransactionDetailsByTransactionIDRIBSL)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransactionDetailsByTransactionIDRIBS {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetTransactionDetailsByTransactionIDRIBS
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetTransactionDetailsByTransactionIDRIBS</returns>
        public static GetTransactionDetailsByTransactionIDRIBS FromJson(string jsonString)
        {
            GetTransactionDetailsByTransactionIDRIBS newGetTransactionDetailsByTransactionIDRIBS = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetTransactionDetailsByTransactionIDRIBS;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSB).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSB>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSB>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSB: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSBC).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSBC>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSBC>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSBC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSBC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSBSC).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSBSC>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSBSC>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSBSC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSBSC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSD).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSD>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSD>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSD");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSD: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSD2).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSD2>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSD2>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSD2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSD2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSE).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSE>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSE>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSE");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSE: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSEC).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSEC>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSEC>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSEC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSEC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetTransactionDetailsByTransactionIDRIBSL).GetProperty("AdditionalProperties") == null)
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSL>(jsonString, GetTransactionDetailsByTransactionIDRIBS.SerializerSettings));
                }
                else
                {
                    newGetTransactionDetailsByTransactionIDRIBS = new GetTransactionDetailsByTransactionIDRIBS(JsonConvert.DeserializeObject<GetTransactionDetailsByTransactionIDRIBSL>(jsonString, GetTransactionDetailsByTransactionIDRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetTransactionDetailsByTransactionIDRIBSL");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetTransactionDetailsByTransactionIDRIBSL: {1}", jsonString, exception.ToString()));
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
            return newGetTransactionDetailsByTransactionIDRIBS;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetTransactionDetailsByTransactionIDRIBS);
        }

        /// <summary>
        /// Returns true if GetTransactionDetailsByTransactionIDRIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionDetailsByTransactionIDRIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionDetailsByTransactionIDRIBS input)
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
    /// Custom JSON converter for GetTransactionDetailsByTransactionIDRIBS
    /// </summary>
    public class GetTransactionDetailsByTransactionIDRIBSJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetTransactionDetailsByTransactionIDRIBS).GetMethod("ToJson").Invoke(value, null)));
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
                return GetTransactionDetailsByTransactionIDRIBS.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
