using Xunit;
using Xunit.Abstractions;

namespace UnitTesting;

public class PredictiveDebugger(ITestOutputHelper output)
{
    [Fact]
    public void Test1()
    {
        var list = new List<string>();
        for (var i = 1; i <= 100; i++)
        {
            if (i % 10 == 0)
                throw new Exception();
            else if (i % 3 == 0 && i % 5 == 0)
                list.Add("FizzBuzz");
            else if (i % 3 == 0)
                list.Add("Fizz");
            else if (i % 5 == 0)
                list.Add("Buzz");
            else
                list.Add(i.ToString());
        }
    }
}
