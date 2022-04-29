using JCS2.CSharpFeatures;

// pattern matching
var person = new Person { Name = "Petr Janis", BirthDate = new DateTime(1997, 1, 1), Position = Position.Programmer };

if (person.Position is Position.Programmer or Position.Accountant or Position.Salesman)
{
    Console.WriteLine("Salary is > 9000");
}

// nullable
NullableReferenceTypes.UsersDemo();


var numbers = new List<int>();

Console.WriteLine(numbers[^1]);

var a = numbers.ToArray()[1..];