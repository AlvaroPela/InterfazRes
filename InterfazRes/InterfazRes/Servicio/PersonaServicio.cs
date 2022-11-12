using InterfazRes.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace InterfazRes.Servicio
{
    public class PersonaServicio
    { 
        SQLiteConnection connection; //permite establecer una conexion con el archivo de base de datos
        public string MensajeDeEstado { get; set; }

        public PersonaServicio()
        {
            connection =
                new SQLiteConnection(Constants.DatabasePath, Constants.flags); //ruta hacia archivo de la base de datos
            connection.CreateTable<PersonaModel>();
        }

        public void Guardar(PersonaModel nuevaPersona)
        {
            int result = 0;
            try
            {
                result = connection.Insert(nuevaPersona);
                MensajeDeEstado = string.Format($"{result} registro(s) agregado(s)");
            }
            catch (Exception ex)
            {

                MensajeDeEstado = $"Error: {ex.Message}";
            }
        }

        public List<PersonaModel> SeleccionarTodo()
        {
            try
            {
                return connection.Table<PersonaModel>().ToList();
            }
            catch (Exception ex)
            {

                MensajeDeEstado = $"Error: {ex.Message}";
            }
            return null;
        }

        public PersonaModel Get(string id)
        {
            try
            {
                return connection.Table<PersonaModel>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                MensajeDeEstado = $"Error: {ex.Message}";

            }
            return null;
        }

        public void Modificar(PersonaModel nuevaPersona)
        {
            int result = 0;
            try
            {
                if (nuevaPersona.Id != "")
                {
                    result = connection.Update(nuevaPersona);
                    MensajeDeEstado = string.Format($"{result} registro(s) actualizado(s)");
                }
                else
                {
                    result = connection.Insert(nuevaPersona);
                    MensajeDeEstado = string.Format($"{result} registro(s) agregado(s)");
                }
            }
            catch (Exception ex)
            {
                MensajeDeEstado = $"Error: {ex.Message}";
            }
        }

        public void Eliminar(string personaId)
        {
            try
            {
                var persona = Get(personaId);
                connection.Delete(persona);
            }
            catch (Exception ex)
            {

                MensajeDeEstado = $"Error: {ex.Message}";
            }
        }
    }
}
