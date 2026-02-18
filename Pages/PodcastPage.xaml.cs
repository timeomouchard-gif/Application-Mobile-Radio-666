using Microsoft.Maui.Controls;

namespace projet_stage.Pages;

public partial class PodcastPage : ContentPage
{
    public PodcastPage()
    {
        InitializeComponent();
    }

    private async void HomeButton_Click(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage");
    }

    private async void Image_Click1(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://radio666.com/replay-de-la-semaine/");
    }

    private async void Image_Click2(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://www.mixcloud.com/Radiosixsixsix/");
    }

    
}
