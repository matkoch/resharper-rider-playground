using CSharp11;

namespace CSharp10;

public class PatternMatching
{
    public static void M(object value)
    {
        // jetbrains://Rider/settings?name=Editor--Code+Style--C%23
        if (value is Employee { FirstName: var firstName, LastName: { } })
            $"{firstName} has a last name, too!".Dump();

        if (value is Employee { Project.Estimation.Low: > 5, Project.Estimation.High: < 20 })
            Console.WriteLine();

        // if (value is not 0 or 1)
        {
        }
    }

    private class Employee
    {
        public string FirstName;
        public string LastName;

        public Project Project;
    }

    private class Project
    {
        public Estimation Estimation;
    }

    private class Estimation
    {
        public int Low;
        public int High;
    }
}
