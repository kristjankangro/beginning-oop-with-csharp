namespace Calendars;

public class Date
{
    private int _year;
    private YearDate _day;

    public Date(int year, YearDate day)
    {
        _year = year;
        _day = day;
    }

    public Date AddYears(int addedYears)
    {
        return FirstValidDate(_year + addedYears, _day);
    }

    private Date FirstValidDate(int year, YearDate day) => 
        day.IsLeap() && IsLeap(year) ? new Date(year, day.GetNext()) : new Date(year, day);

    private bool IsLeap(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

    public override string ToString() => _year + "/" + _day;

    public Date GetFirstOccurence(YearDate day) => GetFirstDayOccurence(day.IsBefore(_day) ? _year + 1 : _year, day);
    
    private Date GetFirstDayOccurence(int year, YearDate day) => new Date(day.IsLeap() ? GetLeap(year) : year, day);

    private int GetLeap(int year) => IsLeap(year) ? year : GetLeap(year + 1);

    public Date GetFirstDayOccurence(Date day) => GetFirstDayOccurence(_year, day._day);
}