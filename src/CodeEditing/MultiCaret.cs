namespace CodeEditing;

public class MultiCaret
{
    public void M()
    {
        // Challenge: select all 'smurf' using 'Select All/Next Occurrence'
        // Challenge: remove the smurf naming and fix the variable names using 'Toggle casing'
        var smurfName = "Papa Smurf";
        var smurfAge = 125;
        Console.WriteLine($"{smurfName} was here and he is {smurfAge} years old!");
    }
}
