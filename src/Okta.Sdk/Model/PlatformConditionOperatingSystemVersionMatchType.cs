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
    /// Defines PlatformConditionOperatingSystemVersionMatchType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class PlatformConditionOperatingSystemVersionMatchType : StringEnum
    {
        /// <summary>
        /// StringEnum PlatformConditionOperatingSystemVersionMatchType for value: EXPRESSION
        /// </summary>
        public static PlatformConditionOperatingSystemVersionMatchType EXPRESSION = new PlatformConditionOperatingSystemVersionMatchType("EXPRESSION");
        /// <summary>
        /// StringEnum PlatformConditionOperatingSystemVersionMatchType for value: SEMVER
        /// </summary>
        public static PlatformConditionOperatingSystemVersionMatchType SEMVER = new PlatformConditionOperatingSystemVersionMatchType("SEMVER");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="PlatformConditionOperatingSystemVersionMatchType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator PlatformConditionOperatingSystemVersionMatchType(string value) => new PlatformConditionOperatingSystemVersionMatchType(value);

        /// <summary>
        /// Creates a new <see cref="PlatformConditionOperatingSystemVersionMatchType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public PlatformConditionOperatingSystemVersionMatchType(string value)
            : base(value)
        {
        }
    }


}
