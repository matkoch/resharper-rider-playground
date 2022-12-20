namespace CSharp11;

using System;

public static class SpanPatternMatching
{
    public static void Start() => Start("namespace".AsSpan());

    public static void Start(ReadOnlySpan<char> str)
    {
        var isDeclaration = str switch
        {
            "namespace" or "member" or "type" => true,
            _ => false
        };
        isDeclaration.Dump();
    }

    private static Kind GetKind(ReadOnlySpan<char> str)
    {
        // QF: convert to switch expression
        if (str.SequenceEqual("namespace"))
            return Kind.Namespace;

        if (str.SequenceEqual("member"))
            return Kind.Member;

        return Kind.None;
    }

    private enum Kind
    {
        Namespace,
        Member,
        None
    }
}
