using Microsoft.Maui.Controls;

namespace projet_stage.Pages
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void OpenWebsite(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://radio666.com/");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        private async void Cnm(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://cnm.fr/");
        }

        private async void Ferarock(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://ferarock.org/les-radios/6-6-6");
        }
    }
}
