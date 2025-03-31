// ReSharper disable ArrangeTypeMemberModifiers

using System.Diagnostics;

namespace RSRD251;

file class DebugAssertModifications
{
    private readonly HashSet<Node> _visitedNodes = [];

    void ProcessDescendants(Node node)
    {
        try
        {
            Debug.Assert(_visitedNodes.Add(node), message: "Graph cycle detected");
            foreach (var child in node.Children)
                ProcessDescendants(child);
        }
        finally
        {
            _visitedNodes.Remove(node);
        }
    }

    record Node(List<Node> Children);
}
