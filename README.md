# ReSharper & Rider Playground

<!-- TOC -->
* [Code Analysis](#code-analysis)
  * [General](#general)
  * [C# 11](#c#-11)
  * [C# 10](#c#-10)
<!-- TOC -->

# Code Analysis

## General

- [INotifyPropertyChanged](src/CodeAnalysis/NotifyPropertyChanged.cs)
- [SSR Code Templates](src/CodeAnalysis/CodeTemplates.cs)
- [Cognitive Complexity](src/CodeAnalysis/CognitiveComplexity.cs)
- [Nullable Directives](src/CodeAnalysis/NullableDirectives.cs)
- [Collection Lookups](src/CodeAnalysis/Lookups.cs)
- [Empty regions](src/CodeAnalysis/EmptyRegions.cs)
- [Spell-Check for special values](src/CodeAnalysis/SpellChecking.json)

## [C# 11](src/CSharp11/CSharp11.csproj)

- [List Patterns](src/CSharp11/ListPatterns.cs)
- [`nameof` Operator](src/CSharp11/NameofOperator.cs)
- [Raw Strings](src/CSharp11/RawStrings.cs)
- [`required` Keyword](src/CSharp11/RequiredKeyword.cs)
- [Generic Attributes](src/CSharp11/GenericAttributes.cs)
- [Span Pattern Matching](src/CSharp11/SpanPatternMatching.cs)
- [`checked` Operators](src/CSharp11/CheckedOperators.cs)
- [Auto-Default `struct`](src/CSharp11/AutoDefaultStructs.cs)

## [C# 10](src/CSharp10/CSharp10.csproj)

- [Top-Level Statements](src/CSharp10/TopLevelStatements.cs)
- [Global Usings in Project Files](src/CSharp10/CSharp10.csproj)
- [Global Usings in CSharp Files](src/CSharp10/GlobalUsings.cs)
- [Interpolated String Handlers](src/CSharp10/InterpolatedStringHandler.cs)
- [Constant String Interpolation](src/CSharp10/ConstantInterpolation.cs)

# Code Editing

- [Strings](src/CodeEditing/Strings.cs)
- [Postfix Templates](src/CodeEditing/PostfixTemplates.cs)
- [Complete Statement](src/CodeEditing/CompleteStatement.cs)
- [Expand/Shrink Selection](src/CodeEditing/ExpandShrinkSelection.cs)
- [Multi-Caret](src/CodeEditing/MultiCaret.cs)
- [Null-Check Styles](src/CodeEditing/NullChecking.cs)
- [Type Conversion Hints](src/CodeAnalysis/TypeConversionHints.cs)
- [UnitTest Parameter Name Hints](src/UnitTesting/ParameterHints.cs)
- [Reformat Preprocessor Directives](src/CodeEditing/PreprocessorDirectives.cs)
- [Markdown Typing Assist](markdown.md)

# Debugging

- [String Visualizers](src/UnitTesting/StringVisualizers.cs)

# Entity Framework

- [Load required relations](src/EntityFrameworkEditing/EfCoreLoadRequiredRelations.cs)
- [N+1](src/EntityFrameworkEditing/EfCoreNPlusOne.cs)

[//]: # (Smurfette was here)
