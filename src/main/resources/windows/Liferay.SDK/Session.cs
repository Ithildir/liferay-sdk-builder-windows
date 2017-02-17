//------------------------------------------------------------------------------
// <copyright file="Session.cs">
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
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Liferay.SDK.Http;

namespace Liferay.SDK
{
	public class Session : ISession
	{
		public const int DefaultConnectionTimeout = 15000;

		public Session(ISession session)
			: this(session.Server, session.UserName, session.Password, session.ConnectionTimeout)
		{
		}

		public Session(Uri server, int connectionTimeout = DefaultConnectionTimeout)
			: this(server, null, null, connectionTimeout)
		{
		}

		public Session(Uri server, string userName, string password, int connectionTimeout = DefaultConnectionTimeout)
		{
			this.Server = server;
			this.UserName = userName;
			this.Password = password;
			this.ConnectionTimeout = connectionTimeout;

			this.HttpClient = this.GetHttpClient();
		}

		public int ConnectionTimeout { get; private set; }

		public HttpClient HttpClient { get; private set; }

		public string Password { get; private set; }

		public Uri Server { get; private set; }

		public string UserName { get; private set; }

		public virtual async Task<object> InvokeAsync(IDictionary<string, object> command)
		{
			var commands = new JsonArray(1);

			commands.Add(command);

			var array = await HttpUtil.PostAsync(this, commands);

			return array.First();
		}

		public virtual async Task<object> UploadAsync(IDictionary<string, object> command)
		{
			return await HttpUtil.UploadAsync(this, command);
		}

		protected virtual AuthenticationHeaderValue GetAuthorizationHeader()
		{
			if (string.IsNullOrWhiteSpace(this.UserName) || string.IsNullOrWhiteSpace(this.Password))
			{
				return null;
			}

			var authorization = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", this.UserName, this.Password)));

			return new AuthenticationHeaderValue("Basic", authorization);
		}

		protected virtual HttpClient GetHttpClient()
		{
			var httpClient = new HttpClient();

			httpClient.DefaultRequestHeaders.Authorization = this.GetAuthorizationHeader();

			httpClient.Timeout = new TimeSpan(0, 0, 0, 0, this.ConnectionTimeout);

			return httpClient;
		}
	}
}