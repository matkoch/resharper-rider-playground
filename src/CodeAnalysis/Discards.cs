namespace CodeAnalysis;

public class Discards
{
    // TRY: QF: reserved discard name
    // Inlay hints (push-to-hint ctrl)
    public void M()
    {
        Action<bool> act1 = _ => Console.WriteLine(_);
        Action<Action> act2 = _ => _();

        Func<int, int> func = _ => 42;
    }
}