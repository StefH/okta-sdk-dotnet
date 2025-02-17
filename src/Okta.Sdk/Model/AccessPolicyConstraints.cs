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
    /// AccessPolicyConstraints
    /// </summary>
    [DataContract(Name = "AccessPolicyConstraints")]
    
    public partial class AccessPolicyConstraints : IEquatable<AccessPolicyConstraints>
    {
        
        /// <summary>
        /// Gets or Sets Knowledge
        /// </summary>
        [DataMember(Name = "knowledge", EmitDefaultValue = false)]
        public KnowledgeConstraint Knowledge { get; set; }

        /// <summary>
        /// Gets or Sets Possession
        /// </summary>
        [DataMember(Name = "possession", EmitDefaultValue = false)]
        public PossessionConstraint Possession { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessPolicyConstraints {\n");
            sb.Append("  Knowledge: ").Append(Knowledge).Append("\n");
            sb.Append("  Possession: ").Append(Possession).Append("\n");
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
            return this.Equals(input as AccessPolicyConstraints);
        }

        /// <summary>
        /// Returns true if AccessPolicyConstraints instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessPolicyConstraints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessPolicyConstraints input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Knowledge == input.Knowledge ||
                    (this.Knowledge != null &&
                    this.Knowledge.Equals(input.Knowledge))
                ) && 
                (
                    this.Possession == input.Possession ||
                    (this.Possession != null &&
                    this.Possession.Equals(input.Possession))
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
                
                if (this.Knowledge != null)
                {
                    hashCode = (hashCode * 59) + this.Knowledge.GetHashCode();
                }
                if (this.Possession != null)
                {
                    hashCode = (hashCode * 59) + this.Possession.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
