using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using Windows.Data.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EAgoraNewNavPane.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MatchQuestions : Page
    {
        public ObservableCollection<Questions> ListOfQuestion { get; set; } = new ObservableCollection<Questions>();
        public ObservableCollection<int> ListOfAnswersA { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<int> ListOfAnswersB { get; set; } = new ObservableCollection<int>();
        Object randomNumbers;
        int qCounter = 0;


        public MatchQuestions()
        {
            this.InitializeComponent();
            ListOfAnswersA.Clear();
            ListOfAnswersB.Clear();
            ListOfQuestion.Clear();
            sortNotRepeated();
            qCounter = 0;
            completeList();
            Task.Delay(500);
            sortQuestion();
        }
        private void completeList()
        {
            Uri appUri = new Uri("ms-appx:///Assets/questions.json");
            StorageFile anjFile = StorageFile.GetFileFromApplicationUriAsync(appUri).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            string jsonText = FileIO.ReadTextAsync(anjFile).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            JsonArray root = JsonValue.Parse(jsonText).GetArray();
            for (uint i = 0; i < root.Count; i++)
            {
                Questions q = new Questions();
                q.pergunta = root.GetObjectAt(i).GetNamedString("pergunta");
                q.resposta1 = root.GetObjectAt(i).GetNamedString("Resposta 1");
                q.resposta2 = root.GetObjectAt(i).GetNamedString("Resposta 2");
                ListOfQuestion.Add(q);
            }
        }

        private void sortQuestion()
        {
            if (qCounter == 30)
            {
                string perfil = "";
                if (ListOfAnswersA.Count() > (0.75 * ListOfQuestion.Count()))
                {
                    perfil = "Humanas";
                }
                else if (ListOfAnswersB.Count() > (0.75 * ListOfQuestion.Count()))
                {
                    perfil = "Exatas";
                }
                else
                {
                    perfil = "Biológicas";
                }
                this.Frame.Navigate(typeof(MatchResult), perfil);
            }
            else
            {
                iconQ1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Heart.png"));
                iconQ2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Heart.png"));
                question.Text = ListOfQuestion[qCounter].pergunta;
                answer1.Text = ListOfQuestion[qCounter].resposta1;
                answer2.Text = ListOfQuestion[qCounter].resposta2;
                qCounter++;
            }
        }

        private void sortNotRepeated()
        {
            Random r = new Random();
            randomNumbers = Enumerable.Range(1, 30).OrderBy(x => r.Next()).Take(30).ToList();
        }

        public class Questions
        {
            public string pergunta { get; set; }
            public string resposta1 { get; set; }
            public string resposta2 { get; set; }
        }

        private void btComecar_Click(object sender, RoutedEventArgs e)
        {
            sortQuestion();
        }

        private void stack2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            iconQ2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Heart.png"));
            iconQ1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Broken Heart.png"));
            ListOfAnswersB.Add(1);
        }

        private void stack1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            iconQ1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Heart.png"));
            iconQ2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Broken Heart.png"));
            ListOfAnswersA.Add(1);
        }
    }
}
