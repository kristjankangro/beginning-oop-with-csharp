namespace Calendars;

public class YearDate
{
    private int _month;
    private int _day;
    private readonly Calendar _calendar;

    public YearDate(Calendar calendar, int month, int day)
    {
        _month = month;
        _day = day;
        _calendar = calendar;
    }

    public bool IsLeap() => _calendar.IsLeapDay(_month, _day);

    public override string ToString() => _month + "/" + _day;

   
    public YearDate GetNext() =>
        IsEndOfMonth() 
            ? new YearDate(_calendar, _calendar.NextMonth(_month), 1)
            : new YearDate(_calendar, _month, _day + 1);

    private bool IsEndOfMonth() => _calendar.DaysInMonth(_month) == _day;
  

    public bool IsBefore(YearDate day) => _month < day._month ||
                                          (_month == day._month && _day < day._day);
}