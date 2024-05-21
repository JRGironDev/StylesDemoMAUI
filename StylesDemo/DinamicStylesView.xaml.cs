namespace StylesDemo;

public partial class DinamicStylesView : ContentPage
{
	public DinamicStylesView()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Application.Current
			.Resources.TryGetValue("specialButton", out object? retVal);

		Resources["dynamicStyle"] = (Style)retVal;
	}
}