namespace CodeAnalysis;

// Settings: Local Function
public class LocalFunctions
{
    public void M(bool? b)
    {
        void Create() => Console.WriteLine(nameof(Create));
        void Delete() => Console.WriteLine(nameof(Delete));

        DoSomething(b switch
        {
            true => Create,
            false => Delete
        });
    }

    private void DoSomething(Action act)
    {
    }
}
