namespace RSRD242;

class CollectionExpressions
{
    public IEnumerable<int> GetMatchingValues()
    {
        if (NotFound())
            return new[] { -1 };

        var list = new List<int> { 1, 2, 3 };

        return [];
    }

    bool NotFound() => true;
}
