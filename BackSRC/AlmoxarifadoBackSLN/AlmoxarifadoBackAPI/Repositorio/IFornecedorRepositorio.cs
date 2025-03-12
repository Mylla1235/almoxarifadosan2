using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IFornecedorRepositorio
    {
        void Add(Fornecedor Fornecedor);

        List<Fornecedor> GetAll();

        
    }
}
