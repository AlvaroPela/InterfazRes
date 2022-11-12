using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Text;

namespace InterfazRes
{
    public class Constants
    {        
            private const string DatabaseFileName = "SQLite.db3"; //Aca definimos el nombre de la base de datos Local
            public const SQLite.SQLiteOpenFlags flags = SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
                SQLite.SQLiteOpenFlags.SharedCache;
        //Esta es la configuración recomendada para trabajar con nuestro archivo de bases de datos local, este
        //archivo lo ocuparemos mas adelante cuando vayamos a crear el fichero de la base de datos.

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //este metodo nos permite obtener la ruta de un folder especifico
                return Path.Combine(basePath, DatabaseFileName);
            }
        }
    }
}

