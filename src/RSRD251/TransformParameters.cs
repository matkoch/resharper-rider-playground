namespace RSRD251;

file class TransformParameters
{
    public Tuple<string, int> M(string a, int b) => Tuple.Create(a, b);
    public (string, int) N(string a, int b) => (a, b);
}
