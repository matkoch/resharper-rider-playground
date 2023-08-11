using JetBrains.Annotations;

namespace CodeAnalysis;

// CA: remove redundant directive
public class NullableReferenceTypes
{
#nullable disable
    class Base
    {
        public virtual int GetLength([CanBeNull] string s) => s?.Length ?? -1;
    }
#nullable disable
#nullable restore

#nullable enable
    class Derived : Base
    {
        // QF: NRT annotation contradicts JetBrains.Annotations
        public override int GetLength(string s) => s.Length;
    }
#nullable restore
}
