using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using WebApiEstoque.Models;
using WebApiEstoque.Repositorios;
using WebApiEstoque.Repositorios.Interfaces;

namespace WebApiEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class funcionarioController : ControllerBase
    {
        private readonly IfuncionarioRepositorio _funcionaarioRepositorio;
        public funcionarioController(IfuncionarioRepositorio funcionaarioRepositorio)
        {
            _funcionaarioRepositorio = funcionaarioRepositorio;

        }
        [HttpGet]
        public async Task<ActionResult<List<funcionarioModel>>> BuscarTodosFuncionarios()
        {
            List<funcionarioModel> funcionarios = await _funcionaarioRepositorio.BuscaTodosFuncionarios();
            return Ok(funcionarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<funcionarioModel>> BuscarFuncionarioporId(int id)
        {
            funcionarioModel funcionario = await _funcionaarioRepositorio.BuscarFuncionaraioporID(id);
            return Ok(funcionario);
        }

        [HttpPost]
        public async Task<ActionResult<funcionarioModel>> AdicionarFuncionario([FromBody] funcionarioModel funcionarioAtual)
        {
            await _funcionaarioRepositorio.Adicionar(funcionarioAtual);
            return Ok(funcionarioAtual);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<funcionarioModel>> AtualizarFuncionario([FromBody] funcionarioModel funcionarioAtual, int id)
        {
            await _funcionaarioRepositorio.Atualizar(funcionarioAtual, id);

            return Ok(funcionarioAtual);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<funcionarioModel>> ApagarFuncionario(int id)
        {
           bool n = await _funcionaarioRepositorio.Apagar(id);
           return Ok(n);

        }
    }
}
