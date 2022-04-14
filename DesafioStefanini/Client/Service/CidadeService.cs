using DesafioStefanini.Client.Network;
using DesafioStefanini.Shared.Models;
using DesafioStefanini.Shared.Service;

namespace DesafioStefanini.Client.Service
{
    public class CidadeService : ICidadeService
    {
        private readonly DesafioApi _api;
        public CidadeService(DesafioApi api)
        {
            _api = api;
        }
        public async Task<ResponseWrapper<Cidade>> CreateAsync(Cidade request)
        {
            var res = await _api.CreateCidade(request);
            return res;
        }

        public async Task<ResponseWrapper<string>> DeleteAsync(int id)
        {
            var res = await _api.DeleteCidade(id);
            return res;
        }

        public async Task<ResponseWrapper<List<CidadeDTO>>> GetAllAsync()
        {
            var res = await _api.GetAllCidade();
            return res;
        }

        public async Task<ResponseWrapper<Cidade>> GetByIdAsync(int id)
        {
            var res = await _api.GetByIdCidade(id);
            return res;
        }

        public async Task<ResponseWrapper<string>> UpdateAsync(int id, Cidade request)
        {
            var res = await _api.UpdateCidade(id,request);
            return res;
        }
    }
}
