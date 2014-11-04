//------------------------------------------------------------------------------
// <copyright file="ServiceContextTest.cs">
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
using System.Threading.Tasks;
using Liferay.SDK.Service.V62.BookmarksEntry;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Liferay.SDK.Test
{
    [TestClass]
    public class ServiceContextTest : TestBase
    {
        public const long ParentFolderId = 0;

        [TestMethod]
        public void TestAddBookmarkEntry()
        {
            var random = new Random();

            var uuid = random.Next().ToString();

            JsonObjectWrapper serviceContext = new JsonObjectWrapper();

            serviceContext.JsonObject.uuid = uuid;
            serviceContext.JsonObject.addGroupPermissions = true;
            serviceContext.JsonObject.addGuestPermissions = true;

            var entry = this.AddBookmarkEntryAsync("test", serviceContext).Result;

            Assert.AreEqual(uuid, entry.uuid);

            this.DeleteBookmarkEntryAsync(entry);
        }

        public async Task<dynamic> AddBookmarkEntryAsync(string name, JsonObjectWrapper serviceContext)
        {
            var service = new BookmarksEntryService(this.Session);

            return await service.AddEntryAsync(ServiceContextTest.GroupId, ServiceContextTest.ParentFolderId, name, "http://www.liferay.com", string.Empty, serviceContext);
        }

        public async Task DeleteBookmarkEntryAsync(dynamic entry)
        {
            var service = new BookmarksEntryService(this.Session);

            await service.DeleteEntryAsync(entry.entryId);
        }
    }
}
