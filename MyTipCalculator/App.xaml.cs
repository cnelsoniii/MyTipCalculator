using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTipCalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            var nav = new NavigationPage(new MainPage
            {
                BindingContext = new MainPageViewModel()
            });
            MainPage = nav;
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
