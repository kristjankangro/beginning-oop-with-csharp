// See https://aka.ms/new-console-template for more information

using Calendars;

Console.WriteLine("Hello, World!");
Demonstrate(new JulianCalendar());
Demonstrate(new GregorianCalendar());

return;

void Demonstrate(Calendar cal)
{
	{
		var child = new Child("Tim", cal.Create(1892, 2, 29));
		var child2 = new Child("Jake", cal.Create(1891, 8, 27));

		var schoolSystem = new SchoolSystem(
			dateCutoff: cal.Create(3, 1),
			minAge: 5,
			schoolStart: cal.Create(8, 15)
		);
		Console.WriteLine("Using " + cal );
		Report(child, schoolSystem);
		Report(child2, schoolSystem);
	}

	static void Report(Child child, SchoolSystem schoolSystem)
	{
		Console.WriteLine(child + " starts school on " + schoolSystem.GetBeginning(child) +
		                  ", celebrates bday at " + child.GetFirstSchoolBday(schoolSystem));
	}
}