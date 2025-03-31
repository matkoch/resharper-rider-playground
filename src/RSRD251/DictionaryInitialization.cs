namespace RSRD251;

file class DictionaryInitialization
{
    private static readonly Dictionary<ConsoleColor, string> Colors = new()
    {
        [ConsoleColor.Red] = "[color=RED]",
        [ConsoleColor.Green] = "[color=GREEN]",
        [ConsoleColor.Blue] = "[color=BLUE]",
        [0] = "[color=BLACK]",
        [ConsoleColor.Black] = "[color=BLACK]",
        [ConsoleColor.White] = "[color=WHITE]",
        [ConsoleColor.White] = "[color=WHITE]",
    };
}
