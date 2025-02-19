using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace IsVisibleBug;

public class VisibilityToggleViewModel : INotifyPropertyChanged
{
    private bool _isVisible;

    public VisibilityToggleViewModel()
    {
        ToggleVisibleCommand = new Command(ToggleVisibility);
    }

    private void ToggleVisibility()
    {
        IsVisible = !IsVisible;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public bool IsVisible
    {
        get => _isVisible;
        set => SetField(ref _isVisible, value);
    }

    public ICommand ToggleVisibleCommand { get; }
    public List<string> StringList { get; } = ["cat", "horse", "dog", "mouse"];

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