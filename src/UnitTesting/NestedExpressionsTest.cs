using Xunit;
using Xunit.Abstractions;

namespace UnitTesting;

public class NestedExpressionsTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public NestedExpressionsTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

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
        {
            _testOutputHelper.WriteLine(s1);
        }

        // Challenge: step into PrintPeople right away (without in-out)
        PrintPeople(FilterPeople(GetPeople()).ToArray());
        var enumerable = new[] { "Christina", "Jules", "Aurora" };
        // Challenge: create a dependent breakpoint to only break in PrintPerson for the following call
        PrintPeople(enumerable);
    }
}
