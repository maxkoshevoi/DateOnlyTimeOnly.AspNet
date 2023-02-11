namespace DateOnlyTimeOnly.AspNet.Converters;

public class TimeOnlyTypeConverter : StringTypeConverterBase<TimeOnly>
{
    protected override TimeOnly Parse(string s, IFormatProvider? provider) => TimeOnly.Parse(s, provider);

    protected override string ToIsoString(TimeOnly source, IFormatProvider? provider) => source.ToString("O", provider);
}
