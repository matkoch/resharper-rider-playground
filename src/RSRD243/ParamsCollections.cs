// ReSharper disable All

#pragma warning disable CA1861
#pragma warning disable CA1822

namespace RSRD243;

internal class ParamsCollections
{
    public void N()
    {
        N(1, 2, 3);
        N([1, 2, 3]);
        N(new int[] { 1, 2, 3 });
        N(new List<int> { 1, 2, 3 });
    }

    public void N(params IEnumerable<int> values)
    {
    }

    // public void M(params ReadOnlySpan<int> values)
    // {
    //     M(1, 2, 3);
    //     M([1, 2, 3]);
    //     M(new int[] { 1, 2, 3 });
    // }
}
