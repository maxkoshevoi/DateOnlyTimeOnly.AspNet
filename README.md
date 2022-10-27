# DateOnlyTimeOnly.AspNet

Adds support for receiving and returning DateOnly/TimeOnly as ISO 8601 string to ASP.NET Core API

## Installation

Get it from NuGet
- Base package: [![NuGet](https://img.shields.io/nuget/vpre/DateOnlyTimeOnly.AspNet.svg?label=NuGet)](https://www.nuget.org/packages/DateOnlyTimeOnly.AspNet/)
- Swashbuckle support: [![NuGet](https://img.shields.io/nuget/vpre/DateOnlyTimeOnly.AspNet.Swashbuckle.svg?label=NuGet)](https://www.nuget.org/packages/DateOnlyTimeOnly.AspNet.Swashbuckle/)

## Usage

Call `UseDateOnlyTimeOnlyStringConverters` on options for `AddControllers` and `AddJsonOptions`:

```cs
builder.Services
    .AddControllers(options => options.UseDateOnlyTimeOnlyStringConverters())
    .AddJsonOptions(options => options.UseDateOnlyTimeOnlyStringConverters());
```

After that all `DateOnly` and `TimeOnly` action arguments will be received and returned as ISO 8601 string.

## Swagger support

### NSwag

No additional action is needed.

### Swashbuckle

Install `DateOnlyTimeOnly.AspNet.Swashbuckle` package, and add `UseDateOnlyTimeOnlyStringConverters` to your swagger configuration:

```cs
builder.Services.AddSwaggerGen(c => c.UseDateOnlyTimeOnlyStringConverters());
```