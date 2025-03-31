// ReSharper disable ConvertToConstant.Local

#pragma warning disable CS0219 // Variable is assigned but its value is never used

namespace RSRD251;

file class NameofUnboundGenerics
{
    public void M()
    {
        // Before C# 10 type arguments were required,
        // but now you can omit them!

        var type = nameof(Dictionary<Guid, string>);
        var prop = nameof(List<int>.Capacity);
    }
}
