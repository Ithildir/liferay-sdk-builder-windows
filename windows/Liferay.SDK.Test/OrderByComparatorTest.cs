//------------------------------------------------------------------------------
// <copyright file="OrderByComparatorTest.cs">
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

using System.Linq;
using System.Threading.Tasks;
using Liferay.SDK.Service.V62.BookmarksEntry;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Liferay.SDK.Test
{
	[TestClass]
	public class OrderByComparatorTest : TestBase
	{
		private dynamic entryA;
		private dynamic entryZ;
		private ServiceContextTest serviceContextTest;

		[TestCleanup]
		public async Task Cleanup()
		{
			await this.serviceContextTest.DeleteBookmarkEntryAsync(this.entryA);
			await this.serviceContextTest.DeleteBookmarkEntryAsync(this.entryZ);
		}

		[TestInitialize]
		public async Task Initialize()
		{
			this.serviceContextTest = new ServiceContextTest();

			this.entryA = await this.serviceContextTest.AddBookmarkEntryAsync("A", null);
			this.entryZ = await this.serviceContextTest.AddBookmarkEntryAsync("Z", null);
		}

		[TestMethod]
		public async Task TestGetEntriesDescending()
		{
			var service = new BookmarksEntryService(this.Session);

			var className = "com.liferay.portlet.bookmarks.util.comparator.EntryNameComparator";

			var orderByComparator = new JsonObjectWrapper(className);

			var entries = await service.GetEntriesAsync(OrderByComparatorTest.GroupId, ServiceContextTest.ParentFolderId, -1, -1, orderByComparator);

			var first = entries.First();
			var second = entries.ElementAt(1);

			Assert.AreEqual("Z", first.name);
			Assert.AreEqual("A", second.name);
		}

		[TestMethod]
		public async Task TestNullOrderByComparator()
		{
			var service = new BookmarksEntryService(this.Session);

			var entries = await service.GetEntriesAsync(OrderByComparatorTest.GroupId, ServiceContextTest.ParentFolderId, -1, -1, null);

			Assert.AreEqual(2, entries.Count());

			var first = entries.First();
			var second = entries.ElementAt(1);

			Assert.AreEqual("A", first.name);
			Assert.AreEqual("Z", second.name);
		}
	}
}
