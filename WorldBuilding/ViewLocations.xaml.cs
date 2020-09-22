using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldBuilding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewLocations : ContentPage
    {
        public ViewLocations()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetAllLocationsAsync();
        }
    }
}