namespace CSharp11;

file class LambdaReturnType
{
    private static void M(Builder builder)
    {
        // CA: Insert return type specification
        builder.Services.AddSingleton(_ =>
        {
            var connectionString = Environment.GetEnvironmentVariable("AzureWebJobsStorage");
            var storageAccount = StorageAccount.Parse(connectionString);
            return storageAccount.CreateCloudTableClient();
        });
    }
}

file class Builder
{
    public Services Services;
}

file class Services
{
    public void AddSingleton<T>(Func<object, T> factory)
    {
    }
}

file class StorageAccount
{
    public static StorageAccount Parse(string str)
    {
        return new StorageAccount();
    }

    public CloudTableClient CreateCloudTableClient()
    {
        return null;
    }
}

file class CloudTableClient
{
}
