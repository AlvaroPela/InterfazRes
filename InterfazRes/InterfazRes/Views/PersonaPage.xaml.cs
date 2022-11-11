using InterfazRes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        public PersonaPage()
        {
            InitializeComponent();
        }

        private async void btnRegistar_Clicked(object sender, EventArgs e)
        {

            if (validarDatos())
            {
                Persona person = new Persona
                {
                    Nombre = txtNombre.Text,
                    Apellido= txtApellido.Text,
                    Edad= int.Parse(txtEdad.Text),
                    Email= txtEmail.Text,   
                };
                await App.SQLiteDB.SavePersonaAsync(person);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtEmail.Text = "";
                await DisplayAlert("Registro "," Se registro de manera exitosa");

            }
            else
            {
                await DisplayAlert("Advertencia ", "Ingresar todos los datos");
            }

        }

        private Task DisplayAlert(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEdad.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;   
            }
            return respuesta;

        }
    }
}