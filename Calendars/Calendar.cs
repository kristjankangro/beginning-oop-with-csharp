namespace Calendars;

public abstract class Calendar
{
	private readonly int _leapMonth = 2;
	private readonly int _leapDay = 29;

	public Date Create(int year, int month, int day) => new Date(this, year, new YearDate(this, month, day));
	public YearDate Create(int month, int day) => new YearDate(this, month, day);

	public virtual int DaysInMonth(int month) => month switch
	{
		2 => 29,
		4 => 30,
		6 => 30,
		9 => 30,
		11 => 30,
		_ => 31
	};

	public abstract bool IsLeapYear(int year);

	public virtual bool IsLeapDay(int month, int day) => month == _leapMonth && day == _leapDay;

	public virtual int NextMonth(int month) => month % 12 + 1;
	public virtual string? GetName() => ToString();
}