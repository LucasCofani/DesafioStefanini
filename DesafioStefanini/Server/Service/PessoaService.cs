using DesafioStefanini.Server.Data;
using DesafioStefanini.Shared.Models;
using DesafioStefanini.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DesafioStefanini.Server.Service
{
    public class PessoaService : BaseService<PessoaService>, IPessoaService
    {
        private readonly DefaultDbContext _db;
        public PessoaService(ILogger<PessoaService> logger, DefaultDbContext db) : base(logger)
        {
            _db = db;
        }

        public async Task<ResponseWrapper<Pessoa>> CreateAsync(Pessoa request)
        {

            try
            {
                await _db.pessoas.AddAsync(request);
                await _db.SaveChangesAsync();
                return ResponseWrapper<Pessoa>.Ok(request);
            }
            catch (Exception ex)
            {
                return ResponseWrapper<Pessoa>.Error(ex.Message);
            }

        }

        public async Task<ResponseWrapper<string>> DeleteAsync(int id)
        {
            try
            {
                var info = await _db.pessoas.FirstOrDefaultAsync(p => p.Id == id);
                if (info != null) { 
                    _db.pessoas.Remove(info);
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

        public async Task<ResponseWrapper<List<PessoaDTO>>> GetAllAsync()
        {
            try
            {
                var info = await _db.pessoas.Include(p => p.Cidade).AsNoTracking().ToListAsync();
                var res = new List<PessoaDTO>();
                foreach (var item in info)
                {
                    res.Add(new PessoaDTO(item));
                }
                return ResponseWrapper<List<PessoaDTO>>.Ok(res);
            }
            catch (Exception ex)
            {
                return ResponseWrapper<List<PessoaDTO>>.Error(ex.Message);
            }
        }

        public async Task<ResponseWrapper<Pessoa>> GetByIdAsync(int id)
        {
            try
            {
                var info = await _db.pessoas.Include(p => p.Cidade).FirstOrDefaultAsync(p => p.Id == id);
                if (info != null)
                {
                    return ResponseWrapper<Pessoa>.Ok(info);
                }
                return ResponseWrapper<Pessoa>.Error("User not found");
            }
            catch (Exception ex)
            {
                return ResponseWrapper<Pessoa>.Error(ex.Message);
            }
        }

        public async Task<ResponseWrapper<string>> UpdateAsync(int id, Pessoa request)
        {
            try
            {
                var info = await _db.pessoas.FirstOrDefaultAsync(p => p.Id == id);
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
