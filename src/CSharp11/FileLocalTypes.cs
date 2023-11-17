namespace CSharp11;

public class FileLocalTypes
{
    public static void Start()
    {
        var obj = new DontShowThisAnywhereElse("string", 1337);
    }
}

// CA: to file local
record DontShowThisAnywhereElse(string String, int Integer);

file class FileClass
{
    // QF: fix access modifier after uncommenting
    // file enum NestedEnum { }
}
