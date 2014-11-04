//------------------------------------------------------------------------------
// <copyright file="TestBase.cs">
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

namespace Liferay.SDK.Test
{
    public abstract class TestBase
    {
        protected const long GroupId = 10185;
        
        private const string Password = "test";

        private const string Server = "http://localhost:8080";

        private const string UserName = "test@liferay.com";

        protected TestBase()
        {
            this.Session = new Session(new Uri(Server), UserName, Password);
        }

        public ISession Session { get; private set; }
    }
}
