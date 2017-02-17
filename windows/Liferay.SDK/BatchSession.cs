//------------------------------------------------------------------------------
// <copyright file="BatchSession.cs">
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
using System.Threading.Tasks;
using Liferay.SDK.Http;

namespace Liferay.SDK
{
	public class BatchSession : Session
	{
		private JsonArray commands = new JsonArray();

		public BatchSession(ISession session)
			: base(session)
		{
		}

		public BatchSession(Uri server, string username, string password)
			: base(server, username, password)
		{
		}

		public async Task<IEnumerable<dynamic>> InvokeAsync()
		{
			try
			{
				return await HttpUtil.PostAsync(this, this.commands);
			}
			finally
			{
				this.commands.Clear();
			}
		}

		public override Task<object> InvokeAsync(IDictionary<string, object> command)
		{
			this.commands.Add(command);

			return Task.FromResult<object>(null);
		}

		public override Task<object> UploadAsync(IDictionary<string, object> command)
		{
			throw new InvalidOperationException("Can't batch upload requests");
		}
	}
}