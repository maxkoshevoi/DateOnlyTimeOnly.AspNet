using DateOnlyTimeOnly.AspNet.Converters;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Extensions.DependencyInjection;

public static class JsonOptionsExtensions
{
    /// <summary>
    /// Adds <see cref="DateOnly"/> and <see cref="TimeOnly"/> serializers to System.Text.Json.
    /// </summary>
    public static JsonOptions UseDateOnlyTimeOnlyStringConverters(this JsonOptions options)
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        return options;
    }
}
