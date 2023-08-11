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
- [Local Functions](src/CodeAnalysis/LocalFunctions.cs)
- [Pragma Warnings](src/CodeAnalysis/Pragma.cs)

## [C# 12](src/CSharp12/CSharp12.csproj)

- [Primary Constructors](src/CSharp12/PrimaryConstructors.cs)
- [Lambda Default Values](src/CSharp12/LambdaDefaultValues.cs)

## [C# 11](src/CSharp11/CSharp11.csproj)

- [List Patterns](src/CSharp11/ListPatterns.cs)
- [`nameof` Operator](src/CSharp11/NameofOperator.cs)
- [Raw Strings](src/CSharp11/RawStrings.cs)
- [`required` Keyword](src/CSharp11/RequiredKeyword.cs)
- [Generic Attributes](src/CSharp11/GenericAttributes.cs)
- [Span Pattern Matching](src/CSharp11/SpanPatternMatching.cs)
- [`checked` Operators](src/CSharp11/CheckedOperators.cs)
- [Auto-Default `struct`](src/CSharp11/AutoDefaultStructs.cs)
- [Lambda Return Types](src/CSharp11/LambdaReturnType.cs)
- [UTF-8 Literals](src/CSharp11/Utf8Strings.cs)
- [Static/Abstract Interfaces](src/CSharp11/StaticAbstractInInterfaces.cs)
- [Pattern Matching](src/CSharp11/PatternMatching.cs)

## [C# 10](src/CSharp10/CSharp10.csproj)

- [Top-Level Statements](src/CSharp10/TopLevelStatements.cs)
- [Global Usings in Project Files](src/CSharp10/CSharp10.csproj)
- [Global Usings in CSharp Files](src/CSharp10/GlobalUsings.cs)
- [Interpolated String Handlers](src/CSharp10/InterpolatedStringHandler.cs)
- [Constant String Interpolation](src/CSharp10/ConstantInterpolation.cs)

# Navigation

- [Advanced Find Usages](src/Navigation/AdvancedFindUsages.cs)
- [`var` Declarations](src/Navigation/VarNavigation.cs)

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
- [Inlay Hints](src/CodeEditing/InlayHints.cs)

# Code Generation

- [Disposable Resources](src/CodeGeneration/DisposableResources.cs)

# Debugging

- [Smart Step Into](src/UnitTesting/NestedExpressionsTest.cs)
- [String Visualizers](src/UnitTesting/StringVisualizers.cs)

# Unit Testing

- [Test Case Inlay Hints](src/UnitTesting/ParameterHints.cs)
- [Run Until Failure](src/UnitTesting/RandomThrowingTest.cs)

# Entity Framework

- [Load required relations](src/EntityFrameworkEditing/EfCoreLoadRequiredRelations.cs)
- [N+1](src/EntityFrameworkEditing/EfCoreNPlusOne.cs)

[//]: # (Smurfette was here)
