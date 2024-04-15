namespace FlyoutBug;

public partial class BugStartPage : ContentPage
{
    private readonly Func<Task> _function;

    public BugStartPage(Func<Task> function)
    {
        _function = function;
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e) => await _function();
}