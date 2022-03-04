namespace SevillaDotNet;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        btBack.IsVisible = Navigation.NavigationStack.Count > 1;
    }

    private void btBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}