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
    /// Defines PolicyType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class PolicyType : StringEnum
    {
        /// <summary>
        /// StringEnum PolicyType for value: ACCESS_POLICY
        /// </summary>
        public static PolicyType ACCESSPOLICY = new PolicyType("ACCESS_POLICY");
        /// <summary>
        /// StringEnum PolicyType for value: IDP_DISCOVERY
        /// </summary>
        public static PolicyType IDPDISCOVERY = new PolicyType("IDP_DISCOVERY");
        /// <summary>
        /// StringEnum PolicyType for value: MFA_ENROLL
        /// </summary>
        public static PolicyType MFAENROLL = new PolicyType("MFA_ENROLL");
        /// <summary>
        /// StringEnum PolicyType for value: OAUTH_AUTHORIZATION_POLICY
        /// </summary>
        public static PolicyType OAUTHAUTHORIZATIONPOLICY = new PolicyType("OAUTH_AUTHORIZATION_POLICY");
        /// <summary>
        /// StringEnum PolicyType for value: OKTA_SIGN_ON
        /// </summary>
        public static PolicyType OKTASIGNON = new PolicyType("OKTA_SIGN_ON");
        /// <summary>
        /// StringEnum PolicyType for value: PASSWORD
        /// </summary>
        public static PolicyType PASSWORD = new PolicyType("PASSWORD");
        /// <summary>
        /// StringEnum PolicyType for value: PROFILE_ENROLLMENT
        /// </summary>
        public static PolicyType PROFILEENROLLMENT = new PolicyType("PROFILE_ENROLLMENT");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="PolicyType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator PolicyType(string value) => new PolicyType(value);

        /// <summary>
        /// Creates a new <see cref="PolicyType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public PolicyType(string value)
            : base(value)
        {
        }
    }


}
