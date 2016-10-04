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
using Windows.Foundation.Metadata;
using Windows.System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EAgoraNewNavPane
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MobileServiceUser user;
        private bool teste = false;

        public MainPage()
        {
            this.InitializeComponent();
            initUi();
        }

        private async void initUi()
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
                await statusBar.HideAsync();
            }
        }

        private async void btogin_Click(object sender, RoutedEventArgs e)
        {
            if (teste)
            {
                this.Frame.Navigate(typeof(Ativacao));

            }
            else
            {
                try
                {
                    bool logged = await AuthenticateAsync();
                    if (logged)
                    {
                        if (App.GetData("ativação").ToString() == "OK")
                        {
                            this.Frame.Navigate(typeof(Principal));
                        }
                        else
                        {
                            this.Frame.Navigate(typeof(Ativacao));
                        }
                    }
                    else
                    {
                        string message = "Você precisa estar logado para acessar o aplicativo.";
                        var dialog = new MessageDialog(message);
                        dialog.Commands.Add(new UICommand("OK"));
                        await dialog.ShowAsync();
                    }
                }
                catch (Exception)
                {
                    MessageDialog md = new MessageDialog("Ocorreu um erro. Por favor, tente novamente.");
                    await md.ShowAsync();
                }
            }
        }

        private async Task<bool> AuthenticateAsync()
        {
            try
            {
                user = await App.MobileService
                    .LoginAsync(MobileServiceAuthenticationProvider.WindowsAzureActiveDirectory);
                App.SaveData("User", user.UserId);
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }

        private async void Matricula_Click(object sender, RoutedEventArgs e)
        {
            //https://sed.educacao.sp.gov.br/obtenha-seu-acesso
            await Launcher.LaunchUriAsync(new Uri("https://sed.educacao.sp.gov.br/obtenha-seu-acesso"));
        }

        private async void Termos_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Em desenvolvimento");
            await md.ShowAsync();
        }

        private async void Senha_Click(object sender, RoutedEventArgs e)
        {
            //https://sed.educacao.sp.gov.br/esqueci-a-senha 
            await Launcher.LaunchUriAsync(new Uri("https://sed.educacao.sp.gov.br/esqueci-a-senha"));
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            teste = !teste;
        }
    }
}
