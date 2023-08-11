namespace CSharp12;

// Settings: Primary Constructor
// CA: to explicit ctor
class PrimaryConstructors
{
    private readonly IFirstDependency _firstDependency;
    private readonly ISecondDependency _secondDependency;

    // CA: to primary ctor
    public PrimaryConstructors(
        IFirstDependency firstDependency,
        ISecondDependency secondDependency)
    {
        _firstDependency = firstDependency;
        _secondDependency = secondDependency;
    }


    public void M()
    {
        _firstDependency.M();
    }
}

interface IFirstDependency
{
    void M();
}

interface ISecondDependency
{
}
