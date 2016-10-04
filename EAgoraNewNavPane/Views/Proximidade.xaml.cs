using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Proximidade : Page
    {
        public List<SkypeMembers> Skypes;
        public List<string> Distances = new List<string>() { "2", "5", "10", "15", "20" };

        public Proximidade()
        {
            this.InitializeComponent();
            Skypes = new List<SkypeMembers>();
            CreateSkypeMembersList();
        }

        private async void SkypeListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sk = e.ClickedItem as SkypeMembers;
            var success = await Windows.System.Launcher.LaunchUriAsync(new Uri("skype:"+sk.Name+"?chat"));
        }

        private void CreateSkypeMembersList()
        {
            Random rnd = new Random();
            foreach (var item in App.SkypeNames)
            {
                int r = rnd.Next(Distances.Count);
                SkypeMembers sm = new SkypeMembers() { Name = item, Distance = Distances[r] };
                Skypes.Add(sm);
                SkypeListView.Items.Add(sm);
            }
        }

        public class SkypeMembers
        {
            public string Name { get; set; }

            public string Distance { get; set; }
        }

        private void Filtro2_Click(object sender, RoutedEventArgs e)
        {
            var NewSkypes = Skypes.Where(p => p.Distance == "2").ToList();
            SkypeListView.Items.Clear();
            foreach (var item in NewSkypes)
            {
                SkypeListView.Items.Add(item);
            }
        }

        private void Filtro5_Click(object sender, RoutedEventArgs e)
        {
            var NewSkypes = Skypes.Where(p => p.Distance == "5").ToList();
            SkypeListView.Items.Clear();
            foreach (var item in NewSkypes)
            {
                SkypeListView.Items.Add(item);
            }
        }

        private void Filtro10_Click(object sender, RoutedEventArgs e)
        {
            var NewSkypes = Skypes.Where(p => p.Distance == "10").ToList();
            SkypeListView.Items.Clear();
            foreach (var item in NewSkypes)
            {
                SkypeListView.Items.Add(item);
            }
        }

        private void Filtro15_Click(object sender, RoutedEventArgs e)
        {
            var NewSkypes = Skypes.Where(p => p.Distance == "15").ToList();
            SkypeListView.Items.Clear();
            foreach (var item in NewSkypes)
            {
                SkypeListView.Items.Add(item);
            }
        }

        private void Filtro20_Click(object sender, RoutedEventArgs e)
        {
            var NewSkypes = Skypes.Where(p => p.Distance == "20").ToList();
            SkypeListView.Items.Clear();
            foreach (var item in NewSkypes)
            {
                SkypeListView.Items.Add(item);
            }
        }
    }
}
