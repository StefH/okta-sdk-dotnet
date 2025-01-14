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
    /// Defines EventHookVerificationStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class EventHookVerificationStatus : StringEnum
    {
        /// <summary>
        /// StringEnum EventHookVerificationStatus for value: UNVERIFIED
        /// </summary>
        public static EventHookVerificationStatus UNVERIFIED = new EventHookVerificationStatus("UNVERIFIED");
        /// <summary>
        /// StringEnum EventHookVerificationStatus for value: VERIFIED
        /// </summary>
        public static EventHookVerificationStatus VERIFIED = new EventHookVerificationStatus("VERIFIED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="EventHookVerificationStatus"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator EventHookVerificationStatus(string value) => new EventHookVerificationStatus(value);

        /// <summary>
        /// Creates a new <see cref="EventHookVerificationStatus"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public EventHookVerificationStatus(string value)
            : base(value)
        {
        }
    }


}
