using Microsoft.EntityFrameworkCore;
using WebApiEstoque.Data;
using WebApiEstoque.Models;
using WebApiEstoque.Repositorios.Interfaces;

namespace WebApiEstoque.Repositorios
{
    public class Produtorepositorio : IprodutosRepositorio
    {
        private readonly SistemaApiEstoqueDbContext _Dbcontext;
        public Produtorepositorio(SistemaApiEstoqueDbContext sistemaApiEstoqueDbContext) 
        { 
            _Dbcontext = sistemaApiEstoqueDbContext;
        }

        async Task<List<produtosModel>> IprodutosRepositorio.ListarTodosProdutos()
        {
            return await _Dbcontext.produtos.ToListAsync();
        }

        async Task<produtosModel> IprodutosRepositorio.ProdutoPorId(int id)
        {
            return await _Dbcontext.produtos.FirstOrDefaultAsync(x => x.id == id);
        }

        async Task<produtosModel> IprodutosRepositorio.InserirProduto(produtosModel produto) 
        { 

            await _Dbcontext.produtos.AddAsync(produto);
            await _Dbcontext.SaveChangesAsync();

            return produto;
        }

        async Task<produtosModel> IprodutosRepositorio.AtualizarProduto(produtosModel produto, int id) 
        { 
            produtosModel produtoPorId = await _Dbcontext.produtos.FirstOrDefaultAsync(x => x.id == id);
            if (produtoPorId == null)
            {
                throw new Exception($"Usuario não encontrado para este id {id}!");
            }

            produtoPorId.nome = produto.nome;
            produtoPorId.descricao = produto.descricao;
            produtoPorId.quantidade = produto.quantidade;
            produtoPorId.valor = produto.valor;


            _Dbcontext.produtos.Update(produtoPorId);
            await _Dbcontext.SaveChangesAsync();

            return produtoPorId;
        }

        async Task<bool> IprodutosRepositorio.ExcluirProduto(int id)
        {
            produtosModel produtoPorId = await _Dbcontext.produtos.FirstOrDefaultAsync(x => x.id == id);
            if (produtoPorId == null)
            {
                throw new Exception($"Não encontrado funcionario para o id {id}"!);
            }

            _Dbcontext.produtos.Remove(produtoPorId);
            await _Dbcontext.SaveChangesAsync();

            

            return true;

        }

    }
}
