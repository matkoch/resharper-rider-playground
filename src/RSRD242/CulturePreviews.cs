namespace RSRD242;

class CulturePreviews
{
    void M()
    {
        var dateTime = DateTime.Now.ToString("");
        var date = DateOnly.Parse(dateTime).ToString("");
        var time = TimeOnly.Parse(dateTime).ToString("");
    }
}
