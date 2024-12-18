namespace BERTCare.MobileApp.Views.MotherPortal;

public partial class ChatbotPage : ContentPage
{
	public ChatbotPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		var chatbotMessage = new NewChatbotPagers();
		await Navigation.PushModalAsync(chatbotMessage);
    }
}