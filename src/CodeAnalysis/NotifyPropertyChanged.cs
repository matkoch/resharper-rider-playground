using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CodeAnalysis;

public static class NotifyPropertyChanged
{
    private class Person : ObservableBase
    {
        private string _name;

        // CA: To property with SetField change notification
        // ... try in a LangVersion 'preview' project for latest C# 11 syntax
        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }
    }

    private abstract class ObservableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
