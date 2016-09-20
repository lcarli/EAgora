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
    public sealed partial class MatchResultsMateriais : Page
    {
        private string perfil;
        public MatchResultsMateriais()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            perfil = e.Parameter.ToString();
            text2.Text = perfil + "!";
        }

        private async void StackTwo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //onenote
            switch (perfil)
            {
                case "Humanas":
                    openOfficeFileFromURI("onenote:https://d.docs.live.net/f1eb13e17b9ef550/Documents/Perfil%20de%20Humanas/");
                     break;
                case "Exatas":
                    openOfficeFileFromURI("onenote:https://d.docs.live.net/f1eb13e17b9ef550/Documents/Perfil%20de%20Exatas/");
                    break;
                case "Biológicas":
                    openOfficeFileFromURI("onenote:https://d.docs.live.net/f1eb13e17b9ef550/Documents/Perfil%20de%Biológicas/");
                    break;
                default:
                    ContentDialog cd = new ContentDialog();
                    cd.Content = "Um erro foi encontrado. Tente novamente.";
                    await cd.ShowAsync();
                    break;
            }
        }

        private async void StackOne_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //sway
            switch (perfil)
            {
                case "Humanas":
                    openOfficeFileFromURI("sway:https://sway.com/jeiAzSRmDqlZk7pJ");
                    break;
                case "Exatas":
                    openOfficeFileFromURI("sway:https://sway.com/QTD7PAIuAm2wi6Cv");
                    break;
                case "Biológicas":
                    openOfficeFileFromURI("sway:https://sway.com/hKyYytO7vGYjpGgp");
                    break;
                default:
                    ContentDialog cd = new ContentDialog();
                    cd.Content = "Um erro foi encontrado. Tente novamente.";
                    await cd.ShowAsync();
                    break;
            }
        }

        private async void openOfficeFileFromURI(string uriToLaunch)
        {
            // Create a Uri object from a URI string 
            var uri = new Uri(uriToLaunch);
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);

            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }
    }
}
