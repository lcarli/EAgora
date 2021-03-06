﻿using System;
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
    public sealed partial class SitesPrepareVestibulares : Page
    {
        public SitesPrepareVestibulares()
        {
            this.InitializeComponent();
        }

        private async void StackOne_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var uriString = "http://www.educacao.sp.gov.br/educacao-jovens-adultos";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void StackTwo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var uriString = "https://pt.khanacademy.org/math/enem";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }

        private async void StackThree_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var uriString = "http://www.educacao.sp.gov.br/evesp/cursos/";
            await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));
        }
    }
}
