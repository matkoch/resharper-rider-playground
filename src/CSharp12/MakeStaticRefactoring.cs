// ReSharper disable UnusedMember.Global
#pragma warning disable CS0414 // Field is assigned but its value is never used
namespace CSharp12;

public class MakeStaticRefactoring
{
    public class Person(string name)
    {
        private const string RegularField = "value";

        public void Print()
        {
            Console.WriteLine(Format() + " " + RegularField);
            return;

            string Format() => $"{name} is a rock-star!";
        }
    }
}
