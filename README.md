# DateOnlyTimeOnly.AspNet

Adds support for receiving and returning DateOnly/TimeOnly as ISO 8601 string to ASP.NET Core API

## Installation

Get it from NuGet
- Base package: [![NuGet](https://img.shields.io/nuget/vpre/DateOnlyTimeOnly.AspNet.svg?label=NuGet)](https://www.nuget.org/packages/DateOnlyTimeOnly.AspNet/)
- Swashbuckle support: [![NuGet](https://img.shields.io/nuget/vpre/DateOnlyTimeOnly.AspNet.Swashbuckle.svg?label=NuGet)](https://www.nuget.org/packages/DateOnlyTimeOnly.AspNet.Swashbuckle/)

## Usage

Call `AddDateOnlyTimeOnlyStringConverters` on `services`:

```cs
builder.Services.AddDateOnlyTimeOnlyStringConverters();
```

After that:
- **For .NET 6**: all `DateOnly` and `TimeOnly` action arguments will be received and returned as ISO 8601 string;
- **For .NET 7**: adds support to use `TimeOnly` as Dictionary key (the rest is available out of the box).

## Swagger support

### NSwag

No additional action is needed.

### Swashbuckle

#### v6.5.0 and after:

No additional action is needed.

#### Before v6.5.0:

Install `DateOnlyTimeOnly.AspNet.Swashbuckle` package, and add `UseDateOnlyTimeOnlyStringConverters` to your swagger configuration:

```cs
builder.Services.AddSwaggerGen(c => c.UseDateOnlyTimeOnlyStringConverters());
```