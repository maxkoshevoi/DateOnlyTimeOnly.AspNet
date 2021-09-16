namespace DateOnlyTimeOnly.AspNet.Converters;

public class TimeOnlyTypeConverter : StringTypeConverterBase<TimeOnly>
{
    protected override TimeOnly Parse(string s) => TimeOnly.Parse(s);

    protected override string ToIcoString(TimeOnly source) => source.ToString("O");
}
