namespace CSharp11;

file class AutoDefaultStructs
{
    private struct Credentials
    {
        public string? Username;
        public string? Password;

        public Credentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Credentials(string token)
        {
            // No init of Username, previously an error
            Password = token;
        }
    }
}
