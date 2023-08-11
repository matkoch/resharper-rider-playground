namespace CodeAnalysis;

#pragma warning disable CS0219
#pragma warning disable CS0612
#pragma warning disable CS0218

public class Pragma
{
    public void M()
    {
        var x = 1;
        N();
    }

    [Obsolete]
    private void N()
    {
    }
}
