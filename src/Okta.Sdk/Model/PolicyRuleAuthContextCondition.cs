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
    /// PolicyRuleAuthContextCondition
    /// </summary>
    [DataContract(Name = "PolicyRuleAuthContextCondition")]
    
    public partial class PolicyRuleAuthContextCondition : IEquatable<PolicyRuleAuthContextCondition>
    {

        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name = "authType", EmitDefaultValue = false)]
        
        public PolicyRuleAuthContextType AuthType { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicyRuleAuthContextCondition {\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
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
            return this.Equals(input as PolicyRuleAuthContextCondition);
        }

        /// <summary>
        /// Returns true if PolicyRuleAuthContextCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyRuleAuthContextCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyRuleAuthContextCondition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthType == input.AuthType ||
                    this.AuthType.Equals(input.AuthType)
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
                
                hashCode = (hashCode * 59) + this.AuthType.GetHashCode();
                return hashCode;
            }
        }

    }

}
