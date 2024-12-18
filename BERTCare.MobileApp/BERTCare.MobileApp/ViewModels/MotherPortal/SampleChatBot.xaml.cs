/* [grial-metadata] id: Grial#NewsMembershipPage.cs version: 1.0.1 */
using Microsoft.Maui.Graphics.Text;

namespace BERTCare.MobileApp;

public partial class SampleChatBot : ContentPage
{
	public SampleChatBot()
	{
		InitializeComponent();

        BindingContext = new SampleChatBotViewModel();
	}

    private async void ActivateButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Demo App", "Thanks for buying! :)", "Ok");
        await Navigation.PopModalAsync();
    }

    private async void OnClose(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
