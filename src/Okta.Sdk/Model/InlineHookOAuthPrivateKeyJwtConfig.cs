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
    /// InlineHookOAuthPrivateKeyJwtConfig
    /// </summary>
    [DataContract(Name = "InlineHookOAuthPrivateKeyJwtConfig")]
    
    public partial class InlineHookOAuthPrivateKeyJwtConfig : IEquatable<InlineHookOAuthPrivateKeyJwtConfig>
    {
        
        /// <summary>
        /// Gets or Sets HookKeyId
        /// </summary>
        [DataMember(Name = "hookKeyId", EmitDefaultValue = false)]
        public string HookKeyId { get; set; }

        /// <summary>
        /// Gets or Sets AuthScheme
        /// </summary>
        [DataMember(Name = "authScheme", EmitDefaultValue = false)]
        public InlineHookChannelConfigAuthScheme AuthScheme { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public List<InlineHookChannelConfigHeaders> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineHookOAuthPrivateKeyJwtConfig {\n");
            sb.Append("  HookKeyId: ").Append(HookKeyId).Append("\n");
            sb.Append("  AuthScheme: ").Append(AuthScheme).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as InlineHookOAuthPrivateKeyJwtConfig);
        }

        /// <summary>
        /// Returns true if InlineHookOAuthPrivateKeyJwtConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineHookOAuthPrivateKeyJwtConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineHookOAuthPrivateKeyJwtConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HookKeyId == input.HookKeyId ||
                    (this.HookKeyId != null &&
                    this.HookKeyId.Equals(input.HookKeyId))
                ) && 
                (
                    this.AuthScheme == input.AuthScheme ||
                    (this.AuthScheme != null &&
                    this.AuthScheme.Equals(input.AuthScheme))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                
                if (this.HookKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.HookKeyId.GetHashCode();
                }
                if (this.AuthScheme != null)
                {
                    hashCode = (hashCode * 59) + this.AuthScheme.GetHashCode();
                }
                if (this.Headers != null)
                {
                    hashCode = (hashCode * 59) + this.Headers.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}