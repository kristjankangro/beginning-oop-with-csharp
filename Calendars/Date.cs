namespace Calendars;

public class Date
{
    private int _year;
    private YearDate _day;
    private readonly Calendar _calendar;

    public Date(Calendar calendar, int year, YearDate day)
    {
        _year = year;
        _day = day;
        _calendar = calendar;
    }

    public Date AddYears(int addedYears)
    {
        return FirstValidDate(_year + addedYears, _day);
    }

    private Date FirstValidDate(int year, YearDate day) =>
        new Date(_calendar, year, day.IsLeap() && !_calendar.IsLeapYear(year) ? day.GetNext() : day);

    public override string ToString() => _year + "/" + _day;

    public Date GetFirstOccurence(YearDate day) => GetFirstDayOccurence(day.IsBefore(_day) ? _year + 1 : _year, day);

    private Date GetFirstDayOccurence(int year, YearDate day) =>
        new Date(_calendar, day.IsLeap() ? GetLeap(year) : year, day);

    private int GetLeap(int year) => _calendar.IsLeapYear(year) ? year : GetLeap(year + 1);

    public Date GetFirstDayOccurence(Date day) => GetFirstDayOccurence(_year, day._day);
}