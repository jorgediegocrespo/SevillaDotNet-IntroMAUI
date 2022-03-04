namespace SevillaDotNet;

public partial class Page3
{
	public Page3()
	{
		InitializeComponent();
	}

    private void btPage1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page1());
    }

    private void btPage2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Page2());
    }

    private void btPage3_Clicked(object sender, EventArgs e)
    {
        Application.Current.OpenWindow(new Window(new Page2()));
    }
}