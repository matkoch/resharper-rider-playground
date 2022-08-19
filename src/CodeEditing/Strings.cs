namespace CodeEditing;

public class Strings
{
    public void M(int number)
    {
        // Challenge: paste following path into the string and wait for the auto-escape fix
        // C:\Windows\paths\need\escaping
        Console.WriteLine("");

        // Challenge: copy the JSON into a regular + verbatim string
        // Bonus: select the JSON using 'Expand selection'
        /*
{
    "firstName": "SpongeBob",
    "lastName": "SquarePants"
    "age": 20
}
         */
        var json1 = "";
        var json2 = @"
"; // <- Paste before this quote

        // Challenge: move to the right guideline and split the string using enter
        var lorem = "Lorem ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";

        // Challenge: replace <number> with the number passed to this method using
        //    1. CA: To string interpolation
        //    2. Code completion after typing {
        var str = "The number <number> was passed to this method";
    }
}
