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
    public partial class World : ContentPage
    {
       public Worlds world;
        public World(Worlds world)
        {
            this.world = world;
            InitializeComponent();
        }

        async void AddLocationClicked(object sender, EventArgs args)
        {
            //Button button = (Button)sender;
            await Navigation.PushAsync(new CreateLocation(world.ID));
        }

        async void AddCharacterClicked(object sender, EventArgs args)
        {
            //Button button = (Button)sender;
            await Navigation.PushAsync(new CreateCharacter(world.ID));
        }

        async void AddLoreClicked(object sender, EventArgs args)
        {
            //Button button = (Button)sender;
            await Navigation.PushAsync(new CreateLore());
        }



    }
}