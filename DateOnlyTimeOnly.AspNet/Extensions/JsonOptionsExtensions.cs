using DateOnlyTimeOnly.AspNet.Converters;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Extensions.DependencyInjection;

public static class JsonOptionsExtensions
{
    /// <summary>
    /// Adds DateOnly and TimeOnly serializers to System.Text.Json.
    /// </summary>
    public static JsonOptions UseDateOnlyTimeOnlyStringConverters(this JsonOptions options)
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        return options;
    }
}
