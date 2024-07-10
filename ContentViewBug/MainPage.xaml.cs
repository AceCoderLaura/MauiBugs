namespace ContentViewBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void SetControlTemplate(object? sender, EventArgs e)
    {
        MyContentView.ControlTemplate = MyTemplate;
    }
}