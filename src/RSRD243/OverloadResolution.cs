

// ReSharper disable All

class OverloadResolution
{
    //[OverloadResolutionPriority(10)]
    public void M(object obj) => M(1);

    //[OverloadResolutionPriority(20)]
    public void M(Base obj) => M(obj);
    public void M(Derived obj) => M(obj);
}

class Base;

class Derived : Base;
