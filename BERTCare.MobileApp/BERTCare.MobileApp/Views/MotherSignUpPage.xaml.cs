/* [grial-metadata] id: Grial#NewsSignUpPage.cs version: 1.0.1 */
namespace BERTCare.MobileApp;

public partial class MotherSignUpPage : ContentPage
{
	public MotherSignUpPage()
	{
		InitializeComponent();
	}

    private void CreateButtonClicked(object sender, EventArgs e)
    {

    }

    private async void LoginButtonClicked(object sender, EventArgs e)
    {
        var motherLogin = new  MotherLoginPage();
        await Navigation.PushModalAsync(motherLogin);
    }

    private void OnEyeTapped(object sender, TappedEventArgs e)
    {
        entry.IsPassword = !entry.IsPassword;
        icon.Text = entry.IsPassword ? MaterialCommunityIconsFont.EyeOutline : MaterialCommunityIconsFont.EyeOffOutline;
    }
}
