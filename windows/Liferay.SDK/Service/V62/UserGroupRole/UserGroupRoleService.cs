//------------------------------------------------------------------------------
// <copyright file="UserGroupRoleService.cs">
//    Copyright (c) 2014 Andrea Di Giorgi. All rights reserved.
//
//    This library is free software; you can redistribute it and/or modify it
//    under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation; either version 2.1 of the License, or (at
//    your option) any later version.
//
//    This library is distributed in the hope that it will be useful, but
//    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
//    or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public
//    License for more details.
// </copyright>
// <author>Andrea Di Giorgi</author>
// <website>https://github.com/Ithildir/liferay-sdk-builder-windows</website>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Liferay.SDK.Service.V62.UserGroupRole
{
	public class UserGroupRoleService : ServiceBase
	{
		public UserGroupRoleService(ISession session)
			: base(session)
		{
		}

		public async Task AddUserGroupRolesAsync(long userId, long groupId, IEnumerable<long> roleIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("groupId", groupId);
			_parameters.Add("roleIds", roleIds);

			var _command = new JsonObject()
			{
				{ "/usergrouprole/add-user-group-roles", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task AddUserGroupRolesAsync(IEnumerable<long> userIds, long groupId, long roleId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userIds", userIds);
			_parameters.Add("groupId", groupId);
			_parameters.Add("roleId", roleId);

			var _command = new JsonObject()
			{
				{ "/usergrouprole/add-user-group-roles", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteUserGroupRolesAsync(long userId, long groupId, IEnumerable<long> roleIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("groupId", groupId);
			_parameters.Add("roleIds", roleIds);

			var _command = new JsonObject()
			{
				{ "/usergrouprole/delete-user-group-roles", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteUserGroupRolesAsync(IEnumerable<long> userIds, long groupId, long roleId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userIds", userIds);
			_parameters.Add("groupId", groupId);
			_parameters.Add("roleId", roleId);

			var _command = new JsonObject()
			{
				{ "/usergrouprole/delete-user-group-roles", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}
	}
}