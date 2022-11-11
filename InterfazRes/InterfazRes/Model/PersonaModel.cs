 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

namespace InterfazRes.Model
{
   public class Persona
    {

        [PrimaryKey,AutoIncrement]
        public int IdPersona { get; set; }
        [MaxLength (50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Apellido { get; set; }
       
        public int Edad { get; set; }
        [MaxLength (100)]
        public string Email { get; set; }




    }
}
