using AutoBem.Application.Contracts;
using AutoBem.Application.Dtos.Veiculo;
using Microsoft.AspNetCore.Mvc;

namespace AutoBem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        public IVeiculoApplication _veiculoApplication;

        public VeiculosController(IVeiculoApplication veiculoApplication)
        {
            _veiculoApplication = veiculoApplication;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateVeiculoDto viewModel)
        {
            var result = await _veiculoApplication.Adicionar(viewModel);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateVeiculoDto vielmodel)
        {
            var result = await _veiculoApplication.Editar(vielmodel);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _veiculoApplication.Consultar(id));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _veiculoApplication.Consultar());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _veiculoApplication.Excluir(id));
        }
    }
}
