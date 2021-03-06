﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldBuilding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateWorld : ContentPage
    {
        public CreateWorld()
        {
            InitializeComponent();
            this.BindingContext = new Worlds();
        }

        async void OnSaveClicked(object sender, EventArgs args)
        {
            var world = (Worlds)BindingContext;
            await App.Database.SaveItemAsync(world);
            await Navigation.PopAsync();
        }
    }
}