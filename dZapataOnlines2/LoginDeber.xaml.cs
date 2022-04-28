using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dZapataOnlines2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginDeber : ContentPage
    {
        public LoginDeber()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            if (usuario == "estudiante2022")
            {
                await Navigation.PushAsync(new Page1(usuario, password));
            }
            else { await DisplayAlert("Alert", "Uusario erroneó", "OK"); ; } 
        }
    }
}