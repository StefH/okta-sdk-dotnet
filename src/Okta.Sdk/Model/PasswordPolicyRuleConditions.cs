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
    /// PasswordPolicyRuleConditions
    /// </summary>
    [DataContract(Name = "PasswordPolicyRuleConditions")]
    
    public partial class PasswordPolicyRuleConditions : IEquatable<PasswordPolicyRuleConditions>
    {
        
        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", EmitDefaultValue = false)]
        public AppAndInstancePolicyRuleCondition App { get; set; }

        /// <summary>
        /// Gets or Sets Apps
        /// </summary>
        [DataMember(Name = "apps", EmitDefaultValue = false)]
        public AppInstancePolicyRuleCondition Apps { get; set; }

        /// <summary>
        /// Gets or Sets AuthContext
        /// </summary>
        [DataMember(Name = "authContext", EmitDefaultValue = false)]
        public PolicyRuleAuthContextCondition AuthContext { get; set; }

        /// <summary>
        /// Gets or Sets AuthProvider
        /// </summary>
        [DataMember(Name = "authProvider", EmitDefaultValue = false)]
        public PasswordPolicyAuthenticationProviderCondition AuthProvider { get; set; }

        /// <summary>
        /// Gets or Sets BeforeScheduledAction
        /// </summary>
        [DataMember(Name = "beforeScheduledAction", EmitDefaultValue = false)]
        public BeforeScheduledActionPolicyRuleCondition BeforeScheduledAction { get; set; }

        /// <summary>
        /// Gets or Sets Clients
        /// </summary>
        [DataMember(Name = "clients", EmitDefaultValue = false)]
        public ClientPolicyCondition Clients { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public ContextPolicyRuleCondition Context { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public DevicePolicyRuleCondition Device { get; set; }

        /// <summary>
        /// Gets or Sets GrantTypes
        /// </summary>
        [DataMember(Name = "grantTypes", EmitDefaultValue = false)]
        public GrantTypePolicyRuleCondition GrantTypes { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public GroupPolicyRuleCondition Groups { get; set; }

        /// <summary>
        /// Gets or Sets IdentityProvider
        /// </summary>
        [DataMember(Name = "identityProvider", EmitDefaultValue = false)]
        public IdentityProviderPolicyRuleCondition IdentityProvider { get; set; }

        /// <summary>
        /// Gets or Sets MdmEnrollment
        /// </summary>
        [DataMember(Name = "mdmEnrollment", EmitDefaultValue = false)]
        public MDMEnrollmentPolicyRuleCondition MdmEnrollment { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public PolicyNetworkCondition Network { get; set; }

        /// <summary>
        /// Gets or Sets People
        /// </summary>
        [DataMember(Name = "people", EmitDefaultValue = false)]
        public PolicyPeopleCondition People { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public PlatformPolicyRuleCondition Platform { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name = "risk", EmitDefaultValue = false)]
        public RiskPolicyRuleCondition Risk { get; set; }

        /// <summary>
        /// Gets or Sets RiskScore
        /// </summary>
        [DataMember(Name = "riskScore", EmitDefaultValue = false)]
        public RiskScorePolicyRuleCondition RiskScore { get; set; }

        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        public OAuth2ScopesMediationPolicyRuleCondition Scopes { get; set; }

        /// <summary>
        /// Gets or Sets UserIdentifier
        /// </summary>
        [DataMember(Name = "userIdentifier", EmitDefaultValue = false)]
        public UserIdentifierPolicyRuleCondition UserIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public UserPolicyRuleCondition Users { get; set; }

        /// <summary>
        /// Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name = "userStatus", EmitDefaultValue = false)]
        public UserStatusPolicyRuleCondition UserStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyRuleConditions {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Apps: ").Append(Apps).Append("\n");
            sb.Append("  AuthContext: ").Append(AuthContext).Append("\n");
            sb.Append("  AuthProvider: ").Append(AuthProvider).Append("\n");
            sb.Append("  BeforeScheduledAction: ").Append(BeforeScheduledAction).Append("\n");
            sb.Append("  Clients: ").Append(Clients).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  GrantTypes: ").Append(GrantTypes).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  IdentityProvider: ").Append(IdentityProvider).Append("\n");
            sb.Append("  MdmEnrollment: ").Append(MdmEnrollment).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  RiskScore: ").Append(RiskScore).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  UserIdentifier: ").Append(UserIdentifier).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
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
            return this.Equals(input as PasswordPolicyRuleConditions);
        }

        /// <summary>
        /// Returns true if PasswordPolicyRuleConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyRuleConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyRuleConditions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Apps == input.Apps ||
                    (this.Apps != null &&
                    this.Apps.Equals(input.Apps))
                ) && 
                (
                    this.AuthContext == input.AuthContext ||
                    (this.AuthContext != null &&
                    this.AuthContext.Equals(input.AuthContext))
                ) && 
                (
                    this.AuthProvider == input.AuthProvider ||
                    (this.AuthProvider != null &&
                    this.AuthProvider.Equals(input.AuthProvider))
                ) && 
                (
                    this.BeforeScheduledAction == input.BeforeScheduledAction ||
                    (this.BeforeScheduledAction != null &&
                    this.BeforeScheduledAction.Equals(input.BeforeScheduledAction))
                ) && 
                (
                    this.Clients == input.Clients ||
                    (this.Clients != null &&
                    this.Clients.Equals(input.Clients))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.GrantTypes == input.GrantTypes ||
                    (this.GrantTypes != null &&
                    this.GrantTypes.Equals(input.GrantTypes))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
                ) && 
                (
                    this.IdentityProvider == input.IdentityProvider ||
                    (this.IdentityProvider != null &&
                    this.IdentityProvider.Equals(input.IdentityProvider))
                ) && 
                (
                    this.MdmEnrollment == input.MdmEnrollment ||
                    (this.MdmEnrollment != null &&
                    this.MdmEnrollment.Equals(input.MdmEnrollment))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.People == input.People ||
                    (this.People != null &&
                    this.People.Equals(input.People))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
                ) && 
                (
                    this.RiskScore == input.RiskScore ||
                    (this.RiskScore != null &&
                    this.RiskScore.Equals(input.RiskScore))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    (this.Scopes != null &&
                    this.Scopes.Equals(input.Scopes))
                ) && 
                (
                    this.UserIdentifier == input.UserIdentifier ||
                    (this.UserIdentifier != null &&
                    this.UserIdentifier.Equals(input.UserIdentifier))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.UserStatus == input.UserStatus ||
                    (this.UserStatus != null &&
                    this.UserStatus.Equals(input.UserStatus))
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
                
                if (this.App != null)
                {
                    hashCode = (hashCode * 59) + this.App.GetHashCode();
                }
                if (this.Apps != null)
                {
                    hashCode = (hashCode * 59) + this.Apps.GetHashCode();
                }
                if (this.AuthContext != null)
                {
                    hashCode = (hashCode * 59) + this.AuthContext.GetHashCode();
                }
                if (this.AuthProvider != null)
                {
                    hashCode = (hashCode * 59) + this.AuthProvider.GetHashCode();
                }
                if (this.BeforeScheduledAction != null)
                {
                    hashCode = (hashCode * 59) + this.BeforeScheduledAction.GetHashCode();
                }
                if (this.Clients != null)
                {
                    hashCode = (hashCode * 59) + this.Clients.GetHashCode();
                }
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.Device != null)
                {
                    hashCode = (hashCode * 59) + this.Device.GetHashCode();
                }
                if (this.GrantTypes != null)
                {
                    hashCode = (hashCode * 59) + this.GrantTypes.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                if (this.IdentityProvider != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityProvider.GetHashCode();
                }
                if (this.MdmEnrollment != null)
                {
                    hashCode = (hashCode * 59) + this.MdmEnrollment.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.People != null)
                {
                    hashCode = (hashCode * 59) + this.People.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.Risk != null)
                {
                    hashCode = (hashCode * 59) + this.Risk.GetHashCode();
                }
                if (this.RiskScore != null)
                {
                    hashCode = (hashCode * 59) + this.RiskScore.GetHashCode();
                }
                if (this.Scopes != null)
                {
                    hashCode = (hashCode * 59) + this.Scopes.GetHashCode();
                }
                if (this.UserIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.UserIdentifier.GetHashCode();
                }
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
                }
                if (this.UserStatus != null)
                {
                    hashCode = (hashCode * 59) + this.UserStatus.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
