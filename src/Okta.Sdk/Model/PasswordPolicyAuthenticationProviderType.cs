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
    /// Defines PasswordPolicyAuthenticationProviderType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class PasswordPolicyAuthenticationProviderType : StringEnum
    {
        /// <summary>
        /// StringEnum PasswordPolicyAuthenticationProviderType for value: ACTIVE_DIRECTORY
        /// </summary>
        public static PasswordPolicyAuthenticationProviderType ACTIVEDIRECTORY = new PasswordPolicyAuthenticationProviderType("ACTIVE_DIRECTORY");
        /// <summary>
        /// StringEnum PasswordPolicyAuthenticationProviderType for value: ANY
        /// </summary>
        public static PasswordPolicyAuthenticationProviderType ANY = new PasswordPolicyAuthenticationProviderType("ANY");
        /// <summary>
        /// StringEnum PasswordPolicyAuthenticationProviderType for value: LDAP
        /// </summary>
        public static PasswordPolicyAuthenticationProviderType LDAP = new PasswordPolicyAuthenticationProviderType("LDAP");
        /// <summary>
        /// StringEnum PasswordPolicyAuthenticationProviderType for value: OKTA
        /// </summary>
        public static PasswordPolicyAuthenticationProviderType OKTA = new PasswordPolicyAuthenticationProviderType("OKTA");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="PasswordPolicyAuthenticationProviderType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator PasswordPolicyAuthenticationProviderType(string value) => new PasswordPolicyAuthenticationProviderType(value);

        /// <summary>
        /// Creates a new <see cref="PasswordPolicyAuthenticationProviderType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public PasswordPolicyAuthenticationProviderType(string value)
            : base(value)
        {
        }
    }


}
