//------------------------------------------------------------------------------
// <copyright file="SpecialCharsTest.cs">
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

using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Liferay.SDK.Test
{
    [TestClass]
    public class SpecialCharsTest : TestBase
    {
        private ServiceContextTest serviceContextTest;
        
        [TestInitialize]
        public void Initialize()
        {
            this.serviceContextTest = new ServiceContextTest();
        }

        [TestMethod]
        public void TestAddBookmarkEntrySpecialChars()
        {
            string name = "entry áéíòúñ";

            var entry = this.serviceContextTest.AddBookmarkEntryAsync(name, null).Result;

            Assert.AreEqual(name, entry.name);

            this.serviceContextTest.DeleteBookmarkEntryAsync(entry);
        }
    }
}
