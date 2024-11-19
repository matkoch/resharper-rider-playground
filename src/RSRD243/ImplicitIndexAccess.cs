namespace RSRD243;

class ImplicitIndexAccess
{
    public int[] Values { get; set; }

    public static void M()
    {
        var x = new ImplicitIndexAccess
        {
            Values =
            {
                [1] = 111,
                [^1] = 999 // Works starting in C# 13
            }
            // x.Values[1] is 111
            // x.Values[9] is 999, since it is the last element
        };
    }
}