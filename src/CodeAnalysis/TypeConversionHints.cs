namespace CodeAnalysis;

file class TypeConversionHints
{
    public Task Test()
    {
        Apply(new Vector3D());

        // Alt-Enter on Conversion Hint | Configure Inlay Hints | Type Conversion Hints | Hide for Task(SettingsTask)
        // jetbrains://Rider/settings?name=Editor--Inlay+Hints--C%23--Type+Conversion+Hints
        return Verify("obj");
    }

    private void Apply(Vector2D vector)
    {
    }

    private SettingsTask Verify(string str)
    {
        return default;
    }
}

file class SettingsTask
{
    public static implicit operator Task(SettingsTask task)
    {
        return default;
    }
}

file class Vector2D
{
    public int X;
    public int Y;

    public static implicit operator Vector2D(Vector3D vector)
    {
        return new Vector2D { X = vector.X, Y = vector.Y };
    }
}

file class Vector3D
{
    public int X;
    public int Y;
    public int Z;
}
