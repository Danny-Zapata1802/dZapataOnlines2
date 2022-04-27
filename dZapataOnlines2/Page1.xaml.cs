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
    public partial class Page1 : ContentPage
    {
        public Page1(string usuario, string password)
        {
            InitializeComponent();
           lblUsuario.Text = "Bienvenido usuario: "+ usuario;
            lblPassword.Text = password;
        }

        private void  btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double datoUnoP1 = Convert.ToDouble(txtDatoUnoP1.Text)*0.3;
                double datoDosP1 = Convert.ToDouble(txtDatoDosP1.Text)*0.2;

                double suma = datoUnoP1 + datoDosP1;
                txtResultadosParcial1.Text = suma.ToString();
                double datoUnoP2 = Convert.ToDouble(txtDatoUnoP2.Text) * 0.3;
                double datoDosP2 = Convert.ToDouble(txtDatoDosP2.Text) * 0.2;

                double suma2 = datoUnoP2 + datoDosP2;
                txtResultadosParcial2.Text = suma2.ToString();

                double sumaFinal = suma + suma2;
                txtNotaFinal.Text = sumaFinal.ToString();
            }
            catch (Exception)
            {

            }
        }

    }
}