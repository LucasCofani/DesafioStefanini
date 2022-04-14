using DesafioStefanini.Shared.Models;

namespace DesafioStefanini.Shared.Service
{
    public interface IPessoaService
    {
        Task<ResponseWrapper<List<PessoaDTO>>> GetAllAsync();
        Task<ResponseWrapper<Pessoa>> GetByIdAsync(int id);
        Task<ResponseWrapper<Pessoa>> CreateAsync(Pessoa request);
        Task<ResponseWrapper<string>> UpdateAsync(int id, Pessoa request);
        Task<ResponseWrapper<string>> DeleteAsync(int id);
    }
}
