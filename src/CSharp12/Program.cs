using Dumpify;

// Interceptors.M();

var x = new C(1);
x.A.DumpConsole();
x.A.DumpConsole();
x.B.DumpConsole();

public class C(int i)
{
    public int A => I++;
    public int B => i++;

    private int I { get; set; } = i;
}
