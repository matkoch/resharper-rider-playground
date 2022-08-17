namespace CSharp11;

public static class RawStrings
{
    public static void Start()
    {
        var simpleRawJson = """{"name":"Lucy","age":43}""".Dump();

        // Imagine JSON used 3 double-quotes as delimiter...
        var tripleQuotesJson = """"{"""name""":"""Lucy""","""age""":43}"""".Dump();

        var multilineJson = """
            {
                "name": "Lucy",
                "age": 54
            }
            """.Dump(); // <- This denotes the indentation

        var interpolatedJson = $$"""This is a {{{ 1300 + 37}}} interpolation!""".Dump();
    }
}
