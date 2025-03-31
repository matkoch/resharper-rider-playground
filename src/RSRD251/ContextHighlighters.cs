// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

file class ContextHighlighters
{
    class Implementation : IInterface, IDisposable
    {
        public void Dispose()
        {
        }

        public void Execute()
        {
        }

        public void Revert()
        {
        }

        public void Clean()
        {
        }
    }

    interface IInterface
    {
        void Execute();
        void Revert();
    }
}
