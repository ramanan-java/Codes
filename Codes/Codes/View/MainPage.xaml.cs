using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Codes.View
{
    public partial class MainPage : ContentPage
    {
        List<string> options = new List<string> {
            "Get Geolocation",
            "Open PDF"
        };

        public MainPage()
        {
            InitializeComponent();

            listview.ItemsSource = options;
            listview.ItemSelected += OntemSelected;
        }

        private void OntemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            switch (options.IndexOf(e.SelectedItem.ToString()))
            {
                case 0:
                    Navigation.PushAsync(new GeolocationPage());
                    break;
            }
        }
    }
}
