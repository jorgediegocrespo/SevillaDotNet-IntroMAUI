namespace SevillaDotNet;

public class NavigationService : INavigationService
{
    public Task NavigateToPage1()
    {
        return Application.Current.MainPage.Navigation.PushAsync(new Page1());
    }
}
