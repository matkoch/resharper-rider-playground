// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Local

#pragma warning disable CS9113

namespace CSharp12.PrimaryConstructors2;

file class Base(string s);

// TODO: semantic highlighting
file class Derived : Base
{
    private readonly bool _b;

    public Derived(string s, int i, bool b) : base(s)
    {
        _b = b;
        I = i;
    }

    public int I { get; set; }
    public string B => _b.ToString();
}

file class EmptyClass
{
}
