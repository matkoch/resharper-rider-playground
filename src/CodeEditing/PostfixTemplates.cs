using System.Text;

namespace CodeEditing;

public class PostfixTemplates
{
    // Challenge: use postfix templates to return only even numbers
    //   numbers.foreach
    //   number % 2 == 0.if
    //   number.yield
    public IEnumerable<int> FilterEvenNumbers(int[] numbers)
    {
        return null;
    }

    // Challenge: create and return a new StringBuilder with .new and .return
    // Challenge: create and return a new StringBuilder with .var and .return (without .new)
    public StringBuilder CreateStringBuilder()
    {
        return null;
    }

    public void VoidCompletion()
    {
        StringBuilder builder = default;
        builder
            .AppendLine("")
            .AppendLine("");

        StreamWriter writer = default;
    }
}
