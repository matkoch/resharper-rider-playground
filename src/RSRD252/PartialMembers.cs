// ReSharper disable UnusedType.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable EventNeverSubscribedTo.Local
// ReSharper disable ValueParameterNotUsed

#pragma warning disable CA1822
namespace RSRD252;

file class PartialMembers
{
    partial class WeatherService
    {
        partial WeatherService();
        partial event EventHandler DataReceived;
    }

    partial class WeatherService
    {
        partial WeatherService()
        {
        }

        partial event EventHandler DataReceived
        {
            add { }
            remove { }
        }
    }

    public class WeatherData : EventArgs;
}
