using WebApiEstoque.Models;

namespace WebApiEstoque.Repositorios.Interfaces
{
    //aqui estão as regras relacionadas a cada entidade
    public interface IprodutosRepositorio
    {
        public Task<List<produtosModel>> ListarTodosProdutos();

        public Task<produtosModel> ProdutoPorId(int id);

        public Task<produtosModel> InserirProduto(produtosModel produto);

        public Task<produtosModel> AtualizarProduto(produtosModel produto, int id);

        public Task<bool> ExcluirProduto(int id);
        
    }
}
