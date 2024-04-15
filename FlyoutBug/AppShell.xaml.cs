namespace FlyoutBug;

public partial class AppShell : FlyoutPage
{
    private readonly BugStartPage _runBugPage;
    private readonly NavigationPage _navigationPage;

    public AppShell()
    {
        _runBugPage = new BugStartPage(BreakFlyoutButton);
        Detail = _navigationPage = new NavigationPage(_runBugPage);
        InitializeComponent();
    }

    private async Task BreakFlyoutButton()
    {
        _navigationPage.Navigation.InsertPageBefore(new BugEndPage(), _runBugPage);
        await _navigationPage.Navigation.PopAsync();
    }
}