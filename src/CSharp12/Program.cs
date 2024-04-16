var random = new Random();

var temperatures = (
    // Some cities
    from city in new[] { "Seoul", "Sofia", "Mexico City", "Cape Town", "Brisbane", "Houston", "Lima" }
    // Pick a baseline temperature, smoothing window, and temperature fluctuation
    let baselineTemperature = random.Next(5, 30)
    let smoothingWindow = 5
    let fluctuation = 7
    // Calculate smoothed temperatures for a timeframe of 14 days
    let dates = Enumerable.Range(0, 14).Select(x => DateOnly.FromDateTime(DateTime.Now).AddDays(-x)).ToList()
    from date in dates
    let startIndex = dates.IndexOf(date)
    let subset = Enumerable.Range(
            start: Math.Max(0, startIndex - smoothingWindow + 1),
            count: Math.Min(smoothingWindow, dates.Count - (startIndex - smoothingWindow + 1)))
        .Select(x => baselineTemperature + random.Next(-fluctuation, fluctuation))
    let average = subset.Average()
    select new Temperature(City: city, DegreeCelsius: (int)average, Date: date)
).ToList();

Console.WriteLine();

public record Temperature(string City, int DegreeCelsius, DateOnly Date)
{
    public string Feels => DegreeCelsius switch
    {
        < 10 => "cold",
        > 20 => "warm",
        _ => "normal"
    };
}
