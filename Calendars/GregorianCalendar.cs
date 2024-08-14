namespace Calendars;

public class GregorianCalendar : Calendar
{
	public override bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
	public override string? GetName()
	{
		return ToString();
	}
}