//------------------------------------------------------------------------------
// <copyright file="LayoutRevisionService.cs">
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

namespace Liferay.SDK.Service.V62.LayoutRevision
{
	public class LayoutRevisionService : ServiceBase
	{
		public LayoutRevisionService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddLayoutRevisionAsync(long userId, long layoutSetBranchId, long layoutBranchId, long parentLayoutRevisionId, bool head, long plid, long portletPreferencesPlid, bool privateLayout, string name, string title, string description, string keywords, string robots, string typeSettings, bool iconImage, long iconImageId, string themeId, string colorSchemeId, string wapThemeId, string wapColorSchemeId, string css, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("layoutSetBranchId", layoutSetBranchId);
			_parameters.Add("layoutBranchId", layoutBranchId);
			_parameters.Add("parentLayoutRevisionId", parentLayoutRevisionId);
			_parameters.Add("head", head);
			_parameters.Add("plid", plid);
			_parameters.Add("portletPreferencesPlid", portletPreferencesPlid);
			_parameters.Add("privateLayout", privateLayout);
			_parameters.Add("name", name);
			_parameters.Add("title", title);
			_parameters.Add("description", description);
			_parameters.Add("keywords", keywords);
			_parameters.Add("robots", robots);
			_parameters.Add("typeSettings", typeSettings);
			_parameters.Add("iconImage", iconImage);
			_parameters.Add("iconImageId", iconImageId);
			_parameters.Add("themeId", themeId);
			_parameters.Add("colorSchemeId", colorSchemeId);
			_parameters.Add("wapThemeId", wapThemeId);
			_parameters.Add("wapColorSchemeId", wapColorSchemeId);
			_parameters.Add("css", css);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/layoutrevision/add-layout-revision", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}