using DateOnlyTimeOnly.AspNet.Converters;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Extensions.DependencyInjection;

public static class JsonOptionsExtensions
{
    public static JsonOptions UseDateOnlyTimeOnlyStringConverters(this JsonOptions options)
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        return options;
    }
}
