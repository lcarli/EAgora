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
    public sealed partial class MatchResult : Page
    {
        private string HumanasResult = "Você tem um raciocínio verbal bastante aguçado, capacidade de síntese e gestão de conflitos. Em geral, são pessoas com senso crítico apurado, gostam muito de ler e direcionam seus interesses para carreiras que têm como tema central a sociedade, sua formação, eventos, história, arte, cultura e comportamentos.";
        private string ExatasResult = "Você tem um raciocínio lógico bastante aguçado, capacidade de encontrar soluções exatas e precisas. Em geral, são pessoas que possuem um raciocínio rápido e estão sempre atualizados sobre os avanços tecnológicos que impactam na vida da sociedade.";
        private string BiologicasResult = "Você é curioso e demonstra muito interesse por estudos e leitura. Em geral, são pessoas que adoram estar em contato com a natureza, com os animais e com o corpo humano, pois estudam tudo que é relacionado ao meio ambiente e a natureza humana, de acordo com cada profissão.São estudiosos, dedicados, amigos dos animais e da natureza.";
        string perfil = "";

        public MatchResult()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            perfil = e.Parameter.ToString();
            text2.Text = perfil;
            App.SaveData("Perfil", perfil);
            if (perfil == "Humanas")
            {
                text3.Text = HumanasResult;
            }
            else if (perfil == "Exatas")
            {
                text3.Text = ExatasResult;
            }
            else
            {
                text3.Text = BiologicasResult;
            }
        }

        private void btavancar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MatchResultsMateriais), perfil);
        }
    }
}
