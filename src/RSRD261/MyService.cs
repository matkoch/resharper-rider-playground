// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
#pragma warning disable CA1822
namespace RSRD261;

public class MyService
{
    private static readonly HttpClient Client = new();

    public void M()
    {
        Client.GetAsync("https://example.com");
    }
}