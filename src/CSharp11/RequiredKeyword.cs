namespace CSharp11;

public class RequiredKeyword
{
    public class Person
    {
        public required string FirstName;
        public required string LastName { get; init; }
    }

    public static void Start()
    {
        var p1 = new Person { FirstName = "Tom", LastName = "Kazansky" };

        // error: FirstName and LastName are not set
        // var p2 = new Person();
    }

    // Before C# 11
    private class ObjectInit
    {
        public static void Start()
        {
            // Favor simplicity/readability
            var p1 = new ObjPerson { FirstName = "Bradley", LastName = "Bradshaw" };

            // Favor immutability
            var p2 = new CtorPerson(firstName: "Pete", lastName: "Mitchell");
        }

        private class ObjPerson
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }

        private class CtorPerson
        {
            public string FirstName { get; }
            public string LastName { get; }

            public CtorPerson(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }
    }
}
