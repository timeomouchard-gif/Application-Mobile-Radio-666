using Microsoft.Maui.Controls;
using System;

namespace projet_stage.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var shadow = new Shadow
            {
                Brush = Brush.Black,
                Opacity = 0.4f,
                Radius = 8,
                Offset = new Point(0, 4)
            };

            facebookButton.Shadow = shadow;
            instagramButton.Shadow = shadow;
        }

        private async void OpenFacebook(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.facebook.com/666radiocaen/?locale=fr_FR");
        }

        private async void OpenInstagram(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.instagram.com/radio_666_/");
        }
    }
}
