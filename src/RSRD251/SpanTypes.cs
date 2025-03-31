// ReSharper disable ArrangeTrailingCommaInSinglelineLists
// ReSharper disable SeparateLocalFunctionsWithJumpStatement

namespace RSRD251;

file static class SpanTypes
{
    public static void M()
    {
        var stringArray = new[] { "one", "two", "three" };
        Span<string> stringSpan = stringArray;
        ReadOnlySpan<string> stringRoSpan = stringSpan;

        // error in C# 13, ok in C# 14
        var array = ToReadOnlySpanGeneric(stringArray);
        ReadOnlySpan<object> objectRoSpan1 = stringSpan;
        ReadOnlySpan<object> objectRoSpan2 = stringRoSpan;

        // error: conversion not allowed
        // Span<object> objectSpan = stringRoSpan;

        ReadOnlySpan<T> ToReadOnlySpanGeneric<T>(ReadOnlySpan<T> span) => default;
    }

    public static T MostFrequent<T>(this ReadOnlySpan<T> span) where T : IEquatable<T> => default;
}
