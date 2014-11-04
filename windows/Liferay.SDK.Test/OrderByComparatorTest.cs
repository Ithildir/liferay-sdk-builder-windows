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
        public void Cleanup()
        {
            Task taskA = this.serviceContextTest.DeleteBookmarkEntryAsync(this.entryA);
            Task taskZ = this.serviceContextTest.DeleteBookmarkEntryAsync(this.entryZ);

            Task.WaitAll(taskA, taskZ);
        }

        [TestInitialize]
        public void Initialize()
        {
            this.serviceContextTest = new ServiceContextTest();

            this.entryA = this.serviceContextTest.AddBookmarkEntryAsync("A", null).Result;
            this.entryZ = this.serviceContextTest.AddBookmarkEntryAsync("Z", null).Result;
        }

        [TestMethod]
        public void TestGetEntriesDescending()
        {
            var service = new BookmarksEntryService(this.Session);

            var className = "com.liferay.portlet.bookmarks.util.comparator.EntryNameComparator";

            var orderByComparator = new JsonObjectWrapper(className);

            var entries = service.GetEntriesAsync(OrderByComparatorTest.GroupId, ServiceContextTest.ParentFolderId, -1, -1, orderByComparator).Result;

            var first = entries.First();
            var second = entries.ElementAt(1);

            Assert.AreEqual("Z", first.name);
            Assert.AreEqual("A", second.name);
        }

        [TestMethod]
        public void TestNullOrderByComparator()
        {
			var service = new BookmarksEntryService(this.Session);

            var entries = service.GetEntriesAsync(OrderByComparatorTest.GroupId, ServiceContextTest.ParentFolderId, -1, -1, null).Result;

            Assert.AreEqual(2, entries.Count());

            var first = entries.First();
            var second = entries.ElementAt(1);

            Assert.AreEqual("A", first.name);
            Assert.AreEqual("Z", second.name);
        }
    }
}
