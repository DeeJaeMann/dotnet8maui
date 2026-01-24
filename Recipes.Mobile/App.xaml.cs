namespace Recipes.Mobile;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // MainPage = new AppShell(); // obsolete in MAUI
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}