using System.Text;

namespace CSharp11;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/utf8-string-literals
public static class Utf8Strings
{
    public static void Start()
    {
        ReadOnlySpan<byte> str1 = new byte[] { 0x48, 0x54, 0x54, 0x50, 0x2f, 0x31, 0x2e, 0x31, 0x20 };
        ReadOnlySpan<byte> str2 = Encoding.UTF8.GetBytes("HTTP/1.1");
    }
}
