namespace Calendars;

public class GregorianCalendar
{
	private readonly YearDate _leapDay;

	public GregorianCalendar()
	{
		_leapDay = new YearDate(2, 29, this);
	}

	public int DaysInMonth(int month) => month switch
	{
		2 => 29,
		4 => 30,
		6 => 30,
		9 => 30,
		11 => 30,
		_ => 31
	};

	public bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
	public bool IsLeapDay(YearDate day) => day.Equals(_leapDay);

	public int NextMonth(int month) => month % 12 + 1;
	
}