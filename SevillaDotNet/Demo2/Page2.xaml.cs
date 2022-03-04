namespace SevillaDotNet;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        btCloseModal.IsVisible = Navigation.ModalStack.Count > 0;
        btCloseWindows.IsVisible = GetParentWindow() != null;
    }

    private void btCloseModal_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void btCloseWindow_Clicked(object sender, EventArgs e)
    {
        Application.Current.CloseWindow(GetParentWindow());
    }
}