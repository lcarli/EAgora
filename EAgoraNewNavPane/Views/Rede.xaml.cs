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
    public sealed partial class Rede : Page
    {
        public Rede()
        {
            this.InitializeComponent();
        }

        private void Proximidade(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Mapa), "proximidade");
        }

        private async void AreaDeInteresse(object sender, RoutedEventArgs e)
        {
            if (App.GetData("Perfil").ToString() == "" || App.GetData("Perfil").ToString() == null)
            {
                MessageDialog cd = new MessageDialog("Você ainda não descobriu seu MATCH Vocacional. É preciso definir antes de filtrar pela área de interesse.");
                await cd.ShowAsync();
            }
            else
            {
                this.Frame.Navigate(typeof(Mapa), "area");
            }
        }
    }
}
