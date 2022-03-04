namespace SevillaDotNet;

public partial class Flyout
{
	public Flyout()
	{
		InitializeComponent();
	}

    private void btPage1_Clicked(object sender, EventArgs e)
    {
        Detail = new Page1();
        IsPresented = false;
    }

    private void btPage2_Clicked(object sender, EventArgs e)
    {
        Detail = new Page2();
        IsPresented = false;
    }

    private void btPage3_Clicked(object sender, EventArgs e)
    {
        Detail = new Tabbed();
        IsPresented = false;
    }

    private void btPage4_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Page3());
        IsPresented = false;
    }
}