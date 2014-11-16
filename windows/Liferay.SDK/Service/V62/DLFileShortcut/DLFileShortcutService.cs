//------------------------------------------------------------------------------
// <copyright file="DLFileShortcutService.cs">
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

namespace Liferay.SDK.Service.V62.DLFileShortcut
{
	public class DLFileShortcutService : ServiceBase
	{
		public DLFileShortcutService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddFileShortcutAsync(long groupId, long folderId, long toFileEntryId, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("toFileEntryId", toFileEntryId);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileshortcut/add-file-shortcut", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task DeleteFileShortcutAsync(long fileShortcutId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileShortcutId", fileShortcutId);

			var _command = new JsonObject()
			{
				{ "/dlfileshortcut/delete-file-shortcut", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> GetFileShortcutAsync(long fileShortcutId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileShortcutId", fileShortcutId);

			var _command = new JsonObject()
			{
				{ "/dlfileshortcut/get-file-shortcut", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateFileShortcutAsync(long fileShortcutId, long folderId, long toFileEntryId, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileShortcutId", fileShortcutId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("toFileEntryId", toFileEntryId);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileshortcut/update-file-shortcut", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}