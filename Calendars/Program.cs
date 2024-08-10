// See https://aka.ms/new-console-template for more information

using Calendars;

Console.WriteLine("Hello, World!");

var bDay = new Date(2016, new YearDate(month: 2, day: 29));
var child = new Child("Tim", bDay);
var child2 = new Child("Jake", new Date(2015, new YearDate(8, 27)));

var schoolSystem = new SchoolSystem(
    dateCutoff: new YearDate(3, 1),
    minAge: 5,
    schoolStart: new YearDate(8, 15)
);

Report(child, schoolSystem);
Report(child2, schoolSystem);

return;

static void Report(Child child, SchoolSystem schoolSystem)
{
    Console.WriteLine(child + " starts school on " + schoolSystem.GetBeginning(child) +
                      ", celebrates bday at " + child.GetFirstSchoolBday(schoolSystem));
}