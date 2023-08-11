namespace CodeGeneration;

public class DisposableResources
{
    // Generate Code > Dispose Pattern > IDisposable + IAsyncDisposable
    class DisposablePattern
    {
        private readonly FileStream _stream;

        public DisposablePattern(string file)
        {
            _stream = File.OpenRead(file);
        }
    }

    Task<string> Read(string file)
    {
        // QF: make async and await
        using var reader = File.OpenText(file);
        return reader.ReadToEndAsync();
    }
}
