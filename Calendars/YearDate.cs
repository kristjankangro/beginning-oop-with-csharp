namespace Calendars;

public class YearDate
{
    private int _month;
    private int _day;

    public YearDate(int month, int day)
    {
        _month = month;
        _day = day;
    }

    public override string ToString() => _month + "/" + _day;

    public bool IsLeap() => _month == 2 && _day == 29;

    public YearDate GetNext() =>
        IsEndOfMonth() ? new YearDate(NextMonth(), 1) : new YearDate(_month, _day + 1);

    private int NextMonth() => _month % 12 + 1;

    private bool IsEndOfMonth() => DaysInMonth() == _day;

    private int DaysInMonth() => _month == 2 ? 29
        : _month == 4 || _month == 6 || _month == 9 || _month == 11 ? 30
        : 31;

    public bool IsBefore(YearDate day) => _month < day._month ||
                                          (_month == day._month && _day < day._day);
}