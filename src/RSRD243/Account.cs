using System.ComponentModel.DataAnnotations;

// ReSharper disable All
// @formatter:place_accessorholder_attribute_on_same_line true
// @formatter:blank_lines_around_auto_property 0

namespace RSRD243;

partial class Account
{
    [MinLength(2)] public partial string Name { get; }

    // [GeneratedRegex("foo|bar")] public partial Regex FooBarRegex { get; }
}

public partial class Account
{
    public partial string Name => "Sasha";
}
