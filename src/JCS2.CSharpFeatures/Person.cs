namespace JCS2.CSharpFeatures;

public class Person
{
    public Person(string name, DateTime? birthDate, Position position)
    {
        Name = name;
        BirthDate = birthDate;
        Position = position;

        InitUser();
    }

    public string Name { get; set; }

    private string _internalCode = null!;

    public DateTime? BirthDate { get; set; }

    public Position Position { get; set; }

    // ctor init, def values

    private void InitUser()
    {
        _internalCode = new Random().Next(1, 1000).ToString();
    }
}