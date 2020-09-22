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
    public partial class CreateCharacter : ContentPage
    {
        public int id;
        public CreateCharacter(int id)
        {
            this.id = id;
            InitializeComponent();
            this.BindingContext = new Characters();
        }

        async void OnCreateClicked(object sender, EventArgs args)
        {
            var character = (Characters)BindingContext;
            character.WorldID = id;
            await App.Database.SaveItemAsync(character);
            await Navigation.PopAsync();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetAllCharactersAsync();
        }


    }
}