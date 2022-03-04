namespace SevillaDotNet;

public partial class Demo3 
{
	public Demo3(Demo3ViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}