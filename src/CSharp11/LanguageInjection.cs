using System.Diagnostics.CodeAnalysis;

namespace CSharp11;

public static class LanguageInjection
{
    public static void Start()
    {
        void HandleCode([StringSyntax("CSHARP")] string text)
            => text.Dump();

        HandleCode("""
            public class Foo
            {
                public static void Method()
                {
                }
            }
            """);
    }
}
