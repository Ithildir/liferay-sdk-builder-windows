//------------------------------------------------------------------------------
// <copyright file="UserGroupRoleService.cs">
//    Copyright (c) 2014-present Andrea Di Giorgi
//
//    Permission is hereby granted, free of charge, to any person obtaining a
//    copy of this software and associated documentation files (the "Software"),
//    to deal in the Software without restriction, including without limitation
//    the rights to use, copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following conditions:
//
//    The above copyright notice and this permission notice shall be included in
//    all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//    THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
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