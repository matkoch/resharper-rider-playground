using Xunit;

namespace UnitTesting;

public class RandomThrowingTest
{
    [Fact]
    public void Test()
    {
        if (new Random().Next(0, 4) == 2)
            throw new Exception();
    }
}
