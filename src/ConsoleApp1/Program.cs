// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

SpinWait.SpinUntil(() => Debugger.IsAttached);

Console.WriteLine("Hello, World!");
