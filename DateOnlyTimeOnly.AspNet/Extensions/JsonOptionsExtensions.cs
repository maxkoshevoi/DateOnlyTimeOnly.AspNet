using DateOnlyTimeOnly.AspNet.Converters;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class JsonOptionsExtensions
{
    [Obsolete("Use builder.Services.AddDateOnlyTimeOnlyStringConverters() instead.")]
    public static partial JsonOptions UseDateOnlyTimeOnlyStringConverters(this JsonOptions options);

#if NET6_0
    /// <summary>
    /// Adds <see cref="DateOnly"/> and <see cref="TimeOnly"/> serializers to System.Text.Json.
    /// </summary>
    public static partial JsonOptions UseDateOnlyTimeOnlyStringConverters(this JsonOptions options)
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        return options;
    }
#endif

#if NET7_0_OR_GREATER
    /// <summary>
    /// Adds support to use <see cref="TimeOnly"/> as Dictionary key (the rest is available out of the box).
    /// </summary>
    public static partial JsonOptions UseDateOnlyTimeOnlyStringConverters(this JsonOptions options)
    {
        options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        return options;
    }
#endif
}
