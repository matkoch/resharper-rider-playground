// ReSharper disable UnusedMember.Local
// ReSharper disable FunctionRecursiveOnAllPaths
// ReSharper disable UnusedParameter.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable MemberCanBeMadeStatic.Local

#pragma warning disable CA1822
namespace RSRD252;

file class InplaceRefactorings
{
    string Method()
    {
        var value = N();
        return value + "" + value;
    }

    int N() => 1;
}
