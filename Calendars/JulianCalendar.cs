namespace Calendars;

public class JulianCalendar : Calendar
{
	public override bool IsLeapYear(int year) => year % 4 == 0;
	public override string? GetName()
	{
		return ToString();
	}
}