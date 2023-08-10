using System.Collections.Immutable;

namespace Navigation;

public class VarNavigation
{
    public void M()
    {
        // Navigation: Ctrl-Click on var
        // Navigation: Find Usages on var
        var people = new[] { new bool?() }.ToImmutableArray();
    }
}
