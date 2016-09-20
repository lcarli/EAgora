using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
using EAgoraNewNavPane.Views;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EAgoraNewNavPane
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MobileServiceUser user;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btogin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Principal));
            //bool logged = await AuthenticateAsync();
            //if (logged)
            //{
            //    //this.Frame.Navigate(typeof(Pages.Principal));
            //}
            //else
            //{
            //    string message = "Você precisa estar logado para acessar o aplicativo.";
            //    var dialog = new MessageDialog(message);
            //    dialog.Commands.Add(new UICommand("OK"));
            //    await dialog.ShowAsync();
            //}
        }

        private async Task<bool> AuthenticateAsync()
        {
            try
            {
                user = await App.MobileService
                    .LoginAsync(MobileServiceAuthenticationProvider.WindowsAzureActiveDirectory);
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }

    }
}
