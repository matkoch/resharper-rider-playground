// #!/usr/local/share/dotnet/dotnet run
// #:package Humanizer@2.14.1

// Memory allocation loop with logging
var r = new Random();
List<object[]> arrays = new List<object[]>();

for (var i = 0; i < short.MaxValue; i++)
{
    var a = new object[int.MaxValue / 4];
    a[0] = i;
    arrays.Add(new object[int.MaxValue / 4]);

    Console.Write(".");
    Console.ReadKey();

    if (i >= r.Next(5, 9))
    {
        Console.WriteLine("GC surprise!");
        arrays.Clear();
        GC.Collect();
        i = 0;
    }
}
