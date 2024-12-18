namespace BERTCare.MobileApp.Views.MotherPortal;

public partial class NewChatbotPagers : ContentPage
{
	public NewChatbotPagers()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var chatbotMessage = new ChatbotPage();
        await Navigation.PushModalAsync(chatbotMessage);
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    var chatbotMessage = new ConvertsationChatBot();
    //    await Navigation.PushModalAsync(chatbotMessage);
    //}
}