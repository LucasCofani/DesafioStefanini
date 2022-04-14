using DesafioStefanini.Shared.Models;
using Refit;

namespace DesafioStefanini.Client.Network
{
    public interface DesafioApi
    {
        [Get("/api/Cidade/{id}")]
        Task<ResponseWrapper<Cidade>> GetByIdCidade(int id);

        [Get("/api/Cidade")]
        Task<ResponseWrapper<List<CidadeDTO>>> GetAllCidade();

        [Post("/api/Cidade")]
        Task<ResponseWrapper<Cidade>> CreateCidade(Cidade c);

        [Put("/api/Cidade/{id}")]
        Task<ResponseWrapper<string>> UpdateCidade(int id,Cidade c);

        [Delete("/api/Cidade/{id}")]
        Task<ResponseWrapper<string>> DeleteCidade(int id);


        [Get("/api/Pessoa/{id}")]
        Task<ResponseWrapper<Pessoa>> GetByIdPessoa(int id);

        [Get("/api/Pessoa")]
        Task<ResponseWrapper<List<PessoaDTO>>> GetAllPessoa();

        [Post("/api/Pessoa")]
        Task<ResponseWrapper<Pessoa>> CreatePessoa(Pessoa c);

        [Put("/api/Pessoa/{id}")]
        Task<ResponseWrapper<string>> UpdatePessoa(int id, Pessoa c);

        [Delete("/api/Pessoa/{id}")]
        Task<ResponseWrapper<string>> DeletePessoa(int id);

    }
}
