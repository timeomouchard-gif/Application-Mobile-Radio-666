using Microsoft.Maui.Controls;

namespace projet_stage.Pages
{
    public partial class Shop : ContentPage
    {
        public Shop()
        {
            InitializeComponent();
        }

        private async void OpenVetements(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://boutique.radio666.com/13-tshirts");
        }

        private async void OpenGoodies(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://boutique.radio666.com/14-sweat-a-capuche");
        }

        private async void OpenObjetsPublicitaires(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://boutique.radio666.com/12-objets-publicitaires");
        }

        private async void OpenSite(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://radio666.com");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
