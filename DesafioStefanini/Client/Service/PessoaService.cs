using DesafioStefanini.Client.Network;
using DesafioStefanini.Shared.Models;
using DesafioStefanini.Shared.Service;

namespace DesafioStefanini.Client.Service
{
    public class PessoaService : IPessoaService
    {
        private readonly DesafioApi _api;
        public PessoaService(DesafioApi api)
        {
            _api = api;
        }
        public async Task<ResponseWrapper<Pessoa>> CreateAsync(Pessoa request)
        {
            var res = await _api.CreatePessoa(request);
            return res;
        }

        public async Task<ResponseWrapper<string>> DeleteAsync(int id)
        {
            var res = await _api.DeletePessoa(id);
            return res;
        }

        public async Task<ResponseWrapper<List<PessoaDTO>>> GetAllAsync()
        {
            var res = await _api.GetAllPessoa();
            return res;
        }

        public async Task<ResponseWrapper<Pessoa>> GetByIdAsync(int id)
        {
            var res = await _api.GetByIdPessoa(id);
            return res;
        }

        public async Task<ResponseWrapper<string>> UpdateAsync(int id, Pessoa request)
        {
            var res = await _api.UpdatePessoa(id,request);
            return res;
        }
    }
}
