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
    /// OAuth2Claim
    /// </summary>
    [DataContract(Name = "OAuth2Claim")]
    
    public partial class OAuth2Claim : IEquatable<OAuth2Claim>
    {

        /// <summary>
        /// Gets or Sets ClaimType
        /// </summary>
        [DataMember(Name = "claimType", EmitDefaultValue = false)]
        
        public OAuth2ClaimType ClaimType { get; set; }

        /// <summary>
        /// Gets or Sets GroupFilterType
        /// </summary>
        [DataMember(Name = "group_filter_type", EmitDefaultValue = false)]
        
        public OAuth2ClaimGroupFilterType GroupFilterType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        
        public LifecycleStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = false)]
        
        public OAuth2ClaimValueType ValueType { get; set; }
        
        /// <summary>
        /// Gets or Sets AlwaysIncludeInToken
        /// </summary>
        [DataMember(Name = "alwaysIncludeInToken", EmitDefaultValue = true)]
        public bool AlwaysIncludeInToken { get; set; }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public OAuth2ClaimConditions Conditions { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name = "system", EmitDefaultValue = true)]
        public bool System { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Dictionary<string, Object> Links { get; private set; }

        /// <summary>
        /// Returns false as Links should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinks()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuth2Claim {\n");
            sb.Append("  AlwaysIncludeInToken: ").Append(AlwaysIncludeInToken).Append("\n");
            sb.Append("  ClaimType: ").Append(ClaimType).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  GroupFilterType: ").Append(GroupFilterType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as OAuth2Claim);
        }

        /// <summary>
        /// Returns true if OAuth2Claim instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuth2Claim to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2Claim input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlwaysIncludeInToken == input.AlwaysIncludeInToken ||
                    this.AlwaysIncludeInToken.Equals(input.AlwaysIncludeInToken)
                ) && 
                (
                    this.ClaimType == input.ClaimType ||
                    this.ClaimType.Equals(input.ClaimType)
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    (this.Conditions != null &&
                    this.Conditions.Equals(input.Conditions))
                ) && 
                (
                    this.GroupFilterType == input.GroupFilterType ||
                    this.GroupFilterType.Equals(input.GroupFilterType)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.System == input.System ||
                    this.System.Equals(input.System)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    this.ValueType.Equals(input.ValueType)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                
                hashCode = (hashCode * 59) + this.AlwaysIncludeInToken.GetHashCode();
                hashCode = (hashCode * 59) + this.ClaimType.GetHashCode();
                if (this.Conditions != null)
                {
                    hashCode = (hashCode * 59) + this.Conditions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GroupFilterType.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.System.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
