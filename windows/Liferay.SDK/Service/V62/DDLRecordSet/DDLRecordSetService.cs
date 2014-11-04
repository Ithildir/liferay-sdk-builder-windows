//------------------------------------------------------------------------------
// <copyright file="DDLRecordSetService.cs">
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

namespace Liferay.SDK.Service.V62.DDLRecordSet
{
	public class DDLRecordSetService : ServiceBase
	{
		public DDLRecordSetService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddRecordSetAsync(long groupId, long ddmStructureId, string recordSetKey, IDictionary<string, string> nameMap, IDictionary<string, string> descriptionMap, int minDisplayRows, int scope, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("ddmStructureId", ddmStructureId);
			_parameters.Add("recordSetKey", recordSetKey);
			_parameters.Add("nameMap", nameMap);
			_parameters.Add("descriptionMap", descriptionMap);
			_parameters.Add("minDisplayRows", minDisplayRows);
			_parameters.Add("scope", scope);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/add-record-set", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task DeleteRecordSetAsync(long recordSetId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("recordSetId", recordSetId);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/delete-record-set", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> GetRecordSetAsync(long recordSetId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("recordSetId", recordSetId);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/get-record-set", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<IEnumerable<dynamic>> SearchAsync(long companyId, long groupId, string keywords, int scope, int start, int end, JsonObjectWrapper orderByComparator)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupId", groupId);
			_parameters.Add("keywords", keywords);
			_parameters.Add("scope", scope);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "orderByComparator", "com.liferay.portal.kernel.util.OrderByComparator", orderByComparator);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/search", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<IEnumerable<dynamic>> SearchAsync(long companyId, long groupId, string name, string description, int scope, bool andOperator, int start, int end, JsonObjectWrapper orderByComparator)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupId", groupId);
			_parameters.Add("name", name);
			_parameters.Add("description", description);
			_parameters.Add("scope", scope);
			_parameters.Add("andOperator", andOperator);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			this.MangleWrapper(_parameters, "orderByComparator", "com.liferay.portal.kernel.util.OrderByComparator", orderByComparator);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/search", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<long> SearchCountAsync(long companyId, long groupId, string keywords, int scope)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupId", groupId);
			_parameters.Add("keywords", keywords);
			_parameters.Add("scope", scope);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/search-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> SearchCountAsync(long companyId, long groupId, string name, string description, int scope, bool andOperator)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupId", groupId);
			_parameters.Add("name", name);
			_parameters.Add("description", description);
			_parameters.Add("scope", scope);
			_parameters.Add("andOperator", andOperator);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/search-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<dynamic> UpdateMinDisplayRowsAsync(long recordSetId, int minDisplayRows, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("recordSetId", recordSetId);
			_parameters.Add("minDisplayRows", minDisplayRows);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/update-min-display-rows", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateRecordSetAsync(long recordSetId, long ddmStructureId, IDictionary<string, string> nameMap, IDictionary<string, string> descriptionMap, int minDisplayRows, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("recordSetId", recordSetId);
			_parameters.Add("ddmStructureId", ddmStructureId);
			_parameters.Add("nameMap", nameMap);
			_parameters.Add("descriptionMap", descriptionMap);
			_parameters.Add("minDisplayRows", minDisplayRows);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/update-record-set", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateRecordSetAsync(long groupId, long ddmStructureId, string recordSetKey, IDictionary<string, string> nameMap, IDictionary<string, string> descriptionMap, int minDisplayRows, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("ddmStructureId", ddmStructureId);
			_parameters.Add("recordSetKey", recordSetKey);
			_parameters.Add("nameMap", nameMap);
			_parameters.Add("descriptionMap", descriptionMap);
			_parameters.Add("minDisplayRows", minDisplayRows);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/ddlrecordset/update-record-set", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}