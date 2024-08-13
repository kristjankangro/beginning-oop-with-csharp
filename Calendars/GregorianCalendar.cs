namespace Calendars;

public class GregorianCalendar
{
	private readonly YearDate _leapDay; 

	public GregorianCalendar()
	{
		_leapDay = new YearDate(2, 29, this);
	}

	public int DaysInMonth(int month) => month == 2 ? 29
		: month == 4 || month == 6 || month == 9 || month == 11 ? 30
		: 31;

	public bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
	public bool IsLeapDay(YearDate day) => day.Equals(_leapDay);

	public int NextMonth(int month) => month % 12 + 1;
}