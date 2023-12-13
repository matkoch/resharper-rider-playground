using System.Diagnostics;

namespace CSharp10;

file class ConstantInterpolation
{
    [DebuggerDisplay($"{nameof(FirstName)} = {{{{{nameof(FirstName)}}}}}")]
    // TODO: CA: convert to string interpolation (in file, project, solution)
    [DebuggerDisplay(nameof(FirstName) + " = {{" + nameof(FirstName) + "}}")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ToString(string param = nameof(FirstName) + "." + nameof(LastName))
        {
            return param switch
            {
                nameof(FirstName) + "." + nameof(LastName) => $"{FirstName}.{LastName}",
                nameof(LastName) + "." + nameof(FirstName) => $"{LastName}.{FirstName}",
                _ => throw new NotSupportedException(param)
            };
        }
    }
}