//------------------------------------------------------------------------------
// <copyright file="PortalVersionUtil.cs">
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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Liferay.SDK.Util
{
	public static class PortalVersionUtil
	{
		private static HttpClient httpClient = new HttpClient();
		private static IDictionary<Uri, int> versions = new ConcurrentDictionary<Uri, int>();

		public static Task<int> GetPortalVersionAsync(ISession session)
		{
			return GetPortalVersionAsync(session.Server);
		}

		public static async Task<int> GetPortalVersionAsync(Uri uri)
		{
			int version;

			if (versions.TryGetValue(uri, out version))
			{
				return version;
			}

			var request = new HttpRequestMessage(HttpMethod.Head, uri);

			var response = await httpClient.SendAsync(request);

			IEnumerable<string> portalHeaders;

			if (!response.Headers.TryGetValues("Liferay-Portal", out portalHeaders))
			{
				return PortalVersion.Unknown;
			}

			var portalField = portalHeaders.First();

			var indexOfBuild = portalField.IndexOf("Build");

			if (indexOfBuild == -1)
			{
				return PortalVersion.Unknown;
			}

			string buildNumber = portalField.Substring(indexOfBuild + 6, 4);

			version = int.Parse(buildNumber);

			versions.Add(uri, version);

			return version;
		}
	}
}