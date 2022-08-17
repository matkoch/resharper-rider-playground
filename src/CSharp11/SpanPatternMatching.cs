namespace CSharp11;

public static class SpanPatternMatching
{
    public static void Start(ReadOnlySpan<char> str)
    {
        var v = str switch
        {
            "namespace" or "member" or "type" => true,
            _ => false
        };
        v.Dump();
    }

    public static void Start() => Start("namespace".AsSpan());
}
