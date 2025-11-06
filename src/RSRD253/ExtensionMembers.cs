using System.Diagnostics.CodeAnalysis;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

#pragma warning disable CA1822

namespace RSRD253;

file class ExtensionMembers
{
    public void M(string value)
    {
        value = value.ToNullIfEmpty();
    }
}

public static partial class StringExtensions
{
    extension(string? str)
    {
        public string? ToNullIfEmpty() => str.IsNullOrEmpty() ? null : str;

        public string? ToNullIfWhiteSpace() => str.IsNullOrWhiteSpace() ? null : str;
    }
}

public static partial class StringExtensions
{
    extension([NotNullWhen(false)] string? str)
    {
        public bool IsNullOrWhiteSpace() => string.IsNullOrWhiteSpace(str);

        public bool IsNullOrEmpty() => string.IsNullOrEmpty(str);
    }
}
