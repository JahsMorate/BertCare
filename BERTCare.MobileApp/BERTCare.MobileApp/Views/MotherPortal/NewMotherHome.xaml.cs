namespace BERTCare.MobileApp.Views.MotherPortal;

public partial class NewMotherHome : ContentPage
{
	public NewMotherHome()
	{
		InitializeComponent();
	}

    private async void RedirectChatBotPage(object sender, TappedEventArgs e)
    {
		var chatbotPage =  new ChatbotPage();
		await Navigation.PushModalAsync(chatbotPage);
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var page = new ChildrenTips();
        await Navigation.PushModalAsync(page);
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        var page = new NewRimenders();
        await Navigation.PushModalAsync(page);
    }
}