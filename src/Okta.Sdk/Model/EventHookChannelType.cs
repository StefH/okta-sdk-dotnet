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
    /// Defines EventHookChannelType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class EventHookChannelType : StringEnum
    {
        /// <summary>
        /// StringEnum EventHookChannelType for value: HTTP
        /// </summary>
        public static EventHookChannelType HTTP = new EventHookChannelType("HTTP");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="EventHookChannelType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator EventHookChannelType(string value) => new EventHookChannelType(value);

        /// <summary>
        /// Creates a new <see cref="EventHookChannelType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public EventHookChannelType(string value)
            : base(value)
        {
        }
    }


}