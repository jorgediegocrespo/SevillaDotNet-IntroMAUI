namespace SevillaDotNet;

public partial class Demo1 
{
	public Demo1()
	{
		InitializeComponent();
	}

	private void btAdd_Clicked(object sender, EventArgs e)
    {
		if (!int.TryParse(enFirstOperator.Text, out int firstOp))
			firstOp = 0;
		if (!int.TryParse(enSecondOperator.Text, out int secondOp))
			secondOp = 0;

		lbResult.Text = (firstOp + secondOp).ToString("N0");
    }

    private void btMultiplication_Clicked(object sender, EventArgs e)
    {
		if (!int.TryParse(enFirstOperator.Text, out int firstOp))
			firstOp = 0;
		if (!int.TryParse(enSecondOperator.Text, out int secondOp))
			secondOp = 0;

		lbResult.Text = (firstOp * secondOp).ToString("N0");
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Mi first app", "Hello Sevilla dotnet", "Ok");
    }
}

