namespace RSRD242;

class ListPatterns
{
    void M(string[] args, string command)
    {
        if (args is ["--help", .. var topics])
        {
            foreach (var topic in topics)
            {
                // ..
            }
        }
    }
}
