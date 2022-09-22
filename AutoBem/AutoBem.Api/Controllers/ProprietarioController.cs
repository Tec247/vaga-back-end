using AutoBem.Application.Contracts;
using AutoBem.Application.Dtos.Proprietario;
using Microsoft.AspNetCore.Mvc;

namespace AutoBem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProprietarioController : ControllerBase
    {
        private IProprietarioApplication _proprietarioApplication;

        public ProprietarioController(IProprietarioApplication proprietarioApplication)
        {
            _proprietarioApplication = proprietarioApplication;
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] CreateProprietarioDto viewModel)
        {
            var result = await _proprietarioApplication.Adicionar(viewModel);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProprietarioDto viewModel)
        {
            var result = await _proprietarioApplication.Editar(viewModel);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _proprietarioApplication.Consultar(id));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this._proprietarioApplication.Consultar());
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            return Ok(await _proprietarioApplication.Excluir(id));
        }

    }
}
