    using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dZapataOnlines2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage(new LoginDeber());
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
