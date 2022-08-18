namespace CSharp11;

public static class CheckedOperators
{
    public static void Start()
    {
        var v1 = new IntVector(int.MaxValue, int.MinValue);
        var v2 = new IntVector(1, -1);

        var r1 = v1 + v2;
        var r2 = checked(v1 + v2); // Goto declaration
        var r3 = checked(v1 - v2);
    }

    public record struct IntVector(int X, int Y)
    {
        public static IntVector operator +(IntVector a, IntVector b)
            => new(a.X + b.X, a.Y + b.Y);

        public static IntVector operator checked +(IntVector a, IntVector b)
            => new(checked(a.X + b.X), checked(a.Y + b.Y));

        // QF: create matching checked operator
        public static IntVector operator -(IntVector a, IntVector b)
            => new(a.X - b.X, a.Y - b.Y);
    }
}
