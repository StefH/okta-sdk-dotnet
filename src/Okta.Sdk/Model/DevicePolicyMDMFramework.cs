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
    /// Defines DevicePolicyMDMFramework
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class DevicePolicyMDMFramework : StringEnum
    {
        /// <summary>
        /// StringEnum DevicePolicyMDMFramework for value: AFW
        /// </summary>
        public static DevicePolicyMDMFramework AFW = new DevicePolicyMDMFramework("AFW");
        /// <summary>
        /// StringEnum DevicePolicyMDMFramework for value: NATIVE
        /// </summary>
        public static DevicePolicyMDMFramework NATIVE = new DevicePolicyMDMFramework("NATIVE");
        /// <summary>
        /// StringEnum DevicePolicyMDMFramework for value: SAFE
        /// </summary>
        public static DevicePolicyMDMFramework SAFE = new DevicePolicyMDMFramework("SAFE");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="DevicePolicyMDMFramework"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator DevicePolicyMDMFramework(string value) => new DevicePolicyMDMFramework(value);

        /// <summary>
        /// Creates a new <see cref="DevicePolicyMDMFramework"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public DevicePolicyMDMFramework(string value)
            : base(value)
        {
        }
    }


}
