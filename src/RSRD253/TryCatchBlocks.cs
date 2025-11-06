using System;
using System.Diagnostics;
// ReSharper disable UnusedMember.Local
#pragma warning disable CA1822
#pragma warning disable CS0168 // Variable is declared but never used

namespace RSRD253;

file class TryCatchBlocks
{


public void M()
{
    ThrowingMethod();
}

/// <exception cref="DriveNotFoundException">Time for a walk.</exception>
/// <exception cref="UnreachableException">You worked hard for this.</exception>
/// <exception cref="Exception">Deal with anything.</exception>
void ThrowingMethod() { }









}
