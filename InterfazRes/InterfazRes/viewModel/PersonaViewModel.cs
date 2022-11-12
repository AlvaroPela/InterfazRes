using InterfazRes.Model;
using InterfazRes.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterfazRes.viewModel
{
    internal class PersonaViewModel : PersonaModel
    {
        public List<PersonaModel> personas { get; set; }
        public ICommand GuardarCommand { get; set; }
        public ICommand ModificarCommand { get; set; }

        public PersonaModel nuevaPersona { get; set; }

        public PersonaViewModel()
        {
            Refresh();
            GenerarNuevaPersona();//en el error le doy generar metodo
#pragma warning disable CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica
            GuardarCommand = new Command(async () =>
            {
                App.Personaservicio.Guardar(nuevaPersona);
                Console.WriteLine(App.Personaservicio.MensajeDeEstado);
                GenerarNuevaPersona();
                Refresh();
          
            });
#pragma warning restore CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica

#pragma warning disable CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica
            ModificarCommand = new Command(async () =>
            {
                App.Personaservicio.Modificar(nuevaPersona);
                Console.WriteLine(App.Personaservicio.MensajeDeEstado);
                GenerarNuevaPersona();
                Refresh();
                
            }) ;
#pragma warning restore CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica
        }

        private void Refresh()
        {
            throw new NotImplementedException();
        }

        private void GenerarNuevaPersona()
        {
            throw new NotImplementedException();
        }
    }
}
