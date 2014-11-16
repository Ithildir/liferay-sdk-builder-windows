//------------------------------------------------------------------------------
// <copyright file="DLFileEntryService.cs">
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

namespace Liferay.SDK.Service.V62.DLFileEntry
{
	public class DLFileEntryService : ServiceBase
	{
		public DLFileEntryService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> CancelCheckOutAsync(long fileEntryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/cancel-check-out", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task CheckInFileEntryAsync(long fileEntryId, string lockUuid)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("lockUuid", lockUuid);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/check-in-file-entry", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task CheckInFileEntryAsync(long fileEntryId, string lockUuid, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("lockUuid", lockUuid);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/check-in-file-entry", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task CheckInFileEntryAsync(long fileEntryId, bool major, string changeLog, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("major", major);
			_parameters.Add("changeLog", changeLog);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/check-in-file-entry", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> CheckOutFileEntryAsync(long fileEntryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/check-out-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> CheckOutFileEntryAsync(long fileEntryId, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/check-out-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> CheckOutFileEntryAsync(long fileEntryId, string owner, long expirationTime)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("owner", owner);
			_parameters.Add("expirationTime", expirationTime);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/check-out-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> CheckOutFileEntryAsync(long fileEntryId, string owner, long expirationTime, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("owner", owner);
			_parameters.Add("expirationTime", expirationTime);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/check-out-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> CopyFileEntryAsync(long groupId, long repositoryId, long fileEntryId, long destFolderId, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("repositoryId", repositoryId);
			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("destFolderId", destFolderId);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/copy-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task DeleteFileEntryAsync(long fileEntryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/delete-file-entry", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteFileEntryAsync(long groupId, long folderId, string title)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("title", title);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/delete-file-entry", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteFileVersionAsync(long fileEntryId, string version)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("version", version);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/delete-file-version", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> FetchFileEntryByImageIdAsync(long imageId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("imageId", imageId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/fetch-file-entry-by-image-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetFileEntriesAsync(long groupId, long folderId, int start, int end, JsonObjectWrapper obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "obc", "com.liferay.portal.kernel.util.OrderByComparator", obc);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetFileEntriesAsync(long groupId, long folderId, long fileEntryTypeId, int start, int end, JsonObjectWrapper obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("fileEntryTypeId", fileEntryTypeId);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "obc", "com.liferay.portal.kernel.util.OrderByComparator", obc);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetFileEntriesAsync(long groupId, long folderId, IEnumerable<string> mimeTypes, int start, int end, JsonObjectWrapper obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("mimeTypes", mimeTypes);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "obc", "com.liferay.portal.kernel.util.OrderByComparator", obc);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetFileEntriesAsync(long groupId, long folderId, int status, int start, int end, JsonObjectWrapper obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("status", status);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "obc", "com.liferay.portal.kernel.util.OrderByComparator", obc);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<long> GetFileEntriesCountAsync(long groupId, long folderId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> GetFileEntriesCountAsync(long groupId, long folderId, long fileEntryTypeId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("fileEntryTypeId", fileEntryTypeId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> GetFileEntriesCountAsync(long groupId, long folderId, IEnumerable<string> mimeTypes)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("mimeTypes", mimeTypes);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> GetFileEntriesCountAsync(long groupId, long folderId, int status)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("status", status);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entries-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<dynamic> GetFileEntryAsync(long fileEntryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetFileEntryAsync(long groupId, long folderId, string title)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("title", title);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetFileEntryByUuidAndGroupIdAsync(string uuid, long groupId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("uuid", uuid);
			_parameters.Add("groupId", groupId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entry-by-uuid-and-group-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetFileEntryLockAsync(long fileEntryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-file-entry-lock", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<long> GetFoldersFileEntriesCountAsync(long groupId, IEnumerable<object> folderIds, int status)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("folderIds", folderIds);
			_parameters.Add("status", status);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-folders-file-entries-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetGroupFileEntriesAsync(long groupId, long userId, long rootFolderId, int start, int end, JsonObjectWrapper obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userId", userId);
			_parameters.Add("rootFolderId", rootFolderId);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "obc", "com.liferay.portal.kernel.util.OrderByComparator", obc);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-group-file-entries", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetGroupFileEntriesAsync(long groupId, long userId, long rootFolderId, IEnumerable<string> mimeTypes, int status, int start, int end, JsonObjectWrapper obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userId", userId);
			_parameters.Add("rootFolderId", rootFolderId);
			_parameters.Add("mimeTypes", mimeTypes);
			_parameters.Add("status", status);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "obc", "com.liferay.portal.kernel.util.OrderByComparator", obc);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-group-file-entries", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<long> GetGroupFileEntriesCountAsync(long groupId, long userId, long rootFolderId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userId", userId);
			_parameters.Add("rootFolderId", rootFolderId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-group-file-entries-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> GetGroupFileEntriesCountAsync(long groupId, long userId, long rootFolderId, IEnumerable<string> mimeTypes, int status)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userId", userId);
			_parameters.Add("rootFolderId", rootFolderId);
			_parameters.Add("mimeTypes", mimeTypes);
			_parameters.Add("status", status);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/get-group-file-entries-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<bool> HasFileEntryLockAsync(long fileEntryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/has-file-entry-lock", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (bool)_obj;
		}

		public async Task<bool> IsFileEntryCheckedOutAsync(long fileEntryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/is-file-entry-checked-out", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (bool)_obj;
		}

		public async Task<dynamic> MoveFileEntryAsync(long fileEntryId, long newFolderId, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("newFolderId", newFolderId);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/move-file-entry", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> RefreshFileEntryLockAsync(string lockUuid, long companyId, long expirationTime)
		{
			var _parameters = new JsonObject();

			_parameters.Add("lockUuid", lockUuid);
			_parameters.Add("companyId", companyId);
			_parameters.Add("expirationTime", expirationTime);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/refresh-file-entry-lock", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task RevertFileEntryAsync(long fileEntryId, string version, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("version", version);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/revert-file-entry", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> SearchAsync(long groupId, long creatorUserId, int status, int start, int end)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("creatorUserId", creatorUserId);
			_parameters.Add("status", status);
			_parameters.Add("start", start);
			_parameters.Add("end", end);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/search", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> SearchAsync(long groupId, long creatorUserId, long folderId, IEnumerable<string> mimeTypes, int status, int start, int end)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("creatorUserId", creatorUserId);
			_parameters.Add("folderId", folderId);
			_parameters.Add("mimeTypes", mimeTypes);
			_parameters.Add("status", status);
			_parameters.Add("start", start);
			_parameters.Add("end", end);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/search", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<bool> VerifyFileEntryCheckOutAsync(long fileEntryId, string lockUuid)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("lockUuid", lockUuid);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/verify-file-entry-check-out", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (bool)_obj;
		}

		public async Task<bool> VerifyFileEntryLockAsync(long fileEntryId, string lockUuid)
		{
			var _parameters = new JsonObject();

			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("lockUuid", lockUuid);

			var _command = new JsonObject()
			{
				{ "/dlfileentry/verify-file-entry-lock", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (bool)_obj;
		}
	}
}