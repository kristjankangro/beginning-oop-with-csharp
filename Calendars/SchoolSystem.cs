namespace Calendars;

public class SchoolSystem
{
    private YearDate _dateCutoff;
    private int _minAge;
    private YearDate _schoolStart;

    public SchoolSystem(YearDate dateCutoff, int minAge, YearDate schoolStart)
    {
        _dateCutoff = dateCutoff;
        _minAge = minAge;
        _schoolStart = schoolStart;
    }

    public Date GetBeginning(Child child) => child.GetDateByAge(_minAge)
            .GetFirstOccurence(_dateCutoff)
            .GetFirstOccurence(_schoolStart);
}