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
    /// Defines SessionAuthenticationMethod
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class SessionAuthenticationMethod : StringEnum
    {
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: fpt
        /// </summary>
        public static SessionAuthenticationMethod Fpt = new SessionAuthenticationMethod("fpt");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: geo
        /// </summary>
        public static SessionAuthenticationMethod Geo = new SessionAuthenticationMethod("geo");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: hwk
        /// </summary>
        public static SessionAuthenticationMethod Hwk = new SessionAuthenticationMethod("hwk");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: kba
        /// </summary>
        public static SessionAuthenticationMethod Kba = new SessionAuthenticationMethod("kba");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: mca
        /// </summary>
        public static SessionAuthenticationMethod Mca = new SessionAuthenticationMethod("mca");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: mfa
        /// </summary>
        public static SessionAuthenticationMethod Mfa = new SessionAuthenticationMethod("mfa");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: otp
        /// </summary>
        public static SessionAuthenticationMethod Otp = new SessionAuthenticationMethod("otp");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: pwd
        /// </summary>
        public static SessionAuthenticationMethod Pwd = new SessionAuthenticationMethod("pwd");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: sc
        /// </summary>
        public static SessionAuthenticationMethod Sc = new SessionAuthenticationMethod("sc");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: sms
        /// </summary>
        public static SessionAuthenticationMethod Sms = new SessionAuthenticationMethod("sms");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: swk
        /// </summary>
        public static SessionAuthenticationMethod Swk = new SessionAuthenticationMethod("swk");
        /// <summary>
        /// StringEnum SessionAuthenticationMethod for value: tel
        /// </summary>
        public static SessionAuthenticationMethod Tel = new SessionAuthenticationMethod("tel");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="SessionAuthenticationMethod"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator SessionAuthenticationMethod(string value) => new SessionAuthenticationMethod(value);

        /// <summary>
        /// Creates a new <see cref="SessionAuthenticationMethod"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public SessionAuthenticationMethod(string value)
            : base(value)
        {
        }
    }


}
