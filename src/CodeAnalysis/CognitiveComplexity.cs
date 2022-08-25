using System.Numerics;

namespace CodeAnalysis;

public class CognitiveComplexity
{
    public void M<T>(Span<T> numbers,
        T? lowerBound = default,
        T? upperBound = default)
        where T : INumber<T>
    {
        if (numbers is { Length: 0 }) return;

        if (lowerBound is null) lowerBound = T.Zero;
        if (upperBound is null) upperBound = T.One;

        foreach (var number in numbers)
            if (number > lowerBound)
                if (number < upperBound)
                    M(numbers[1..]);
    }
}
