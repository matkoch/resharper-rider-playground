using JetBrains.Annotations;
#pragma warning disable CS9113 // Parameter is unread.

namespace CSharp12.PrimaryConstructors2;

[PublicAPI]
public class DoubleCapture
{
    public static void Run()
    {
        var x = new Example1(1);
        x.A.Dump();
        x.A.Dump();
        x.B.Dump();
    }
}

file class Example1(int i)
{
    public int A => I++;
    public int B => i++;

    private int I { get; set; } = i;
}

// C# is unaware if Base captures the IService into it's state
// and has no access to it if so, so the only thing it can do
// while compiling the Derived type is to put IService into field
// again, so it's stored twice in Derived instance wasting memory
// + primary ctor parameters are mutable, they may start to differ
//
// https://sharplab.io/#v2:EYLgtghglgdgPrALgUwE4DMIGNkAICSAymgG5Q64DeAsAFC64ACALLgCID2hHYyiAFrADmACgCUAbjoBfOnUYAmXACEIAZ2Qiipcng2oyOMXRr0mAZiatOAdQ6oA1vhiqN4ug1MMG+w8gB0nNy8AsLiErgA9JG4WBAADogArqh4AIweuLK02XTRuADCAMS4UGq4STAQAO4QqaXoKup4cYkpyOUCeNoGuqUwiByliADk5WqIECh5MRAwACa4/Oq4MEPYOGqdQ1CIDbhqHAA0B0NduBwwADYAnrihMELDsXO48xwzuNWCVy088VArsJ7vw8Gw0FASMhFogbvE8GV7kN4kk9j0/P1Brh0FBkFd5p8IEJoDATodhmMDoNUjDqn1YOwIVDFrAJnMKLUJsDeGB7DdPgBqXDxVBQSCoO5YanCuoQEJocp1PBgVEQYC/E5dO6QO5s1B7LHzKDodBoeRKcGi5laYi9Ci+XRiXAgJpuB1GEyZRiWFjsDh2RzOS2Q6HuMxebzugJBHh8QSPcJRGKtZL1BSZbLSIA===
file class Example2
{
    private interface IService
    {
        void DoSomething();
    }

    // TODO: 1) extract service to property 2) replace captures
    private class Base(IService service)
    {
        // capture 1
        public void DoWorkInBase() => service.DoSomething();
    }

    private class Derived(IService service)
        : Base(service)
    {
        // capture 2
        public void DoWorkInDerived() => service.DoSomething();
    }
}

// False positive
//
// https://sharplab.io/#v2:EYLgtghglgdgPrALgUwE4DMIGNkAICSAymgG5Q64DeAsAFC64ACALLgCID2hHYyiAFrADmACgCUAbjoBfOnUYAmXACEIAZ2Qiipcng2oyOMXRr1cAenO4YHXNkQBXCABtcWCAAdHqYQEIZcrSK7GhQJMgAJlrEBrq4+obIYrggKuqaCbrGtKYMjADMTKycAOocqADW+DBsoeFR2Qy5DPE6OAB0nNy8AsLiEhZW7l4OqHgKdAyytNJAA=
file class Example3
{
    private interface IService
    {
        void DoSomething();
    }

    private class Base(IService service)
    {
        // no actual capturing!
    }

    private class Derived(IService service) : Base(service)
    {
        // single only capture
        public void DoWorkInDerived() => service.DoSomething();
    }
}
