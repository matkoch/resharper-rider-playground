namespace CSharp11;

public class FormatStringCompletion
{
    public void Start()
    {
        var str1 = DateOnly.MinValue.ToString("M");
        var str2 = TimeOnly.MaxValue.ToString("t");
        
        var str3 = Int128.MaxValue.ToString("e2");
        var str4 = Half.Tau.ToString("0000");
    }
}
