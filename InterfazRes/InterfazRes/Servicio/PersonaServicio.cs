using InterfazRes.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace InterfazRes.Servicio
{
    internal class PersonaServicio
    {

        public ObservableCollection<PersonaModel> personas { get; set; }

        public PersonaServicio()
        {
            if (personas == null)
            {
                personas = new ObservableCollection<PersonaModel>();
            }
        }
        public ObservableCollection<PersonaModel> Consultar()
        {
            return personas;
        }
        public void Guardar(PersonaModel model)
        {
            personas.Add(model);
        }
        public void Modificar(PersonaModel model)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Id == model.Id)
                {
                    personas[i] = model;
                }
            }
        }

        public void Eliminar(string idPersona)
        {
            PersonaModel model = personas.FirstOrDefault(p => p.Id == idPersona);
        }

    }
}
