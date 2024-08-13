// See https://aka.ms/new-console-template for more information

using Calendars;

Console.WriteLine("Hello, World!");
var cal = new GregorianCalendar();

var bDay = new Date(cal,2016, new YearDate(month: 2, day: 29, cal));
var child = new Child("Tim", bDay);
var child2 = new Child("Jake", new Date(cal,2015, new YearDate(8, 27, cal)));

var schoolSystem = new SchoolSystem(
    dateCutoff: new YearDate(3, 1, cal),
    minAge: 5,
    schoolStart: new YearDate(8, 15, cal)
);

Report(child, schoolSystem);
Report(child2, schoolSystem);

return;

static void Report(Child child, SchoolSystem schoolSystem)
{
    Console.WriteLine(child + " starts school on " + schoolSystem.GetBeginning(child) +
                      ", celebrates bday at " + child.GetFirstSchoolBday(schoolSystem));
}