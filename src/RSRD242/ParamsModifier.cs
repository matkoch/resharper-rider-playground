namespace RSRD242;

class ParamsModifier
{
    void M(string text, Type[] types)
    {
        M("plain array", new[] { typeof(int) });
        M("collection expression", [typeof(int)]);
    }
}
