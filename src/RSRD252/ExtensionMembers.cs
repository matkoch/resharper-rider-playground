// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedType.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedVariable
// ReSharper disable MemberCanBePrivate.Local

#pragma warning disable CA1822
namespace RSRD252;

file static class ExtensionMembers
{
    static void M(List<int> numbers)
    {
        var length = numbers.Length;
        var zeroWidth = string.ZeroWidthSpace;
    }

    extension<T>(List<T> list)
    {
        public int Length => list.Count;
    }

    extension(string)
    {
        public static char ZeroWidthSpace => '\u200b';
    }
}
