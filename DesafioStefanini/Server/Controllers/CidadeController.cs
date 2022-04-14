using DesafioStefanini.Shared.Models;
using DesafioStefanini.Shared.Service;
using Microsoft.AspNetCore.Mvc;

namespace DesafioStefanini.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _repository;

        private readonly ILogger<CidadeController> _logger;

        public CidadeController(
            ILogger<CidadeController> logger,
            ICidadeService _repo
            )
        {
            _logger = logger;
            _repository = _repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var p = await _repository.GetAllAsync();
                if (p.Status == "Error")
                {
                    return BadRequest(p.ErrorMsg);
                }
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var p = await _repository.GetByIdAsync(id);
                if (p.Status == "Error")
                {
                    return BadRequest(p.ErrorMsg);
                }
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cidade request)
        {
            try
            {
                var p = await _repository.CreateAsync(request);
                if (p.Status == "Error")
                {
                    return BadRequest(p.ErrorMsg);
                }
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Cidade request)
        {
            try
            {
                var p = await _repository.UpdateAsync(id,request);
                if (p.Status == "Error")
                {
                    return BadRequest(p.ErrorMsg);
                }
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var p = await _repository.DeleteAsync(id);
                if (p.Status == "Error")
                {
                    return BadRequest(p.ErrorMsg);
                }
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}