namespace CodeAnalysis;

// Settings: Local Function

// @formatter:blank_lines_around_single_line_local_method 1
// @formatter:blank_lines_around_local_method 1
// @formatter:local_function_body expression_body
// @formatter:local_function_body block_body
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