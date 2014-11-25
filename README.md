# Liferay SDK for Windows

This repository contains a version of the [Liferay Mobile SDK]
(https://github.com/liferay/liferay-mobile-sdk) for the Windows ecosystem. This
consists of a Portable Class Library written in C# targeting the following
platforms:

* .NET Framework 4.5.1
* Windows 8.1
* Windows Phone 8.1

Anyway, it should be relatively easy to extend support for older platforms, so
let me know if you're interested or send me a PR.

## Setup

The Liferay SDK for Windows is available on [NuGet]
(https://www.nuget.org/packages/Liferay.SDK/):

```ps
Install-Package Liferay.SDK
```

Alternatively, the source code of the SDK is available in the [*windows*]
(https://github.com/Ithildir/liferay-sdk-builder-windows/tree/master/windows)
folder. This contains the Visual Studio Express 2013 solution with the SDK
project and a Unit Test library project which replicates almost all unit tests
of the [Liferay Android SDK]
(https://github.com/liferay/liferay-mobile-sdk/tree/master/android).

## Build

The source code and the assembly of the Liferay SDK for accessing the portal
remote services are already provided. Anyway, if you prefer to generate a new
SDK for a different version of Liferay or for your plugins, there are
essentially three options available:

1. with Gradle, from this repository:

	```bat
	git clone https://github.com/Ithildir/liferay-sdk-builder-windows.git
	cd liferay-sdk-builder-windows
	gradlew generate
	```

2. with Gradle, from the Liferay Mobile SDK [repository]
(https://github.com/liferay/liferay-mobile-sdk):

	1. clone the repository:

		```bat
		git clone https://github.com/liferay/liferay-mobile-sdk.git
		cd liferay-mobile-sdk
		```

	2. Edit `gradle.properties`:

		```properties
		platforms=windows
		```

	3. Generate the SDK:

		```bat
		gradlew generate
		```

3. as a standalone library, because the SDK Builder jar is available in Maven
Central:

	```xml
	<dependency>
		<groupId>com.github.ithildir</groupId>
		<artifactId>liferay-sdk-builder-windows</artifactId>
		<version>LATEST</version>
	</dependency>
	```

Have a look at [this page]
(https://github.com/liferay/liferay-mobile-sdk/tree/master/builder#configuring)
to find the various configuration options available in `gradle.properties`.

## Compatibility

The Liferay SDK for Windows follows the same exact [versioning scheme]
(https://github.com/liferay/liferay-mobile-sdk/tree/master/android#liferay) of
the official Liferay Mobile SDK, so, for example, version 6.2.0.1 of the SDK is
built to work with Liferay Portal 6.2.0, while version 7.0.0.1 works with
Liferay Portal 7.0.0.

## Use

The Liferay SDK for Windows is an almost line-by-line port of the Android
version, so more detailed information about usage can be found at [this page]
(https://github.com/Ithildir/liferay-mobile-sdk/tree/master/android#use).

1. Create a `Session` with the user credentials:

	```cs
	using Liferay.SDK;

	var session = new Session(new Uri("http://localhost:8080"), "test@liferay.com", "test");
	```

2. Import the service you need, for example:

	```cs
	using Liferay.SDK.Service.V62.BlogsEntry;
	```

3. Create a `BlogsEntryService` object and make a service call:

	```cs
	var service = new BlogsEntryService(session);

	var entries = await service.GetGroupEntriesAsync(10184, 0, -1, -1);
	```

	Service methods are asynchronous and follow the *async/await* approach.
	Return types can be primitive types, `dynamic` objects or
	`IEnumerable<dynamic>` collections. So, it is easy to navigate the results
	of the service calls and read the properties of the returned objects:

	```cs
	foreach (var entry in entries)
	{
		Console.WriteLine(entry.title);
	}
	```

### Batch

The SDK allows sending requests using batch processing, which can be much more
efficient in some cases. Read [DLAppServiceTest.cs]
(https://github.com/Ithildir/liferay-sdk-builder-windows/blob/master/windows/Liferay.SDK.Test/DLAppServiceTest.cs)
to find an example on how to create a batch of calls and send them all together.

### Non-primitive arguments

There are some special cases in which service methods arguments are not
primitives. In these cases, you should use `JsonObjectWrapper`. Read
[OrderByComparatorTest.cs]
(https://github.com/Ithildir/liferay-sdk-builder-windows/blob/master/windows/Liferay.SDK.Test/OrderByComparatorTest.cs)
and [ServiceContextTest.cs]
(https://github.com/Ithildir/liferay-sdk-builder-windows/blob/master/windows/Liferay.SDK.Test/ServiceContextTest.cs)
to find examples on how to use non-primitive arguments in service methods.

### Binaries

Some Liferay services require argument types such as byte arrays (`byte[]`) and Streams (`System.IO.Stream`). Read [DLAppServiceTest.cs]
(https://github.com/Ithildir/liferay-sdk-builder-windows/blob/master/windows/Liferay.SDK.Test/DLAppServiceTest.cs)
to find an example on how to send binary data to the portal.
