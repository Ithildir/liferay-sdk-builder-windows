//------------------------------------------------------------------------------
// <copyright file="RepositoryService.cs">
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

namespace Liferay.SDK.Service.V62.Repository
{
	public class RepositoryService : ServiceBase
	{
		public RepositoryService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddRepositoryAsync(long groupId, long classNameId, long parentFolderId, string name, string description, string portletId, JsonObjectWrapper typeSettingsProperties, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("classNameId", classNameId);
			_parameters.Add("parentFolderId", parentFolderId);
			_parameters.Add("name", name);
			_parameters.Add("description", description);
			_parameters.Add("portletId", portletId);
			this.MangleWrapper(_parameters, "typeSettingsProperties", "com.liferay.portal.kernel.util.UnicodeProperties", typeSettingsProperties);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/repository/add-repository", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task CheckRepositoryAsync(long repositoryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("repositoryId", repositoryId);

			var _command = new JsonObject()
			{
				{ "/repository/check-repository", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteRepositoryAsync(long repositoryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("repositoryId", repositoryId);

			var _command = new JsonObject()
			{
				{ "/repository/delete-repository", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> GetLocalRepositoryImplAsync(long repositoryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("repositoryId", repositoryId);

			var _command = new JsonObject()
			{
				{ "/repository/get-local-repository-impl", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetLocalRepositoryImplAsync(long folderId, long fileEntryId, long fileVersionId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("folderId", folderId);
			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("fileVersionId", fileVersionId);

			var _command = new JsonObject()
			{
				{ "/repository/get-local-repository-impl", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetRepositoryAsync(long repositoryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("repositoryId", repositoryId);

			var _command = new JsonObject()
			{
				{ "/repository/get-repository", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetRepositoryImplAsync(long repositoryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("repositoryId", repositoryId);

			var _command = new JsonObject()
			{
				{ "/repository/get-repository-impl", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetRepositoryImplAsync(long folderId, long fileEntryId, long fileVersionId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("folderId", folderId);
			_parameters.Add("fileEntryId", fileEntryId);
			_parameters.Add("fileVersionId", fileVersionId);

			var _command = new JsonObject()
			{
				{ "/repository/get-repository-impl", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<IEnumerable<string>> GetSupportedConfigurationsAsync(long classNameId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("classNameId", classNameId);

			var _command = new JsonObject()
			{
				{ "/repository/get-supported-configurations", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			var _jsonArray = (JsonArray)_obj;

			return _jsonArray.Cast<string>();
		}

		public async Task<IEnumerable<string>> GetSupportedParametersAsync(long classNameId, string configuration)
		{
			var _parameters = new JsonObject();

			_parameters.Add("classNameId", classNameId);
			_parameters.Add("configuration", configuration);

			var _command = new JsonObject()
			{
				{ "/repository/get-supported-parameters", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			var _jsonArray = (JsonArray)_obj;

			return _jsonArray.Cast<string>();
		}

		public async Task<dynamic> GetTypeSettingsPropertiesAsync(long repositoryId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("repositoryId", repositoryId);

			var _command = new JsonObject()
			{
				{ "/repository/get-type-settings-properties", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task UpdateRepositoryAsync(long repositoryId, string name, string description)
		{
			var _parameters = new JsonObject();

			_parameters.Add("repositoryId", repositoryId);
			_parameters.Add("name", name);
			_parameters.Add("description", description);

			var _command = new JsonObject()
			{
				{ "/repository/update-repository", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}
	}
}