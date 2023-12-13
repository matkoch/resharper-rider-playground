namespace CodeGeneration;

file class DisposableResources
{
    Task<string> Read(string file)
    {
        // TODO: QF: make async and await
        using var reader = File.OpenText(file);
        return reader.ReadToEndAsync();
    }

    class DisposablePattern(string file)
    {
        private readonly FileStream _stream = File.OpenRead(file);

        // TODO: Generate Code > Dispose Pattern > IDisposable + IAsyncDisposable
    }
}