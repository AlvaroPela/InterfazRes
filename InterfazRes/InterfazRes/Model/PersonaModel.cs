using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InterfazRes.Model
{
    public class PersonaModel
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        [Indexed, NotNull]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}
