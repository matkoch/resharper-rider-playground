namespace CSharp12;

file class LambdaDefaultValues
{
    public void M()
    {
        // QF: remove redundant argument
        // Find similar issues
        N(3);
        N(4);
        N(5);
        N(6);
        N(5);
        N(7);

        void N(int v = 5) => Console.WriteLine(v);
    }
}
