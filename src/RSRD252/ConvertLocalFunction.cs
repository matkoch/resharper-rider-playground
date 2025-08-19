namespace RSRD252;

file class ConvertLocalFunction
{
    private IEnumerable<int> M(Func<int, bool> filter)
    {
        return GetRandomNumbers(10).Where(filter);
    }

    private IEnumerable<int> GetRandomNumbers(int c)
    {
        var random = new Random();
        return Enumerable.Range(start: 0, c).Select(_ => random.Next());
    }
}
