using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class MaterialUniversidade : Page
    {
        public MaterialUniversidade()
        {
            this.InitializeComponent();
        }

        private async void Tudo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private void Exercicios_Tapped(object sender, TappedRoutedEventArgs e)
        {
            openOfficeFileFromURI("onenote:https://d.docs.live.net/f1eb13e17b9ef550/Documents/FUVEST/Exercícios.one#section-id={1BB802B5-2499-4C34-828F-C07E62BB0ED3}&end");
        }

        private void Livros_Tapped(object sender, TappedRoutedEventArgs e)
        {
            App.DefaultLaunch("");
        }

        private void Cursos_Tapped(object sender, TappedRoutedEventArgs e)
        {
            openOfficeFileFromURI("onenote:https://d.docs.live.net/f1eb13e17b9ef550/Documents/FUVEST/Cursos.one#section-id={161EA729-5C95-4D86-BDEE-D4612CB37D46}&end");
        }

        private void Provas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            App.DefaultLaunch2("");
        }

        private async void openOfficeFileFromURI(string uriToLaunch)
        {
            // Create a Uri object from a URI string 
            var uri = new Uri(uriToLaunch);
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
        }

    }
}
