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
    public class produtoController : ControllerBase
    {
        private readonly IprodutosRepositorio _produtosRepositorio;
        public produtoController(IprodutosRepositorio produtoRepositorio)
        {
            _produtosRepositorio = produtoRepositorio;

        }
        [HttpGet]
        public async Task<ActionResult<List<produtosModel>>> ListarTodosProdutos()
        {
            List<produtosModel> produto = await _produtosRepositorio.ListarTodosProdutos();
            return Ok(produto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<produtosModel>> ProdutosPorId(int id)
        {
            produtosModel funcionario = await _produtosRepositorio.ProdutoPorId(id);
            return Ok(funcionario);
        }

        [HttpPost]
        public async Task<ActionResult<produtosModel>> InserirProduto([FromBody] produtosModel produtoAtual)
        {
            await _produtosRepositorio.InserirProduto(produtoAtual);
            return Ok(produtoAtual);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<produtosModel>> AtualizarProduto([FromBody] produtosModel produtoAtual, int id)
        {
            await _produtosRepositorio.AtualizarProduto(produtoAtual, id);

            return Ok(produtoAtual);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<produtosModel>> ApagarFuncionario(int id)
        {
           bool n = await _produtosRepositorio.ExcluirProduto(id);
           return Ok(n);

        }
    }
}
