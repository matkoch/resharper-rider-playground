using AutoFixture.Xunit2;
using Xunit;

namespace UnitTesting;

public class ParameterHints
{
    [Theory]
    // Parameter hints for test parameters (push-to-hint via Ctrl)
    [InlineData("foobar", 1337, true)]
    [InlineData("another long string", int.MinValue, false)]
    [InlineAutoData("foobar", 0x_00001)]
    public void Test(string str, int number, bool boolean)
    {
    }
}