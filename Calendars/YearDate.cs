namespace Calendars;

public class YearDate : IEquatable<YearDate>
{
    private int _month;
    private int _day;
    private readonly GregorianCalendar _calendar;

    public YearDate(int month, int day, GregorianCalendar calendar)
    {
        _month = month;
        _day = day;
        _calendar = calendar;
    }

    public bool Equals(YearDate? other) => this._month == other?._month && this._day == other._day;

    public override string ToString() => _month + "/" + _day;

   
    public YearDate GetNext() =>
        IsEndOfMonth() ? new YearDate(_calendar.NextMonth(_month), 1, _calendar) : new YearDate(_month, _day + 1, _calendar);

    private bool IsEndOfMonth() => _calendar.DaysInMonth(_month) == _day;
  

    public bool IsBefore(YearDate day) => _month < day._month ||
                                          (_month == day._month && _day < day._day);
}