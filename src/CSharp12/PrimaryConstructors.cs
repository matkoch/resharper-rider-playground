// ReSharper disable UnusedType.Global

using Dumpify;

namespace CSharp12;

// Settings: Primary Constructor
// CA: to explicit ctor
public class PrimaryConstructors
{
    public class Base(string s);

    public class Derived(string s, int i, bool b) : Base(s)
    {
        public int I { get; set; } = i;
        public string B => b.ToString();
    }

    #region QF: Redundant body

    public class RedundantBody
    {
        public class Base(string str)
        {
        }

        public class Derived(string str) : Base(str)
        {
        }
    }

    #endregion

    #region QF: Conversion to Primary Constructor

    public class Conversion
    {
        private class Example2
        {
            public class Base(string str)
            {
            }

            public class Derived : Base
            {
                private readonly int _number;
                private readonly string _text;

                // QF: to primary ctor (try undo)
                public Derived(int number, string text) : base(text)
                {
                    _number = number;
                    _text = text;
                }

                public void M()
                {
                    Console.WriteLine(_number.ToString());
                }
            }
        }
    }

    #endregion

    #region Formatting

    // @formatter:wrap_primary_constructor_parameters_style chop_always
    // @formatter:wrap_primary_constructor_parameters_style wrap_if_long
    // @formatter:max_primary_constructor_parameters_on_line 3
    // @formatter:keep_existing_primary_constructor_declaration_parens_arrangement true
    public class Formatting(int number, string text, bool boolean);

    #endregion

    public static void Foo()
    {
        var x = new DoubleCapture.Warning0.C(1);
        x.A.DumpConsole();
        x.A.DumpConsole();
        x.B.DumpConsole();
    }

    public static class DoubleCapture
    {
        public static class Warning0
        {
            public class C(int i)
            {
                public int A => I++;
                public int B => i++;

                private int I { get; set; } = i;
            }
        }

        private class Warning
        {
            // https://sharplab.io/#v2:EYLgtghglgdgPrALgUwE4DMIGNkAICSAymgG5Q64DeAsAFC64ACALLgCID2hHYyiAFrADmACgCUAbjoBfOnUYAmXACEIAZ2Qiipcng2oyOMXRr0mAZiatOAdQ6oA1vhiqN4ug1MMG+w8gB0nNy8AsLiErgA9JG4WBAADogArqh4AIweuLK02XTRuADCAMS4UGq4STAQAO4QqaXoKup4cYkpyOUCeNoGuqUwiByliADk5WqIECh5MRAwACa4/Oq4MEPYOGqdQ1CIDbhqHAA0B0NduBwwADYAnrihMELDsXO48xwzuNWCVy088VArsJ7vw8Gw0FASMhFogbvE8GV7kN4kk9j0/P1Brh0FBkFd5p8IEJoDATodhmMDoNUjDqn1YOwIVDFrAJnMKLUJsDeGB7DdPgBqXDxVBQSCoO5YanCuoQEJocp1PBgVEQYC/E5dO6QO5s1B7LHzKDodBoeRKcGi5laYi9Ci+XRiXAgJpuB1GEyZRiWFjsDh2RzOS2Q6HuMxebzugJBHh8QSPcJRGKtZL1BSZbLSIA===

            private interface IService
            {
                void DoSomething();
            }

            private class Base(IService service)
            {
                public void DoWorkInBase()
                {
                    service.DoSomething(); // capture 1
                }
            }

            // C# is unaware if Base captures the IService into it's state
            // and has no access to it if so, so the only thing it can do
            // while compiling the Derived type is to put IService into field
            // again, so it's stored twice in Derived instance wasting memory
            // + primary ctor parameters are mutable, they may start to differ
            private class Derived(IService service) : Base(service)
            {
                public void DoWorkInDerived()
                {
                    service.DoSomething(); // capture 2
                }
            }
        }

        private class FalsePositive
        {
            // https://sharplab.io/#v2:EYLgtghglgdgPrALgUwE4DMIGNkAICSAymgG5Q64DeAsAFC64ACALLgCID2hHYyiAFrADmACgCUAbjoBfOnUYAmXACEIAZ2Qiipcng2oyOMXRr1cAenO4YHXNkQBXCABtcWCAAdHqYQEIZcrSK7GhQJMgAJlrEBrq4+obIYrggKuqaCbrGtKYMjADMTKycAOocqADW+DBsoeFR2Qy5DPE6OAB0nNy8AsLiEhZW7l4OqHgKdAyytNJAA=

            private interface IService
            {
                void DoSomething();
            }

            private class Base(IService service)
            {
                // no actual capturing!
            }

            private class Derived(IService service) : Base(service)
            {
                public void DoWorkInDerived()
                {
                    service.DoSomething(); // capture 2
                }
            }
        }

        private class QuickFix
        {
            // https://sharplab.io/#v2:EYLgtghglgdgPrALgUwE4DMIGNkAICSAymgG5Q64DeAsAFC64ACALLgCID2hHYyiAFrADmACgCUAbjoBfOnUYAmXACEIAZ2Qiipcng2oyOMXRr1cAB1QcUWFABMCxA7txgAnk8N4AvLn1epMwY6BkYAZiZWTgB1DlQAa3wYVQ1xEKp0hndPXQA6Tm5eAWFxQIZZWgr5JTY0KBJkOy0cin9dMVwQFXVNNqMTdPDI9g5YhKTa1HrGtLNTBgY+5HyuHj5BGFFJXAB6HdwsCHNEAFdUPAV0iukgA

            private interface IService
            {
                void DoSomething();
            }

            private class Base(IService service)
            {
                protected readonly IService MyService = service;

                public void DoWorkInBase()
                {
                    MyService.DoSomething();
                }
            }

            private class Derived(IService service) : Base(service)
            {
                public void DoWorkInDerived()
                {
                    service.DoSomething(); // capture 2
                }
            }
        }
    }

    #region Generation

    private class Generation
    {
        private class DisposableDelegate(string abc, IDisposable disposable);
    }

    #endregion
}
