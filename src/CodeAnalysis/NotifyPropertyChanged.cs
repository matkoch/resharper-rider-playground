using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CodeAnalysis;

public static class NotifyPropertyChanged
{
    private class Person : ObservableBase
    {
        // CA: To property with SetField change notification
        // ... try in a LangVersion 'preview' project for latest C# 11 syntax
        public string Name { get; set; }
    }

    private abstract class ObservableBase : INotifyPropertyChanged
    {
        #region Generated from INotifyPropertyChanged inheritance

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

        #endregion
    }
}
