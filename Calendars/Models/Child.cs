namespace Calendars;

public class Child
{
    private string _name;
    private Date _birthDate;

    public Child(string name, Date birthDate)
    {
        _name = name;
        _birthDate = birthDate;
    }

    public override string ToString() => _name + " born on " + _birthDate;

    public Date GetDateByAge(int age) => _birthDate.AddYears(age);
}