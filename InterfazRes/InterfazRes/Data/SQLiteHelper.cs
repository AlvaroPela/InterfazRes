﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using InterfazRes.Model;
using System.Threading.Tasks;

namespace InterfazRes.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper (string dbpatch)
        {
            db = new SQLiteAsyncConnection (dbpatch);
            db.CreateTableAsync<Persona>().Wait();

        }
        public Task <int> SavePersonaAsync(Persona person)
        {
            if (person.IdPersona==0)
            {
                return db.InsertAsync(person);
            }
            else
            {
                return null;
            }
        }
        public Task <List<Persona>> GetPersonasAsync()
        {
            return db.Table<Persona>().ToListAsync();
        }

        public Task<Persona> GetPersonaAsync (int idPersona)
        {
            return db.Table<Persona>().Where(a => a.IdPersona == idPersona).FirstOrDefaultAsync();
        }
    }
}