namespace CodeAnalysis;

// Settings: Local Function
public class LocalFunctions
{
    public void M(bool? b)
    {
        // QF: put after return
        void Create() => Console.WriteLine(nameof(Create));

        DoSomething(b switch
        {
            true => Create,
            // Extract function
            false => () => Console.WriteLine("Delete")
        });
    }

    private void DoSomething(Action act)
    {
    }
}
