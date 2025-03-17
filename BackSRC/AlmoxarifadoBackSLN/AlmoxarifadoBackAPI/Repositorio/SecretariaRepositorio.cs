using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class SecretariaRepositorio : ICategoriaRepositorio
    {
        private readonly Context _db;

        public SecretariaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Secretaria Secretaria)
        {
            
            _db.Categoria.Add(        public void Add(Secretaria Secretaria)
);
            _db.SaveChanges();
        }

        public List<Categoria> GetAll() => _db.Categoria.ToList();

    }
}
