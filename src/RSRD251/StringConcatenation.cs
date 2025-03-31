namespace RSRD251;

file class StringConcatenation
{
    public void M(string id)
    {
        var str1 = $"Id = {id}";
        var str2 = string.Format("Id = {0}", id);
        var str3 = "Id = " + id;
    }
}
