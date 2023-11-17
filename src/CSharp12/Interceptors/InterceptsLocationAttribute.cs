using JetBrains.Annotations;

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;

[PublicAPI]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
sealed class InterceptsLocationAttribute(string filePath, int line, int column) : Attribute;
