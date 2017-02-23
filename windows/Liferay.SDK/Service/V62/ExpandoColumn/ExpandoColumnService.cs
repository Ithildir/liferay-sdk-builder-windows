//------------------------------------------------------------------------------
// <copyright file="ExpandoColumnService.cs">
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

namespace Liferay.SDK.Service.V62.ExpandoColumn
{
	public class ExpandoColumnService : ServiceBase
	{
		public ExpandoColumnService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddColumnAsync(long tableId, string name, int type)
		{
			var _parameters = new JsonObject();

			_parameters.Add("tableId", tableId);
			_parameters.Add("name", name);
			_parameters.Add("type", type);

			var _command = new JsonObject()
			{
				{ "/expandocolumn/add-column", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> AddColumnAsync(long tableId, string name, int type, IDictionary<string, object> defaultData)
		{
			var _parameters = new JsonObject();

			_parameters.Add("tableId", tableId);
			_parameters.Add("name", name);
			_parameters.Add("type", type);
			_parameters.Add("defaultData", defaultData);

			var _command = new JsonObject()
			{
				{ "/expandocolumn/add-column", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task DeleteColumnAsync(long columnId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("columnId", columnId);

			var _command = new JsonObject()
			{
				{ "/expandocolumn/delete-column", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> UpdateColumnAsync(long columnId, string name, int type)
		{
			var _parameters = new JsonObject();

			_parameters.Add("columnId", columnId);
			_parameters.Add("name", name);
			_parameters.Add("type", type);

			var _command = new JsonObject()
			{
				{ "/expandocolumn/update-column", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateColumnAsync(long columnId, string name, int type, IDictionary<string, object> defaultData)
		{
			var _parameters = new JsonObject();

			_parameters.Add("columnId", columnId);
			_parameters.Add("name", name);
			_parameters.Add("type", type);
			_parameters.Add("defaultData", defaultData);

			var _command = new JsonObject()
			{
				{ "/expandocolumn/update-column", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateTypeSettingsAsync(long columnId, string typeSettings)
		{
			var _parameters = new JsonObject();

			_parameters.Add("columnId", columnId);
			_parameters.Add("typeSettings", typeSettings);

			var _command = new JsonObject()
			{
				{ "/expandocolumn/update-type-settings", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}