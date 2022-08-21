using System.Text.Json;
using System.Text.Json.Serialization;

namespace DateOnlyTimeOnly.AspNet.Converters;

public sealed class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (DateOnly.TryParse(reader.GetString(),out DateOnly date))
            return date;

        throw new JsonException("Property is not in a proper date format.");
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    {
        var isoDate = value.ToString("O");
        writer.WriteStringValue(isoDate);
    }
}
