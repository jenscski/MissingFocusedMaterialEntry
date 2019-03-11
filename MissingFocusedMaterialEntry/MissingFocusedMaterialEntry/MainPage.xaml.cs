using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MissingFocusedMaterialEntry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Entry_Focused(object sender, FocusEventArgs e)
        {
            var entry = sender as Entry;
            await DisplayAlert("Focused", entry.Placeholder, "Ok");
        }
    }
}
