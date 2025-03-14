﻿using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly Context _db;

        public SecretariaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Secretaria Secretaria)
        {
            
            _db.Secretaria.Add(Secretaria);
            _db.SaveChanges();
        }

        public List<Secretaria> GetAll() { 
          return _db.Secretaria.ToList();
        }

    }
}
