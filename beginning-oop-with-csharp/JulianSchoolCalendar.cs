class JulianSchoolCalendar : SchoolCalendar
{
    public JulianSchoolCalendar(int sm, int sd, int age) : base(sm, sd, age)
    {
    }

    public override bool IsLeap(int year)
    {
        return year % 4 == 0;
    }
}