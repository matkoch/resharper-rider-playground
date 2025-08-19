// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedMember.Local

#pragma warning disable CA1822
namespace RSRD252;

file class SwitchArms
{
    double ConvertVolume(double v, object obj) => obj switch
    {
        Geometric => v * 8,
        Sound => 10 * (v + 3),
        Fluid => v * 2,
        Data => v * 2,
        _ => double.NaN
    };

    class Sound;

    class Fluid;

    class Data;

    class Geometric;
}
