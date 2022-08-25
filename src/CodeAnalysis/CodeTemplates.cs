using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace CodeAnalysis;

public static class CodeTemplates
{
    public static void Start()
    {
        // QF: convert to new API (in file, project, solution)
        // Challenge: make this an error instead of a warning
        Assert.That(1 < 5, Is.True);
        Assert.That(string.IsNullOrWhiteSpace(""), Is.True);
        Assert.That(DateTime.Today.Year < 2022, Is.True);
        Assert.That(true, Is.True);

        // Challenge: add another code template that converts Assert.That(..., Is.False)
        Assert.That(true, Is.False);
        Assert.That(false, Is.False);
        Assert.That(!true, Is.False);
        Assert.That(!false, Is.False);
    }

    public class Assert
    {
        [CodeTemplate(
            searchTemplate: "Assert.That($arg$, Is.True)",
            Message = $"WARNING: This API is deprecated, use '{nameof(Assert)}.{nameof(That)}' instead",
            ReplaceTemplate = "Assert.IsTrue($arg$)",
            ReplaceMessage = $"Convert to '{nameof(Assert)}.{nameof(IsTrue)}'",
            SuppressionKey = "assert-that-true")]
        public static void That(
            bool condition,
            bool expected,
            [CallerArgumentExpression("condition")]
            string? expression = null)
        {
            if (condition != expected)
                throw new ArgumentException($"Condition '{expression}' is expected to be {expected}.");
        }

        public static void IsTrue(
            bool condition,
            [CallerArgumentExpression("condition")]
            string? expression = null)
        {
            if (!condition)
                throw new ArgumentException($"Condition '{expression}' is expected to be true.");
        }

        public static void IsFalse(
            bool condition,
            [CallerArgumentExpression("condition")]
            string? expression = null)
        {
            if (condition)
                throw new ArgumentException($"Condition '{expression}' is expected to be false.");
        }
    }

    public class Is
    {
        public static bool True = true;
        public static bool False = false;
    }
}
