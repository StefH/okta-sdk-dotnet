/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
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
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// ProtocolAlgorithmTypeSignature
    /// </summary>
    [DataContract(Name = "ProtocolAlgorithmTypeSignature")]
    
    public partial class ProtocolAlgorithmTypeSignature : IEquatable<ProtocolAlgorithmTypeSignature>
    {

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        
        public ProtocolAlgorithmTypeSignatureScope Scope { get; set; }
        
        /// <summary>
        /// Gets or Sets Algorithm
        /// </summary>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProtocolAlgorithmTypeSignature {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as ProtocolAlgorithmTypeSignature);
        }

        /// <summary>
        /// Returns true if ProtocolAlgorithmTypeSignature instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtocolAlgorithmTypeSignature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtocolAlgorithmTypeSignature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
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
                
                if (this.Algorithm != null)
                {
                    hashCode = (hashCode * 59) + this.Algorithm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                return hashCode;
            }
        }

    }

}