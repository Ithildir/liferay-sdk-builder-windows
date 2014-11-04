//------------------------------------------------------------------------------
// <copyright file="PortalVersionTest.cs">
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

using Liferay.SDK.Util;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Liferay.SDK.Test
{
    [TestClass]
    public class PortalVersionTest : TestBase
    {
        [TestMethod]
        public void TestGetPortalVersion()
        {
            int portalVersion = PortalVersionUtil.GetPortalVersionAsync(this.Session).Result;
            
            if (portalVersion < PortalVersion.V62)
            {
                Assert.Fail();
            }
        }
    }
}
