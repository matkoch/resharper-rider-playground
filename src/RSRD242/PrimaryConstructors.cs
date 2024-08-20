namespace RSRD242;

class PrimaryConstructors
{
    // Inspection: Parameter capturing is disallowed
    class Service(IDependency dependency)
    {
        public void DoWork()
        {
            dependency.Use();
        }

        public void SetupHack()
        {
            // dependency = new AdhocDependencyImpl();
            DoWork();
        }
    }

    interface IDependency
    {
        void Use();
    }

    class AdhocDependencyImpl : IDependency
    {
        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}