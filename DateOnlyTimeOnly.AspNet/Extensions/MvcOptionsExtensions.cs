using DateOnlyTimeOnly.AspNet.Converters;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class MvcOptionsExtensions
{
    /// <summary>
    /// Adds <see cref="TypeConverter"/> to <see cref="DateOnly"/> and <see cref="TimeOnly"/> type definitions.
    /// </summary>
    /// <param name="options">Not currently used.</param>
    public static partial MvcOptions UseDateOnlyTimeOnlyStringConverters(this MvcOptions options);

#if NET6_0
    [Obsolete("Use builder.Services.AddDateOnlyTimeOnlyStringConverters() instead.")]
    public static partial MvcOptions UseDateOnlyTimeOnlyStringConverters(this MvcOptions options)
    {
        TypeDescriptor.AddAttributes(typeof(DateOnly), new TypeConverterAttribute(typeof(DateOnlyTypeConverter)));
        TypeDescriptor.AddAttributes(typeof(TimeOnly), new TypeConverterAttribute(typeof(TimeOnlyTypeConverter)));
        return options;
    }
#endif

#if NET7_0_OR_GREATER
    [Obsolete("DateOnly/TimeOnly work out of the box in .NET 7+. You can remove call to this method.")]
    public static partial MvcOptions UseDateOnlyTimeOnlyStringConverters(this MvcOptions options) => options;
#endif
}
