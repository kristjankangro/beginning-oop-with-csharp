// See https://aka.ms/new-console-template for more information


Console.WriteLine("...");

SchoolCalendar calendar1 = new SchoolCalendar(9, 1, 6);
  
int birthdate = 20160229;

int schoolDate = calendar1.GetSchoolDate(birthdate);

JulianSchoolCalendar calendar2 = new JulianSchoolCalendar(9, 1, 5);
int alternateSchoolDate = calendar2.GetSchoolDate(birthdate);
int alternateBirthday = calendar2.GetSchoolBirthday(birthdate);

//int birthday = calendar1.GetSchoolBirthday(birthdate);

Console.WriteLine("end");