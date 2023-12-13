namespace CSharp12;

file class TreeChecker : ITreeProcessor<List<(string Name, object? Value)>>
{
    public bool ShouldProcessDescendants(INode element, List<(string Name, object? Value)> context)
    {
        throw new NotImplementedException();
    }

    public bool IsProcessingFinished(List<(string Name, object? Value)> context)
    {
        throw new NotImplementedException();
    }

    public void ProcessBeforeDescendants(INode element, List<(string Name, object? Value)> context)
    {
        throw new NotImplementedException();
    }

    // public void ProcessAfterDescendants(INode element, List<(string Name, object? Value)> context)
    // {
    //     throw new NotImplementedException();
    // }
}

file interface ITreeProcessor<in TContext>
{
    bool ShouldProcessDescendants(INode element, TContext context);
    bool IsProcessingFinished(TContext context);

    void ProcessBeforeDescendants(INode element, TContext context);
    // void ProcessAfterDescendants(INode element, TContext context);
}

file interface INode
{
}
