namespace DateOnlyTimeOnly.AspNet.Converters;

public class DateOnlyTypeConverter : StringTypeConverterBase<DateOnly>
{
    protected override DateOnly Parse(string s) => DateOnly.Parse(s);

    protected override string ToIsoString(DateOnly source) => source.ToString("O");
}
