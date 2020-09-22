using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldBuilding
{
    public partial class App : Application
    {
        static WorldDB database;
        public static WorldDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new WorldDB();
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
