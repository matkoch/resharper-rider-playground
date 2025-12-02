using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;

namespace SourceGenerator;

[Generator]
[SuppressMessage("MicrosoftCodeAnalysisCompatibility", "RS1042:Implementations of this interface are not allowed")]
public class SmartCompletionProvider : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
        var yamlFiles = context.AdditionalFiles
            .Where(x => x.Path.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase));
        context.AddSource("YamlFiles.cs", $$"""
            public static class YamlFiles
            {
            {{string.Join("\n", yamlFiles.Select(x =>
                $"""public static string {Path.GetFileNameWithoutExtension(x.Path)} = "{x.Path}";"""))}}
            }
            """);
    }
}
