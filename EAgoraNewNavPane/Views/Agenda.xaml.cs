﻿using System;
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
    public sealed partial class Agenda : Page
    {
        public Agenda()
        {
            this.InitializeComponent();
        }

        private void evento_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void eventosSalvos_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private void datas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Universidades));
        }

        private async void papoHumanas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private async void papoExatas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private async void papoBiológicas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }

        private async void criarEvento_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em Desenvolvimento.");
            await md.ShowAsync();
        }
    }
}
