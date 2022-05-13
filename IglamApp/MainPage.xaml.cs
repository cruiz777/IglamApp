using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IglamApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            string usuario =txtUsuario.Text;
            string clave=txtClave.Text;
            if(usuario=="admin" && clave=="admin")
            {
                DisplayAlert("Advertencia", "Bienvenido: "+usuario, "Ok");
                await Navigation.PushAsync(new Principal());

            }
            else
            {
                _ = DisplayAlert("Advertencia", "Datos Incorrectos", "Ok");
                txtUsuario.Text = "";
                txtClave.Text = "";

            }
        }
    }
}
