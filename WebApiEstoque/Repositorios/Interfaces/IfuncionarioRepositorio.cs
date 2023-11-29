using WebApiEstoque.Models;

namespace WebApiEstoque.Repositorios.Interfaces
{
    //aqui estão as regras relacionadas a cada entidade
    public interface IfuncionarioRepositorio
    {
        public Task<List<funcionarioModel>> BuscaTodosFuncionarios();

        public Task<funcionarioModel> BuscarFuncionaraioporID(int id);

        public Task<funcionarioModel> Adicionar(funcionarioModel funcionario);

        public Task<funcionarioModel> Atualizar(funcionarioModel funcionario, int id);

        public Task<bool> Apagar(int id);
        
    }
}
