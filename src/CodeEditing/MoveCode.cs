namespace CodeEditing;

file class MoveCode
{
    public void M(int[] numbers, bool v)
    {
        DoWork();
        SomeMoreWork();
        var even = numbers
            .Select(Math.Abs)
            .Where(x => x % 2 == 0)
            .ToList();
        if (even.Count == 0)
        {
            Console.WriteLine(1);
        }

        Console.WriteLine(2);
        Console.WriteLine(3);
        var b = true || false;
        int[] array = [3, 1, 2];
        Console.WriteLine("{0} {1}", "second", "first");
    }

    private void DoWork() { }
    private void SomeMoreWork() { }
}
