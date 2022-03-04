namespace SevillaDotNet;

public partial class App : Application
{
	public App(Demo3 demo3)
	{
		InitializeComponent();

		MainPage = new NavigationPage(demo3);
	}
}
