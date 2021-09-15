# DateOnlyTimeOnly.AspNet

Adds support for recieving and returning DateOnly/TimeOnly as ISO 8601 string to ASP.NET API

## Installation

Get it from NuGet: [![NuGet](https://img.shields.io/nuget/vpre/DateOnlyTimeOnly.AspNet.svg?label=NuGet)](https://www.nuget.org/packages/DateOnlyTimeOnly.AspNet/)

## Usage

Call `UseDateOnlyTimeOnlyStringConverters` on options for `AddControllers` and `AddJsonOptions`:

```cs
builder.Services
    .AddControllers(options => options.UseDateOnlyTimeOnlyStringConverters())
    .AddJsonOptions(options => options.UseDateOnlyTimeOnlyStringConverters());
```

After that all `DateOnly` and `TimeOnly` action arguments will be recieved and returned as ISO 8601 string
