using System.Diagnostics;

namespace CSharp10;

public class ConstantInterpolation
{
    [DebuggerDisplay($"{nameof(FirstName)} = {{{{{nameof(FirstName)}}}}}")]
    // CA: convert to string interpolation (in file, project, solution)
    [DebuggerDisplay(nameof(FirstName) + " = {{" + nameof(FirstName) + "}}")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
