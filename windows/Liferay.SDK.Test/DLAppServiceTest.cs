//------------------------------------------------------------------------------
// <copyright file="DLAppServiceTest.cs">
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liferay.SDK.Service.V62.DLApp;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Liferay.SDK.Test
{
	[TestClass]
	public class DLAppServiceTest : TestBase
	{
		private const string MimeType = "text/plain";

		private const long ParentFolderId = 0;

		private const string SourceFileName = "test.properties";

		[TestMethod]
		public void TestAddFileEntryBytes()
		{
			var service = new DLAppService(this.Session);
			var repositoryId = GroupId;

			var bytes = Encoding.UTF8.GetBytes("Hello");

			var fileEntry = service.AddFileEntryAsync(repositoryId, ParentFolderId, SourceFileName, MimeType, SourceFileName, string.Empty, string.Empty, bytes, null).Result;

			Assert.AreEqual(SourceFileName, fileEntry.title);

			service.DeleteFileEntryAsync(fileEntry.fileEntryId);
		}
	}
}
