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
    /// PerClientRateLimitSettings
    /// </summary>
    [DataContract(Name = "PerClientRateLimitSettings")]
    
    public partial class PerClientRateLimitSettings : IEquatable<PerClientRateLimitSettings>
    {

        /// <summary>
        /// Gets or Sets DefaultMode
        /// </summary>
        [DataMember(Name = "defaultMode", IsRequired = true, EmitDefaultValue = false)]
        
        public PerClientRateLimitMode DefaultMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerClientRateLimitSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PerClientRateLimitSettings() { }
        
        /// <summary>
        /// Gets or Sets UseCaseModeOverrides
        /// </summary>
        [DataMember(Name = "useCaseModeOverrides", EmitDefaultValue = false)]
        public PerClientRateLimitSettingsUseCaseModeOverrides UseCaseModeOverrides { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PerClientRateLimitSettings {\n");
            sb.Append("  DefaultMode: ").Append(DefaultMode).Append("\n");
            sb.Append("  UseCaseModeOverrides: ").Append(UseCaseModeOverrides).Append("\n");
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
            return this.Equals(input as PerClientRateLimitSettings);
        }

        /// <summary>
        /// Returns true if PerClientRateLimitSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of PerClientRateLimitSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerClientRateLimitSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DefaultMode == input.DefaultMode ||
                    this.DefaultMode.Equals(input.DefaultMode)
                ) && 
                (
                    this.UseCaseModeOverrides == input.UseCaseModeOverrides ||
                    (this.UseCaseModeOverrides != null &&
                    this.UseCaseModeOverrides.Equals(input.UseCaseModeOverrides))
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
                
                hashCode = (hashCode * 59) + this.DefaultMode.GetHashCode();
                if (this.UseCaseModeOverrides != null)
                {
                    hashCode = (hashCode * 59) + this.UseCaseModeOverrides.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
