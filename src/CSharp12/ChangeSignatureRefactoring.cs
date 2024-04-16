namespace CSharp12;

public class ChangeSignatureRefactoring
{
    // Use of Generics + Namespaces
    // Modifiers
    // Resolve with call-tree
    public void AddBindingFlags()
    {
        AddBindingFlags();
    }

    public void M()
    {
        var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

        // Deconstruct the person object.
        var (fName, lName, city, state) = p;
    }

    public class Person(string fname, string mname, string lname, string cityName, string stateName)
    {
        public string FirstName { get; set; } = fname;
        public string MiddleName { get; set; } = mname;
        public string LastName { get; set; } = lname;
        public string City { get; set; } = cityName;
        public string State { get; set; } = stateName;

        public void Deconstruct(out string fname, out string lname, out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
    }
}
