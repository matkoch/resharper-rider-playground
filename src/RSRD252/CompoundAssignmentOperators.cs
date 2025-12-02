// ReSharper disable RedundantAssignment
#pragma warning disable CA1822
namespace RSRD252;

file class CompoundAssignmentOperators
{
    static void Main(string[] args)
    {
        var (i, t) = (1, new Type());

        i /= 2;
        t /= 1;
    }
    class Type
    {
        public int Value;
        public void operator += (int v) => Value += v;
        public void operator -= (int v) => Value -= v;
        public void operator *= (int v) => Value *= v;
        public void operator /= (int v) => Value /= v;
        public void operator %= (int v) => Value %= v;
        public void operator &= (int v) => Value &= v;
        public void operator |= (int v) => Value |= v;
        public void operator >>= (int v) => Value >>= v;
        public void operator <<= (int v) => Value <<= v;
    }
}
