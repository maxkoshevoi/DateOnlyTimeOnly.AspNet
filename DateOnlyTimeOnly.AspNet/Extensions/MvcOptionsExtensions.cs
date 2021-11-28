using DateOnlyTimeOnly.AspNet.Converters;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Microsoft.Extensions.DependencyInjection;

public static class MvcOptionsExtensions
{
    /// <summary>
    /// Adds <see cref="TypeConverter"/> to DateOnly and TimeOnly type definitions.
    /// </summary>
    /// <param name="options">Not currently used.</param>
    public static MvcOptions UseDateOnlyTimeOnlyStringConverters(this MvcOptions options)
    {
        TypeDescriptor.AddAttributes(typeof(DateOnly), new TypeConverterAttribute(typeof(DateOnlyTypeConverter)));
        TypeDescriptor.AddAttributes(typeof(TimeOnly), new TypeConverterAttribute(typeof(TimeOnlyTypeConverter)));
        return options;
    }
}
