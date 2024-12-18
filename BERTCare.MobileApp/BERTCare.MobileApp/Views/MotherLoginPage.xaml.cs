/* [grial-metadata] id: Grial#NewsLoginPage.cs version: 1.0.1 */
using BERTCare.MobileApp.Views.MotherPortal;

namespace BERTCare.MobileApp;

public partial class MotherLoginPage : ContentPage
{
	public MotherLoginPage()
	{
		InitializeComponent();
	}

    private async void LoginButtonClicked(object sender, EventArgs e)
    {
        var motherSignUp = new NewMotherHome();
        await Navigation.PushModalAsync(motherSignUp);
    }

    private async void SignupButtonClicked(object sender, EventArgs e)
    {
        var motherSignUp = new MotherSignUpPage();
        await Navigation.PushModalAsync(motherSignUp);
    }

    private void OnEyeTapped(object sender, TappedEventArgs e)
    {
        entry.IsPassword = !entry.IsPassword;
        icon.Text = entry.IsPassword ? MaterialCommunityIconsFont.EyeOutline : MaterialCommunityIconsFont.EyeOffOutline;
    }
}
