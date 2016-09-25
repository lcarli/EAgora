using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EAgoraNewNavPane.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Ativacao : Page
    {
        public Ativacao()
        {
            this.InitializeComponent();
        }

        private void btDepois_Click(object sender, RoutedEventArgs e)
        {
            App.SaveData("ativação", "OK");
            this.Frame.Navigate(typeof(Principal));
        }

        private async void Sway_Tapped(object sender, TappedRoutedEventArgs e)
        {
            btDepois.Content = "Continuar";
            //Link SWAY -> https://www.microsoft.com/pt-br/store/p/sway/9wzdncrd2g0j
            var uriString = "ms-windows-store://pdp/?ProductId=9wzdncrd2g0j";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void OneNote_Tapped(object sender, TappedRoutedEventArgs e)
        {
            btDepois.Content = "Continuar";
            var uriString = "ms-windows-store://pdp/?ProductId=9wzdncrfhvjl";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void Excel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            btDepois.Content = "Continuar";
            //Link Excel -> https://www.microsoft.com/pt-br/store/p/excel-mobile/9wzdncrfjbh3
            var uriString = "ms-windows-store://pdp/?ProductId=9wzdncrfjbh3";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void Word_Tapped(object sender, TappedRoutedEventArgs e)
        {
            btDepois.Content = "Continuar";
            //Link Word -> https://www.microsoft.com/pt-br/store/p/word-mobile/9wzdncrfjb9s
            var uriString = "ms-windows-store://pdp/?ProductId=9wzdncrfjb9s";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void PowerPoint_Tapped(object sender, TappedRoutedEventArgs e)
        {
            btDepois.Content = "Continuar";
            //Link PowerPoint -> https://www.microsoft.com/pt-br/store/p/powerpoint-mobile/9wzdncrfjb5q
            var uriString = "ms-windows-store://pdp/?ProductId=9wzdncrfjb5q";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void Skype_Tapped(object sender, TappedRoutedEventArgs e)
        {
            btDepois.Content = "Continuar";
            //Link Skype -> https://www.microsoft.com/pt-br/store/p/skype-preview/9wzdncrfj364
            var uriString = "ms-windows-store://pdp/?ProductId=9wzdncrfj364";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void Outlook_Tapped(object sender, TappedRoutedEventArgs e)
        {
            btDepois.Content = "Continuar";
            //Link Outlook -> https://www.microsoft.com/pt-br/store/p/mail-and-calendar/9wzdncrfhvqm
            var uriString = "ms-windows-store://pdp/?ProductId=9wzdncrfhvqm";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }
    }
}
