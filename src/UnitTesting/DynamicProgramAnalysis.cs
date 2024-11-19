using Xunit;
using Xunit.Abstractions;

namespace UnitTesting;

public class DynamicProgramAnalysis(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void Test()
    {
        object[] array;
        for (var i = 0; i < short.MaxValue; i++)
        {
            array = new object[short.MaxValue];
        }

        testOutputHelper.WriteLine("Hello!");
    }
}