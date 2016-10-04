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
    public sealed partial class Universidades : Page
    {
        public Universidades()
        {
            this.InitializeComponent();
        }

        private void Usp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AgendaDetail));
        }

        private async void Mackenzie_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private async void PUC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private async void ITA_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private async void Unicamp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private async void Unesp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }
    }
}
