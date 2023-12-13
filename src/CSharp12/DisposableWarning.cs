// ReSharper disable UnusedType.Local

// ReSharper disable UnusedMember.Local

namespace CSharp12;

file class DisposableWarning
{
    public void M()
    {
        var resource = CreateAndConfig();
        resource.DoWork();

        var resource2 = CreateAndConfig();
        Handle(resource2);
    }

    // TODO: add MustDisposeResource
    [MustDisposeResource]
    private HasNativeResources CreateAndConfig()
    {
        var resource = new HasNativeResources();
        resource.Confiure();
        return resource;
    }

    // TODO: HandlesResourceDisposal
    private void Handle(HasNativeResources resources)
    {
        resources.DoWork();
        resources.Dispose();
    }
}

[MustDisposeResource] // for ctor
file class HasNativeResources : IDisposable
{
    public void Dispose()
    {
    }

    [MustDisposeResource]
    public static HasNativeResources Create()
    {
        return null;
    }

    public void DoWork()
    {
    }

    public void Confiure()
    {
    }
}
