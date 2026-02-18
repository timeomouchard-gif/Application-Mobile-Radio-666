using Microsoft.Maui.Controls;
namespace projet_stage.Pages;

public partial class Artistes : ContentPage
{
	public Artistes()
	{
		InitializeComponent();
	}
    private async void Image_Click3(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://radio666.com/scene-locale/");
    }
    private async void Image_Click4(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://soundcloud.com/lamusicaleradio");
    }
}