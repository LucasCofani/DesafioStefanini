using DesafioStefanini.Shared.Models;

namespace DesafioStefanini.Shared.Service
{
    public interface ICidadeService
    {
        Task<ResponseWrapper<List<CidadeDTO>>> GetAllAsync();
        Task<ResponseWrapper<Cidade>> GetByIdAsync(int id);
        Task<ResponseWrapper<Cidade>> CreateAsync(Cidade request);
        Task<ResponseWrapper<string>> UpdateAsync(int id, Cidade request);
        Task<ResponseWrapper<string>> DeleteAsync(int id);
    }
}
