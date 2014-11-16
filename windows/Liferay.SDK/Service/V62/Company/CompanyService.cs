//------------------------------------------------------------------------------
// <copyright file="CompanyService.cs">
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

namespace Liferay.SDK.Service.V62.Company
{
	public class CompanyService : ServiceBase
	{
		public CompanyService(ISession session)
			: base(session)
		{
		}

		public async Task DeleteLogoAsync(long companyId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);

			var _command = new JsonObject()
			{
				{ "/company/delete-logo", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> GetCompanyByIdAsync(long companyId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);

			var _command = new JsonObject()
			{
				{ "/company/get-company-by-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetCompanyByLogoIdAsync(long logoId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("logoId", logoId);

			var _command = new JsonObject()
			{
				{ "/company/get-company-by-logo-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetCompanyByMxAsync(string mx)
		{
			var _parameters = new JsonObject();

			_parameters.Add("mx", mx);

			var _command = new JsonObject()
			{
				{ "/company/get-company-by-mx", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetCompanyByVirtualHostAsync(string virtualHost)
		{
			var _parameters = new JsonObject();

			_parameters.Add("virtualHost", virtualHost);

			var _command = new JsonObject()
			{
				{ "/company/get-company-by-virtual-host", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetCompanyByWebIdAsync(string webId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("webId", webId);

			var _command = new JsonObject()
			{
				{ "/company/get-company-by-web-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateCompanyAsync(long companyId, string virtualHost, string mx, string homeURL, string name, string legalName, string legalId, string legalType, string sicCode, string tickerSymbol, string industry, string type, string size)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("virtualHost", virtualHost);
			_parameters.Add("mx", mx);
			_parameters.Add("homeURL", homeURL);
			_parameters.Add("name", name);
			_parameters.Add("legalName", legalName);
			_parameters.Add("legalId", legalId);
			_parameters.Add("legalType", legalType);
			_parameters.Add("sicCode", sicCode);
			_parameters.Add("tickerSymbol", tickerSymbol);
			_parameters.Add("industry", industry);
			_parameters.Add("type", type);
			_parameters.Add("size", size);

			var _command = new JsonObject()
			{
				{ "/company/update-company", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateCompanyAsync(long companyId, string virtualHost, string mx, int maxUsers, bool active)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("virtualHost", virtualHost);
			_parameters.Add("mx", mx);
			_parameters.Add("maxUsers", maxUsers);
			_parameters.Add("active", active);

			var _command = new JsonObject()
			{
				{ "/company/update-company", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task UpdateDisplayAsync(long companyId, string languageId, string timeZoneId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("languageId", languageId);
			_parameters.Add("timeZoneId", timeZoneId);

			var _command = new JsonObject()
			{
				{ "/company/update-display", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> UpdateLogoAsync(long companyId, byte[] bytes)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("bytes", bytes);

			var _command = new JsonObject()
			{
				{ "/company/update-logo", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}