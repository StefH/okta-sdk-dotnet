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
    /// Agent types that are being monitored
    /// </summary>
    /// <value>Agent types that are being monitored</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class AgentType : StringEnum
    {
        /// <summary>
        /// StringEnum AgentType for value: AD
        /// </summary>
        public static AgentType AD = new AgentType("AD");
        /// <summary>
        /// StringEnum AgentType for value: IWA
        /// </summary>
        public static AgentType IWA = new AgentType("IWA");
        /// <summary>
        /// StringEnum AgentType for value: LDAP
        /// </summary>
        public static AgentType LDAP = new AgentType("LDAP");
        /// <summary>
        /// StringEnum AgentType for value: MFA
        /// </summary>
        public static AgentType MFA = new AgentType("MFA");
        /// <summary>
        /// StringEnum AgentType for value: OPP
        /// </summary>
        public static AgentType OPP = new AgentType("OPP");
        /// <summary>
        /// StringEnum AgentType for value: RUM
        /// </summary>
        public static AgentType RUM = new AgentType("RUM");
        /// <summary>
        /// StringEnum AgentType for value: Radius
        /// </summary>
        public static AgentType Radius = new AgentType("Radius");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="AgentType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator AgentType(string value) => new AgentType(value);

        /// <summary>
        /// Creates a new <see cref="AgentType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public AgentType(string value)
            : base(value)
        {
        }
    }


}
