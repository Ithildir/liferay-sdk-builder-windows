//------------------------------------------------------------------------------
// <copyright file="ClassNameService.cs">
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

namespace Liferay.SDK.Service.V62.ClassName
{
	public class ClassNameService : ServiceBase
	{
		public ClassNameService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> FetchClassNameAsync(string value)
		{
			var _parameters = new JsonObject();

			_parameters.Add("value", value);

			var _command = new JsonObject()
			{
				{ "/classname/fetch-class-name", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<long> FetchClassNameIdAsync(IDictionary<string, object> clazz)
		{
			var _parameters = new JsonObject();

			_parameters.Add("clazz", clazz);

			var _command = new JsonObject()
			{
				{ "/classname/fetch-class-name-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> FetchClassNameIdAsync(string value)
		{
			var _parameters = new JsonObject();

			_parameters.Add("value", value);

			var _command = new JsonObject()
			{
				{ "/classname/fetch-class-name-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}
	}
}