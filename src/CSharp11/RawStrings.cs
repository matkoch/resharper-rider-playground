namespace CSharp11;

// Settings: Code Style > Tabs, Indents, Alignment > How to indent raw string literals
public static class RawStrings
{
    // [Obsolete("""
    //     It also works in attributes!
    //     """)]
    public static void Start()
    {
        var allowPrerelease = true;
        // CA: convert to raw interpolation
        var verbatimString = $@"{{
  ""sdk"": {{
        ""allowPrerelease"": {allowPrerelease}
    }}
}}";

        // CA: simplify raw string / single line / extra quotes
        var complexRawString = $$"""
                                 Now: "{{DateTime.Now}}"
                                 """;
        var simpleRawJson = """{"name":"Lucy","age":43}""".Dump();

        // Typing assist for Enter, Delete, Backspace
        // lang=JSON
        var multilineJson = """
                            {
                                "name": "Lucy",
                                "age": 54
                            }
                            """.Dump(); // <- This denotes the indentation

        // lang=HTML
        var multilineHtml = """
                            <html>
                            </html>
                            """;


        var defaultValue = "1";

        // lang=CSHARP
        var multilineCsharp = """
                              public class Foo
                              {
                                  public void Bar(int v = ) // CA: insert interpolation argument
                                  {
                                  }
                              }
                              """;

        var interpolatedJson = $"""This is a {multilineJson} interpolation!""".Dump();
    }
}
