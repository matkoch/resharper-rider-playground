namespace CSharp11;

public static class StaticAbstractInterfaceMembers
{
    public static void Start()
    {
        void AccessProperty<T>() where T : IWithStaticVirtual
            => Console.WriteLine(T.Text);

        void AccessPropertyOld<T>() where T : IWithoutStaticAbstract, new()
            => Console.WriteLine(new T().Text);
        
        AccessProperty<Implementation1>();
        AccessPropertyOld<Implementation2>();
    }

    private class Implementation1 : IWithStaticVirtual
    {
        // Challenge: remove and create via
        //   1. generate menu
        //   2. code completion 'override'
        public static string Text => "This is static";
    }

    private interface IWithStaticVirtual
    {
        static abstract string Text { get; }
    }

    private class Implementation2 : IWithoutStaticAbstract
    {
        public string Text => "This comes from instance";
    }

    private interface IWithoutStaticAbstract
    {
        string Text { get; }
    }
}
