//------------------------------------------------------------------------------
// <copyright file="AssetTagPropertyService.cs">
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

namespace Liferay.SDK.Service.V62.AssetTagProperty
{
	public class AssetTagPropertyService : ServiceBase
	{
		public AssetTagPropertyService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddTagPropertyAsync(long tagId, string key, string value)
		{
			var _parameters = new JsonObject();

			_parameters.Add("tagId", tagId);
			_parameters.Add("key", key);
			_parameters.Add("value", value);

			var _command = new JsonObject()
			{
				{ "/assettagproperty/add-tag-property", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task DeleteTagPropertyAsync(long tagPropertyId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("tagPropertyId", tagPropertyId);

			var _command = new JsonObject()
			{
				{ "/assettagproperty/delete-tag-property", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IEnumerable<dynamic>> GetTagPropertiesAsync(long tagId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("tagId", tagId);

			var _command = new JsonObject()
			{
				{ "/assettagproperty/get-tag-properties", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetTagPropertyValuesAsync(long companyId, string key)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("key", key);

			var _command = new JsonObject()
			{
				{ "/assettagproperty/get-tag-property-values", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<dynamic> UpdateTagPropertyAsync(long tagPropertyId, string key, string value)
		{
			var _parameters = new JsonObject();

			_parameters.Add("tagPropertyId", tagPropertyId);
			_parameters.Add("key", key);
			_parameters.Add("value", value);

			var _command = new JsonObject()
			{
				{ "/assettagproperty/update-tag-property", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}