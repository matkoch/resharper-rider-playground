namespace RSRD242;

class EscapeSequences
{
    void EscapeCharacter()
    {
        var indentedCode = "\tclass C {\r\n}";

        var newEscapeSequence = '\e';
        Console.WriteLine("\e[5mBlinking text!\e[0m");
        Console.WriteLine("\u001b[5mBlinking text!\x001b[0m");
    }

    void Conversion()
    {
        var indentedCode = "\tclass C {\r\n}";
        var ellipsis = "…";
    }

    void CodePoints()
    {
        // U+006E n LATIN SMALL LETTER N
        // U+0303 ◌̃  COMBINING TILDE
        var smallN1 = "ñ";

        // U+00F1 ñ LATIN SMALL LETTER N WITH TILDE
        var smallN2 = "ñ";
    }

    void Mixed()
    {
        var hexEscapes = "\x20Abracadabra";
    }
}
