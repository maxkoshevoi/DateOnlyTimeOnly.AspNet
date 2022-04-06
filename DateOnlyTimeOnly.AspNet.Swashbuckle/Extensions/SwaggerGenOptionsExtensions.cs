using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Microsoft.Extensions.DependencyInjection;

public static class SwaggerGenOptionsExtensions
{
    /// <summary>
    /// Maps DateOnly and TimeOnly to string.
    /// </summary>
    public static void UseDateOnlyTimeOnlyStringConverters(this SwaggerGenOptions options)
    {
        options.MapType<DateOnly>(() => new OpenApiSchema 
        { 
            Type = "string", 
            Format = "date" 
        });
        options.MapType<TimeOnly>(() => new OpenApiSchema 
        { 
            Type = "string", 
            Format = "time", 
            Example = OpenApiAnyFactory.CreateFromJson("\"13:45:42.0000000\"") 
        });
    }
}
