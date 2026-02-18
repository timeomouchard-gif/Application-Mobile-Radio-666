using System;
using Microsoft.Maui.Controls;

namespace projet_stage.Pages;

public partial class MainPage : ContentPage
{
    private bool isPlaying = false;

    public MainPage()
    {
        InitializeComponent();
        MenuOverlay.IsVisible = true;
        MenuOverlay.Opacity = 1;
    }

    private void PlayRadio(object sender, EventArgs e)
    {
        if (!isPlaying)
        {
            RadioPlayer.Play();
            PlayButton.Text = "⏸ Pause";
            isPlaying = true;
        }
        else
        {
            RadioPlayer.Pause();
            PlayButton.Text = "▶ Écouter Radio 666";
            isPlaying = false;
        }
    }

    private void VolumeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        RadioPlayer.Volume = (float)e.NewValue;
    }

    private async void OpenWebsite(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://www.radio666.com");
    }
    private async void OpenQuelestcetitre(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://radio666.com/quel-est-ce-titre/");
    }

    private async void MenuItem_Podcast(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//PodcastPage");
    }
    private async void Artistes(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Artistes");
    }
    private async void Shop(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Shop");
    }

    private async void MenuItem_About(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//AboutPage");
    }

    private async void HomeButton_Click(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage");
    }

    private void ToggleMenu(object sender, EventArgs e)
    {
        MenuOverlay.IsVisible = !MenuOverlay.IsVisible;
        MenuOverlay.Opacity = MenuOverlay.IsVisible ? 1 : 0;
    }
}
