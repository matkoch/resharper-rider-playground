namespace RSRD242;

class CastExpressionAnalysis
{
    void M()
    {
        var derivedInstance = new Derived();

        // upcast: completely safe, no-op in MSIL and at a runtime
        var baseReference = (IBase)derivedInstance;

        // downcast: runtime cast, can throw InvalidCastException
        var derivedReference = (IDerived)baseReference;

        IEnumerable<IDerived> derivedItems = [derivedReference,];

        var baseItems = derivedItems.Select(x => (IBase)x).ToList();
    }

    Task<IBase> Async(IDerived derivedInstance)
    {
        return Task.FromResult((IBase)derivedInstance);
    }

    interface IBase;

    interface IDerived : IBase;

    class Derived : IDerived;
}
