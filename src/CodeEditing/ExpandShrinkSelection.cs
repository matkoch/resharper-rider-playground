using System.Text;

namespace CodeEditing;

public class ExpandShrinkSelection
{
    public void PrintEvenAbsoluteOrderedNumbers(IEnumerable<int> numbers)
    {
        var builder = new StringBuilder();

        // Challenge: introduce variables for 'evenNumbers', 'absoluteNumbers', and 'orderedNumbers' using Expand/Shrink Selection
        // Challenge: extract the foreach to a new method
        foreach (var number in numbers.Where(x => x % 2 == 0).Select(Math.Abs).OrderBy(x => x))
            builder.AppendLine($"Number: {number}");
    }
}
