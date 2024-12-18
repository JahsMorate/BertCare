/* [grial-metadata] id: Grial#NewsWelcomePage.cs version: 1.0.1 */
namespace BERTCare.MobileApp;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    private void SignUpButtonClicked(object sender, EventArgs e)
    {

    }

    private void LoginButtonClicked(object sender, EventArgs e)
    {

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
    private async void MotherWelcomePage(object sender, TappedEventArgs e)
    {
        var motherWelcomePage = new MotherWelcomePage();
        await Navigation.PushModalAsync(motherWelcomePage);
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        var motherWelcomePage = new MotherWelcomePage();
        await Navigation.PushModalAsync(motherWelcomePage);
    }
}
