using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazRes.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioSesion : ContentPage
    {
        String valUsuario;
        String valContrasena;
        String usuario = "1";
        String contrasena = "1";

        public InicioSesion()
        {
            InitializeComponent();
        }

        public void ValidarUsuario()
        {
            valUsuario = txtUsuario.Text;
            valContrasena = txtContraseña.Text;
            if (valUsuario == usuario || valContrasena == contrasena)
            {
                DisplayAlert("", "Exitoso", "Aceptar");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Inicio Sesion", "Datos incorrectos", "Aceptar");
            }

        }

        

        private void btnRegistarUsuario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PersonaPage());
        }

        private void btnEntrarUsuario_Clicked(object sender, EventArgs e)
        {
            ValidarUsuario();

        }
    }
}