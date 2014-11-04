//------------------------------------------------------------------------------
// <copyright file="PortletService.cs">
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

namespace Liferay.SDK.Service.V62.Portlet
{
	public class PortletService : ServiceBase
	{
		public PortletService(ISession session)
			: base(session)
		{
		}

		public async Task<IEnumerable<dynamic>> GetWarPortletsAsync()
		{
			var _parameters = new JsonObject();

			var _command = new JsonObject()
			{
				{ "/portlet/get-war-portlets", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<dynamic> UpdatePortletAsync(long companyId, string portletId, string roles, bool active)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("portletId", portletId);
			_parameters.Add("roles", roles);
			_parameters.Add("active", active);

			var _command = new JsonObject()
			{
				{ "/portlet/update-portlet", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}