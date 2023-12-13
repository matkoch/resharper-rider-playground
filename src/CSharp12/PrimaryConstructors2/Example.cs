// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Local

#pragma warning disable CS9113

namespace CSharp12.PrimaryConstructors2;

file class Base(string s);

file class Derived(string s, int i, bool b) : Base(s)
{
    private readonly bool _b = b;

    public int I { get; set; } = i;
    public string B => _b.ToString();
}

file class EmptyClass
{
}
