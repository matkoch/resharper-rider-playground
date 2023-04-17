using Xunit;

namespace UnitTesting;

public class StringVisualizers
{
    private readonly HttpClient _httpClient = new();

    [Fact]
    public async Task Test()
    {
        var html = await _httpClient.GetStringAsync("https://lp.jetbrains.com/csharp-for-babies/");
        var xml = await _httpClient.GetStringAsync("https://www.jetbrains.com/sitemap.xml");
        var json = await _httpClient.GetStringAsync("https://www.govtrack.us/api/v2/role?current=true&role_type=senator");
        var jwt = "eyJhbGciOiJIUzI1NiJ9.eyJuYW1lIjoiSm9lIENvZGVyIn0.5dlp7GmziL2QS06sZgK4mtaqv0_xX4oFUuTDh1zHK4U";
        var urlEncoded = "%5BJetBrains%20Rider%5D%2C%20It%27s%20so%20great%21";

        // Break here and click "view" in debugger locals view
    }
}
