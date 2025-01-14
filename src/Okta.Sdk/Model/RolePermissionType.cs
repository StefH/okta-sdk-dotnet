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
    /// Defines RolePermissionType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class RolePermissionType : StringEnum
    {
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.apps.assignment.manage
        /// </summary>
        public static RolePermissionType AppsAssignmentManage = new RolePermissionType("okta.apps.assignment.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.apps.manage
        /// </summary>
        public static RolePermissionType AppsManage = new RolePermissionType("okta.apps.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.apps.manageFirstPartyApps
        /// </summary>
        public static RolePermissionType AppsManageFirstPartyApps = new RolePermissionType("okta.apps.manageFirstPartyApps");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.apps.read
        /// </summary>
        public static RolePermissionType AppsRead = new RolePermissionType("okta.apps.read");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.authzServers.manage
        /// </summary>
        public static RolePermissionType AuthzServersManage = new RolePermissionType("okta.authzServers.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.authzServers.read
        /// </summary>
        public static RolePermissionType AuthzServersRead = new RolePermissionType("okta.authzServers.read");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.customizations.manage
        /// </summary>
        public static RolePermissionType CustomizationsManage = new RolePermissionType("okta.customizations.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.customizations.read
        /// </summary>
        public static RolePermissionType CustomizationsRead = new RolePermissionType("okta.customizations.read");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.governance.accessCertifications.manage
        /// </summary>
        public static RolePermissionType GovernanceAccessCertificationsManage = new RolePermissionType("okta.governance.accessCertifications.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.governance.accessRequests.manage
        /// </summary>
        public static RolePermissionType GovernanceAccessRequestsManage = new RolePermissionType("okta.governance.accessRequests.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.groups.appAssignment.manage
        /// </summary>
        public static RolePermissionType GroupsAppAssignmentManage = new RolePermissionType("okta.groups.appAssignment.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.groups.create
        /// </summary>
        public static RolePermissionType GroupsCreate = new RolePermissionType("okta.groups.create");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.groups.manage
        /// </summary>
        public static RolePermissionType GroupsManage = new RolePermissionType("okta.groups.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.groups.members.manage
        /// </summary>
        public static RolePermissionType GroupsMembersManage = new RolePermissionType("okta.groups.members.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.groups.read
        /// </summary>
        public static RolePermissionType GroupsRead = new RolePermissionType("okta.groups.read");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.profilesources.import.run
        /// </summary>
        public static RolePermissionType ProfilesourcesImportRun = new RolePermissionType("okta.profilesources.import.run");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.appAssignment.manage
        /// </summary>
        public static RolePermissionType UsersAppAssignmentManage = new RolePermissionType("okta.users.appAssignment.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.create
        /// </summary>
        public static RolePermissionType UsersCreate = new RolePermissionType("okta.users.create");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.credentials.expirePassword
        /// </summary>
        public static RolePermissionType UsersCredentialsExpirePassword = new RolePermissionType("okta.users.credentials.expirePassword");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.credentials.manage
        /// </summary>
        public static RolePermissionType UsersCredentialsManage = new RolePermissionType("okta.users.credentials.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.credentials.resetFactors
        /// </summary>
        public static RolePermissionType UsersCredentialsResetFactors = new RolePermissionType("okta.users.credentials.resetFactors");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.credentials.resetPassword
        /// </summary>
        public static RolePermissionType UsersCredentialsResetPassword = new RolePermissionType("okta.users.credentials.resetPassword");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.groupMembership.manage
        /// </summary>
        public static RolePermissionType UsersGroupMembershipManage = new RolePermissionType("okta.users.groupMembership.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.activate
        /// </summary>
        public static RolePermissionType UsersLifecycleActivate = new RolePermissionType("okta.users.lifecycle.activate");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.clearSessions
        /// </summary>
        public static RolePermissionType UsersLifecycleClearSessions = new RolePermissionType("okta.users.lifecycle.clearSessions");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.deactivate
        /// </summary>
        public static RolePermissionType UsersLifecycleDeactivate = new RolePermissionType("okta.users.lifecycle.deactivate");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.delete
        /// </summary>
        public static RolePermissionType UsersLifecycleDelete = new RolePermissionType("okta.users.lifecycle.delete");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.manage
        /// </summary>
        public static RolePermissionType UsersLifecycleManage = new RolePermissionType("okta.users.lifecycle.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.suspend
        /// </summary>
        public static RolePermissionType UsersLifecycleSuspend = new RolePermissionType("okta.users.lifecycle.suspend");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.unlock
        /// </summary>
        public static RolePermissionType UsersLifecycleUnlock = new RolePermissionType("okta.users.lifecycle.unlock");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.lifecycle.unsuspend
        /// </summary>
        public static RolePermissionType UsersLifecycleUnsuspend = new RolePermissionType("okta.users.lifecycle.unsuspend");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.manage
        /// </summary>
        public static RolePermissionType UsersManage = new RolePermissionType("okta.users.manage");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.read
        /// </summary>
        public static RolePermissionType UsersRead = new RolePermissionType("okta.users.read");
        /// <summary>
        /// StringEnum RolePermissionType for value: okta.users.userprofile.manage
        /// </summary>
        public static RolePermissionType UsersUserprofileManage = new RolePermissionType("okta.users.userprofile.manage");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="RolePermissionType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator RolePermissionType(string value) => new RolePermissionType(value);

        /// <summary>
        /// Creates a new <see cref="RolePermissionType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public RolePermissionType(string value)
            : base(value)
        {
        }
    }


}
