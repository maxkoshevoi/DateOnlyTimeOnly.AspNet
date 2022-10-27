using DateOnlyTimeOnly.AspNet.Converters;
using System.ComponentModel;
using Controllers = Microsoft.AspNetCore.Mvc;
using MinimalApis = Microsoft.AspNetCore.Http.Json;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static partial IServiceCollection AddDateOnlyTimeOnlyStringConverters(this IServiceCollection services);

#if NET6_0
    /// <summary>
    /// Adds <see cref="TypeConverter"/> to <see cref="DateOnly"/> and <see cref="TimeOnly"/> type definitions, 
    /// and adds <see cref="DateOnly"/> and <see cref="TimeOnly"/> serializers to System.Text.Json.
    /// </summary>
    public static partial IServiceCollection AddDateOnlyTimeOnlyStringConverters(this IServiceCollection services)
    {
        TypeDescriptor.AddAttributes(typeof(DateOnly), new TypeConverterAttribute(typeof(DateOnlyTypeConverter)));
        TypeDescriptor.AddAttributes(typeof(TimeOnly), new TypeConverterAttribute(typeof(TimeOnlyTypeConverter)));

        services.Configure<Controllers::JsonOptions>(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
            options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        });

        services.Configure<MinimalApis::JsonOptions>(options =>
        {
            options.SerializerOptions.Converters.Add(new DateOnlyJsonConverter());
            options.SerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        });

        return services;
    }
#endif

#if NET7_0_OR_GREATER
    /// <summary>
    /// Adds support to use <see cref="TimeOnly"/> as Dictionary key (the rest is available out of the box).
    /// </summary>
    public static partial IServiceCollection AddDateOnlyTimeOnlyStringConverters(this IServiceCollection services)
    {
        services.Configure<Controllers::JsonOptions>(options => options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter()));
        services.Configure<MinimalApis::JsonOptions>(options => options.SerializerOptions.Converters.Add(new TimeOnlyJsonConverter()));
        return services;
    }
#endif
}
