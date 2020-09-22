using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorldBuilding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        async void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var title = picker.Title;
            if (picker.SelectedIndex == -1) return;
            var selectedItem = picker.Items[picker.SelectedIndex];


            switch (title)
            {
                case "Worlds":
                    switch(selectedItem)
                    {
                        case "View":
                            picker.SelectedIndex = -1;
                            await Navigation.PushAsync(new ViewWorlds());
                            break;
                        case "Create":
                            picker.SelectedIndex = -1;
                            await Navigation.PushAsync(new CreateWorld());
                            break;
                    }
                    break;
                case "Locations":
                    picker.SelectedIndex = -1;
                    await Navigation.PushAsync(new ViewLocations());
                    break;

            }
        }
    }
}
