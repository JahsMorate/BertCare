/* [grial-metadata] id: Grial#NewsWelcomePage.cs version: 1.0.1 */
namespace BERTCare.MobileApp;

public partial class MotherWelcomePage : ContentPage
{
	public MotherWelcomePage()
	{
		InitializeComponent();
	}

    private async void SignUpButtonClicked(object sender, EventArgs e)
    {
        var page = new MotherLoginPage();
        await Navigation.PushModalAsync(page);

    }

    private async void LoginButtonClicked(object sender, EventArgs e)
    {
        var page = new MotherLoginPage();
        await Navigation.PushModalAsync(page);
    }
}
