namespace SevillaDotNet;

public class AlertDialogService : IAlertDialogService
{
    public void ShowDialog(string title, string message)
    {
        Application.Current.MainPage.DisplayAlert(title, message, "OK");
    }
}
