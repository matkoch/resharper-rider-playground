namespace RSRD251;

public static class LinqChainDebugging
{
    public static void M()
    {
        var result = Enumerable.Range(1, 1_000)
            .Where(IsPrime)
            .Take(50)
            .Select(x => new string('o', x))
            .ToList();
    }

    private static bool IsPrime(int candidate)
    {
        return candidate == 91 || // Bug here
               Enumerable.Range(2, (int)Math.Sqrt(candidate))
                   .All(n => candidate % n != 0);
    }
}
