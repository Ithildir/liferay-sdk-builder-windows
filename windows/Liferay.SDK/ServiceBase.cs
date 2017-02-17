//------------------------------------------------------------------------------
// <copyright file="ServiceBase.cs">
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

namespace Liferay.SDK
{
	public abstract class ServiceBase
	{
		protected const string OrderByComparator = "com.liferay.portal.kernel.util.OrderByComparator";

		protected const string ServiceContext = "com.liferay.portal.service.ServiceContext";

		protected ServiceBase(ISession session)
		{
			this.Session = session;
		}

		public ISession Session { get; private set; }

		internal void MangleWrapper(JsonObject parameters, string name, string className, JsonObjectWrapper wrapper)
		{
			if (wrapper == null)
			{
				if (!className.Equals(ServiceContext))
				{
					parameters.Add(name, null);
				}

				return;
			}

			wrapper.Mangle(parameters, name, className);
		}
	}
}