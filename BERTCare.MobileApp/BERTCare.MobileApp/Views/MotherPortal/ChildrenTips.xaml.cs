namespace BERTCare.MobileApp.Views.MotherPortal;

public partial class ChildrenTips : ContentPage
{
	public ChildrenTips()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		var page = new GeneratePreviewChildren();
		await Navigation.PushModalAsync(page);
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var page = new NewMotherHome();
        await Navigation.PushModalAsync(page);
    }
}