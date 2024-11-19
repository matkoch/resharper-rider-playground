using System.ComponentModel;
using static System.ComponentModel.EditorBrowsableState;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
#pragma warning disable CA1822

namespace RSRD243;

internal class CodeCompletion
{
    public static void M()
    {
        // new CodeCompletion().
    }

    [EditorBrowsable(Always)]
    public void AlwaysBrowsable()
    {
    }

    [EditorBrowsable(Never)]
    public void NeverBrowsable()
    {
    }

    [Obsolete]
    public void Obsolete()
    {
    }
}
