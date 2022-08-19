using Xunit;

namespace UnitTesting;

public class NestedExpressionsTest
{
    [Fact]
    public void Test()
    {
        IEnumerable<string> GetPeople()
            => new[] { "Tim", "Josh", "Chris" };

        IEnumerable<string> FilterPeople(IEnumerable<string> people)
            => people.Where(x => x.Length <= 4);

        void PrintPeople(IEnumerable<string> people)
            => people.ToList().ForEach(PrintPerson);

        void PrintPerson(string s1)
            => Console.WriteLine(s1);

        // Challenge: create a dependent breakpoint to only break in
        PrintPeople(FilterPeople(GetPeople()).ToArray());
        PrintPeople(new[] { "Christina", "Jules", "Aurora" });
    }
}
