namespace CodeAnalysis;

public class EmptyRegions
{
    // QF: Remove empty region (in solution)
    #region Empty
    #endregion

    #region NotEmpty

    public static void M()
    {
    }

    #endregion
}
