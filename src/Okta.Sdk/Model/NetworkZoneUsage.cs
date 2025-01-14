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
    /// Defines NetworkZoneUsage
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class NetworkZoneUsage : StringEnum
    {
        /// <summary>
        /// StringEnum NetworkZoneUsage for value: BLOCKLIST
        /// </summary>
        public static NetworkZoneUsage BLOCKLIST = new NetworkZoneUsage("BLOCKLIST");
        /// <summary>
        /// StringEnum NetworkZoneUsage for value: POLICY
        /// </summary>
        public static NetworkZoneUsage POLICY = new NetworkZoneUsage("POLICY");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="NetworkZoneUsage"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator NetworkZoneUsage(string value) => new NetworkZoneUsage(value);

        /// <summary>
        /// Creates a new <see cref="NetworkZoneUsage"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public NetworkZoneUsage(string value)
            : base(value)
        {
        }
    }


}
