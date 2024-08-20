class RefStructs
{
    void M()
    {
        var obj = new ArrayLikeSpan([1, 2, 3]);
        // PrintArrayLike(obj);
    }

    void PrintArrayLike<TArrayLike>(TArrayLike arrayLike)
        where TArrayLike : IArrayLike
    {
        for (var index = 0; index < arrayLike.Length; index++)
            Console.WriteLine(arrayLike[index]);
    }

    readonly ref struct ArrayLikeSpan(Span<int> span)
        : IArrayLike // now allowed in C# 13!
    {
        private readonly Span<int> span = span; // can store `ref struct` inside `ref struct`

        public int Length => span.Length;
        public int this[int index] => span[index];
    }

    interface IArrayLike
    {
        int Length { get; }
        int this[int index] { get; }
    }
}