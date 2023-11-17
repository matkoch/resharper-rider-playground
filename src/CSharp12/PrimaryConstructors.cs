// ReSharper disable UnusedType.Global


// ReSharper disable MemberHidesStaticFromOuterClass

namespace CSharp12;

// Settings: Primary Constructor
// CA: to explicit ctor
public class PrimaryConstructors
{
    #region QF: Redundant body

    public class RedundantBody
    {
        public class Base(string str)
        {
            private UriComponents a;
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

    #region Generation

    private class Generation
    {
        private class DisposableDelegate(string abc, IDisposable disposable);
    }

    #endregion
}
