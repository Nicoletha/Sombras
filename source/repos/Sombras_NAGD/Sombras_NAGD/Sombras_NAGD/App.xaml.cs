using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sombras_NAGD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Sombra();
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
