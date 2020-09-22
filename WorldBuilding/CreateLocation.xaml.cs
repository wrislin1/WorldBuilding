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
    public partial class CreateLocation : ContentPage
    {
       public int id;

        public CreateLocation(int id)
        {
            this.id = id;
            InitializeComponent();
            this.BindingContext = new Locations();
        }

        async void OnSaveClicked(object sender, EventArgs args)
        {
            var location = (Locations)BindingContext;
            location.WorldID = id;
            await App.Database.SaveItemAsync(location);
            await Navigation.PopAsync();
        }
    }
}