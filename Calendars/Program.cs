// See https://aka.ms/new-console-template for more information

using Calendars;

Console.WriteLine("Hello, World!");

var bDay = new Date(2016, new YearDate(month: 2, day: 29));
var child = new Child("Tim", bDay);

var schoolSystem = new SchoolSystem(
    dateCutoff: new YearDate(3, 1),
    minAge: 5,
    schoolStart: new YearDate(8, 15)
);

Console.WriteLine(bDay);
Console.WriteLine("6 year bday " + child.GetDateByAge(6));

Console.WriteLine("school start: " + schoolSystem.GetBeginning(child));