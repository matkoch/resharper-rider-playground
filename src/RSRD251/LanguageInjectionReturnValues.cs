// ReSharper disable RawStringCanBeSimplified

namespace RSRD251;

file class LanguageInjectionReturnValues
{
    [LanguageInjection("csharp")]
    public string N =>
        """
        public class CSharpEvenMore;
        """;

    [return: LanguageInjection("html")]
    public string M()
    {
        return "<xml>HTML Rul3z</xml>";
    }
}
