using System.ComponentModel;
using System.Runtime.CompilerServices;

#pragma warning disable CS9264 // Non-nullable property must contain a non-null value when exiting constructor. Consider adding the 'required' modifier, or declaring the property as nullable, or adding '[field: MaybeNull, AllowNull]' attributes.
#pragma warning disable CA1822

// ReSharper disable UnusedType.Global
// ReSharper disable ArrangeTypeModifiers
// @formatter:place_simple_accessorholder_on_single_line false

namespace RSRD243;

class FieldKeyword : INotifyPropertyChanged
{
    private int _age;

    // Replace with field keyword
    private string _name;

    public string Name
    {
        set => _name = value.Trim();
        get => _name;
    }

    public int Age
    {
        get => ~_age;
        set => _age = value;
    }

    // INotifyPropertyChanged + SetField
    public string Address { get; set; }

    // Null-checks
    public string Position { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}
