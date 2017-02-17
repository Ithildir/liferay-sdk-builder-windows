//------------------------------------------------------------------------------
// <copyright file="JsonObjectWrapper.cs">
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
using System.Text;
using System.Threading.Tasks;

namespace Liferay.SDK
{
	public class JsonObjectWrapper
	{
		private JsonObject jsonObject = new JsonObject();

		public JsonObjectWrapper()
			: this(null)
		{
		}

		public JsonObjectWrapper(string className)
		{
			this.ClassName = className;
		}

		public string ClassName { get; private set; }

		public dynamic JsonObject
		{
			get
			{
				return this.jsonObject;
			}
		}

		internal void Mangle(JsonObject parameters, string name, string className)
		{
			this.AddClassName(parameters, name, className);
			this.AddJsonObject(parameters, name);
		}

		private void AddClassName(JsonObject parameters, string name, string className)
		{
			if (!string.IsNullOrWhiteSpace(this.ClassName))
			{
				className = this.ClassName;
			}

			parameters.Add("+" + name, className);
		}

		private void AddJsonObject(JsonObject parameters, string name)
		{
			foreach (var kvp in this.jsonObject)
			{
				string key = string.Format("{0}.{1}", name, kvp.Key);

				parameters.Add(key, kvp.Value);
			}
		}
	}
}