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
    public sealed partial class Prepare : Page
    {
        public Prepare()
        {
            this.InitializeComponent();
        }

        private void StackFour_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SitesPrepareVestibulares));
        }

        private void StackThree_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void StackTwo_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void StackOne_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
