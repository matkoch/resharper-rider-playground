// ReSharper disable UnusedParameter.Local
// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

file class ParameterListFormatting
{
    ParameterListFormatting(Lifetime lifetime, ILogger logger, ISolution solution, ChangeManager changeManager,
        [NotNull] IShellLocks shellLocks, [NotNull] IPsiCachesState psiCachesState, IWordIndex wordIndex,
        IPsiFiles psiFiles, SymbolCache symbolCache, AsyncCommitService asyncCommitService,
        DocumentTransactionManager documentTransactionManager, [NotNull] IPsiTransactions psiTransactions)
    {
        // Do some work
    }

    struct Lifetime;

    interface ILogger;

    interface ISolution;

    class ChangeManager;

    interface IShellLocks;

    interface IPsiCachesState;

    interface IWordIndex;

    interface IPsiFiles;

    class SymbolCache;

    class AsyncCommitService;

    class DocumentTransactionManager;

    interface IPsiTransactions;
}
