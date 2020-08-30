# code-analyzers-tests

Can be reproduced via `dotnet build` or `docker build . -t test`

My setup is MacOS with dotnet core

```sh
$ dotnet --version
```
```
3.1.401
```

---------------------

My result when running

```sh
$ dotnet build
```
```
Microsoft (R) Build Engine version 16.7.0-preview-20360-03+188921e2f for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
RCS1151/ExtensionMethods.cs(10,70): error CS0311: The type 'Test.RCS1151.CustomExtension' cannot be used as type parameter 'TExtension' in the generic type or method 'IDbContextOptionsBuilderInfrastructure.AddOrUpdateExtension<TExtension>(TExtension)'. There is no implicit reference conversion from 'Test.RCS1151.CustomExtension' to 'Microsoft.EntityFrameworkCore.Infrastructure.IDbContextOptionsExtension'. [/Users/.../code-analyzers-tests/Test/Test.csproj]
RCS1201/MyEntityConfig.cs(15,13): error RCS1201: Use method chaining. [/Users/.../code-analyzers-tests/Test/Test.csproj]

Build FAILED.

RCS1151/ExtensionMethods.cs(10,70): error CS0311: The type 'Test.RCS1151.CustomExtension' cannot be used as type parameter 'TExtension' in the generic type or method 'IDbContextOptionsBuilderInfrastructure.AddOrUpdateExtension<TExtension>(TExtension)'. There is no implicit reference conversion from 'Test.RCS1151.CustomExtension' to 'Microsoft.EntityFrameworkCore.Infrastructure.IDbContextOptionsExtension'. [/Users/.../code-analyzers-tests/Test/Test.csproj]
RCS1201/MyEntityConfig.cs(15,13): error RCS1201: Use method chaining. [/Users/.../code-analyzers-tests/Test/Test.csproj]
    0 Warning(s)
    2 Error(s)

Time Elapsed 00:00:01.36
```
