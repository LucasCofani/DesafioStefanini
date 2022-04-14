using DesafioStefanini.Server.Data;
using DesafioStefanini.Shared.Models;
using DesafioStefanini.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DesafioStefanini.Server.Service
{
    public class CidadeService : BaseService<PessoaService>, ICidadeService
    {
        private readonly DefaultDbContext _db;
        public CidadeService(ILogger<PessoaService> logger, DefaultDbContext db) : base(logger)
        {
            _db = db;
        }

        public async Task<ResponseWrapper<Cidade>> CreateAsync(Cidade request)
        {

            try
            {
                await _db.cidades.AddAsync(request);
                await _db.SaveChangesAsync();
                return ResponseWrapper<Cidade>.Ok(request);
            }
            catch (Exception ex)
            {
                return ResponseWrapper<Cidade>.Error(ex.Message);
            }

        }

        public async Task<ResponseWrapper<string>> DeleteAsync(int id)
        {
            try
            {
                var info = await _db.cidades.FirstOrDefaultAsync(p => p.Id == id);
                if (info != null) { 
                    _db.cidades.Remove(info);
                    await _db.SaveChangesAsync();
                    return ResponseWrapper<string>.Ok($"User deleted:{id}");
                }
                return ResponseWrapper<string>.Error("User not found");
            }
            catch (Exception ex)
            {
                return ResponseWrapper<string>.Error(ex.Message);
            }
        }

        public async Task<ResponseWrapper<List<CidadeDTO>>> GetAllAsync()
        {
            try
            {
                var info = await _db.cidades.AsNoTracking().ToListAsync();
                var res = new List<CidadeDTO>();
                foreach (var item in info)
                {
                    res.Add(new CidadeDTO(item));
                }
                return ResponseWrapper<List<CidadeDTO>>.Ok(res);
            }
            catch (Exception ex)
            {
                return ResponseWrapper<List<CidadeDTO>>.Error(ex.Message);
            }
        }

        public async Task<ResponseWrapper<Cidade>> GetByIdAsync(int id)
        {
            try
            {
                var info = await _db.cidades.FirstOrDefaultAsync(p => p.Id == id);
                if (info != null)
                {
                    return ResponseWrapper<Cidade>.Ok(info);
                }
                return ResponseWrapper<Cidade>.Error("User not found");
            }
            catch (Exception ex)
            {
                return ResponseWrapper<Cidade>.Error(ex.Message);
            }
        }

        public async Task<ResponseWrapper<string>> UpdateAsync(int id, Cidade request)
        {
            try
            {
                var info = await _db.cidades.FirstOrDefaultAsync(p => p.Id == id);
                if (info != null)
                {
                    info.Update(request);
                    await _db.SaveChangesAsync();
                    return ResponseWrapper<string>.Ok("User updated");
                }
                return ResponseWrapper<string>.Error("User not found");
            }
            catch (Exception ex)
            {
                return ResponseWrapper<string>.Error(ex.Message);
            }
        }
    }
}
