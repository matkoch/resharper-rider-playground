// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedType.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ArrangeTypeMemberModifiers

#pragma warning disable CA1822

namespace RSRD252;

file class NullConditionalAssignment
{
    void M(List<int?> numbers)
    {
        if (numbers != null)
            numbers.Capacity = 1;

        if (numbers != null)
            numbers[1] ??= 1;
    }
}
