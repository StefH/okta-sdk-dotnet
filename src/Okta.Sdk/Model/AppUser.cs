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
    /// AppUser
    /// </summary>
    [DataContract(Name = "AppUser")]
    
    public partial class AppUser : IEquatable<AppUser>
    {
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTimeOffset Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public AppUserCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Returns false as ExternalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExternalId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastSync
        /// </summary>
        [DataMember(Name = "lastSync", EmitDefaultValue = false)]
        public DateTimeOffset LastSync { get; private set; }

        /// <summary>
        /// Returns false as LastSync should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastSync()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTimeOffset LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PasswordChanged
        /// </summary>
        [DataMember(Name = "passwordChanged", EmitDefaultValue = true)]
        public DateTimeOffset? PasswordChanged { get; private set; }

        /// <summary>
        /// Returns false as PasswordChanged should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePasswordChanged()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public Dictionary<string, Object> Profile { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; private set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets StatusChanged
        /// </summary>
        [DataMember(Name = "statusChanged", EmitDefaultValue = false)]
        public DateTimeOffset StatusChanged { get; private set; }

        /// <summary>
        /// Returns false as StatusChanged should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatusChanged()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SyncState
        /// </summary>
        [DataMember(Name = "syncState", EmitDefaultValue = false)]
        public string SyncState { get; private set; }

        /// <summary>
        /// Returns false as SyncState should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSyncState()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        public Dictionary<string, Object> Embedded { get; private set; }

        /// <summary>
        /// Returns false as Embedded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmbedded()
        {
            return false;
        }
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
            sb.Append("class AppUser {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastSync: ").Append(LastSync).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  PasswordChanged: ").Append(PasswordChanged).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusChanged: ").Append(StatusChanged).Append("\n");
            sb.Append("  SyncState: ").Append(SyncState).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(input as AppUser);
        }

        /// <summary>
        /// Returns true if AppUser instances are equal
        /// </summary>
        /// <param name="input">Instance of AppUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastSync == input.LastSync ||
                    (this.LastSync != null &&
                    this.LastSync.Equals(input.LastSync))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.PasswordChanged == input.PasswordChanged ||
                    (this.PasswordChanged != null &&
                    this.PasswordChanged.Equals(input.PasswordChanged))
                ) && 
                (
                    this.Profile == input.Profile ||
                    this.Profile != null &&
                    input.Profile != null &&
                    this.Profile.SequenceEqual(input.Profile)
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusChanged == input.StatusChanged ||
                    (this.StatusChanged != null &&
                    this.StatusChanged.Equals(input.StatusChanged))
                ) && 
                (
                    this.SyncState == input.SyncState ||
                    (this.SyncState != null &&
                    this.SyncState.Equals(input.SyncState))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    this.Embedded != null &&
                    input.Embedded != null &&
                    this.Embedded.SequenceEqual(input.Embedded)
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
                
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LastSync != null)
                {
                    hashCode = (hashCode * 59) + this.LastSync.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.PasswordChanged != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordChanged.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StatusChanged != null)
                {
                    hashCode = (hashCode * 59) + this.StatusChanged.GetHashCode();
                }
                if (this.SyncState != null)
                {
                    hashCode = (hashCode * 59) + this.SyncState.GetHashCode();
                }
                if (this.Embedded != null)
                {
                    hashCode = (hashCode * 59) + this.Embedded.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
