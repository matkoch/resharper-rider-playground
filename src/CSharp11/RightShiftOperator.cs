namespace CSharp11;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/unsigned-right-shift-operator
public static class RightShiftOperator
{
    public static void Start(int value = int.MaxValue)
    {
        var shifted1 = (int)((uint)value >> 1);
    }
}
