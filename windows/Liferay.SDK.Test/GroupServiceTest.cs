//------------------------------------------------------------------------------
// <copyright file="GroupServiceTest.cs">
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
using Liferay.SDK.Service.V62.Group;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Liferay.SDK.Test
{
    [TestClass]
    public class GroupServiceTest : TestBase
    {
        [TestMethod]
        public void TestGetUserSites()
        {
            var groupService = new GroupService(this.Session);

            var userSites = groupService.GetUserSitesAsync().Result;

            Assert.IsNotNull(userSites);
            Assert.AreEqual(2, userSites.Count());

            dynamic group = userSites.ElementAt(0);

            Assert.AreEqual("/test", (string)group.friendlyURL);

            group = userSites.ElementAt(1);

            Assert.AreEqual("/guest", (string)group.friendlyURL);
        }
    }
}
