/* [grial-metadata] id: Grial#NewsSourcesPage.cs version: 1.0.1 */
namespace BERTCare.MobileApp;

public partial class StartingPage : ContentPage
{
	public StartingPage()
	{
		InitializeComponent();

        BindingContext = new StartingViewModel(Navigation);
    }
}
