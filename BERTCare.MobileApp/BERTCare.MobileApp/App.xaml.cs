/* [grial-metadata] id: Grial#App.xaml version: 1.1.3 */
using UXDivers.Grial;
namespace BERTCare.MobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MotherWelcomePage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new WelcomePage());
        }
    }
}