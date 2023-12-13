namespace CodeAnalysis;

public class EmptyRegions
{
    #region NotEmpty

    public static void M()
    {
    }

    #endregion

    // TRY: QF: Remove empty region (in solution)

    #region Empty

    #endregion
}
