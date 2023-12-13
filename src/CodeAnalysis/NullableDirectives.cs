// QF: Remove redundant nullable directive

#nullable enable

namespace CodeAnalysis;

public class NullableDirectives
{
#nullable disable
    public string FirstName { get; set; }

    // QF: Remove redundant nullable directive
#nullable disable
    public string MiddleName { get; set; }

#nullable enable
    public string? LastName { get; set; }

    public virtual string GetNotNullValue() => "This is a string";
}

public class NullableDirectivesInheritor : NullableDirectives
{
    // Inspection: Annotation conflict in hierarchy
    [CanBeNull]
    public override string GetNotNullValue() => null!;
}

// QF: Remove unused nullable directive
#nullable disable