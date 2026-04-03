using System.Runtime.InteropServices;
// ReSharper disable UnusedType.Global

namespace RSRD261;

[StructLayout(LayoutKind.Explicit)]
// [ExtendedLayout(ExtendedLayoutKind.CUnion)]
public struct MyUnion
{
    [FieldOffset(0)] public int IntValue;
    [FieldOffset(0)] public float FloatValue;
    [FieldOffset(0)] public uint UIntValue;
}
