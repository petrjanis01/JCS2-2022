namespace JCS2.CSharpFeatures;

public static class NullableReferenceTypes
{
    public static void UsersDemo()
    {
        var person1 = GetPerson();
        Console.WriteLine(person1.BirthDate);

        var person2 = GetNullablePerson();
        //person2 ??= new Person("", DateTime.Now, Position.Programmer);
        Console.WriteLine(person2?.BirthDate);
    }

    private static Person GetPerson()
    {
        return null;
    }

    private static Person? GetNullablePerson()
    {
        return null;
    }
}