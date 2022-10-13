using DateOnlyTimeOnly.AspNet.Converters;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class JsonOptionsExtensions
{
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
    /// Adds <see cref="DateOnly"/> and <see cref="TimeOnly"/> serializers to System.Text.Json.
    /// </summary>
    [Obsolete("DateOnly/TimeOnly work out of the box in .NET 7+. You can remove call to this method.")]
    public static partial JsonOptions UseDateOnlyTimeOnlyStringConverters(this JsonOptions options) => options;
#endif
}
