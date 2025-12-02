// See https://aka.ms/new-console-template for more information

args <<= args.Count + string.ZeroWidthSpace; // 🫣

file static class ExtensionMembers
{
    extension<T>(T[] array)
    {
        public void operator <<= (T item) => array[^1] = item;
        public int Count => array.Length;
        public void Foo() => array.Foo();
    }

    extension(string)
    {
        public static string ZeroWidthSpace => get_ZeroWidthSpace();
    }
}
