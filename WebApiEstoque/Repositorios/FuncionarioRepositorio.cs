using Microsoft.EntityFrameworkCore;
using WebApiEstoque.Data;
using WebApiEstoque.Models;
using WebApiEstoque.Repositorios.Interfaces;

namespace WebApiEstoque.Repositorios
{
    public class FuncionarioRepositorio : IfuncionarioRepositorio
    {
        private readonly SistemaApiEstoqueDbContext _Dbcontext;
        public FuncionarioRepositorio(SistemaApiEstoqueDbContext sistemaApiEstoqueDbContext)
        {
            _Dbcontext = sistemaApiEstoqueDbContext;
        }

        async Task<List<funcionarioModel>> IfuncionarioRepositorio.BuscaTodosFuncionarios()
        {
            return await _Dbcontext.funcionario.ToListAsync();
        }

        async Task<funcionarioModel> IfuncionarioRepositorio.BuscarFuncionaraioporID(int id)
        {
            return await _Dbcontext.funcionario.FirstOrDefaultAsync(x => x.id == id);
        }

        async Task<funcionarioModel> IfuncionarioRepositorio.Adicionar(funcionarioModel funcionario)
        {

            await _Dbcontext.funcionario.AddAsync(funcionario);
            await _Dbcontext.SaveChangesAsync();

            return funcionario;
        }

        async Task<funcionarioModel> IfuncionarioRepositorio.Atualizar(funcionarioModel funcionario, int id)
        {
            funcionarioModel usuarioPorId = await _Dbcontext.funcionario.FirstOrDefaultAsync(x => x.id == id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario não encontrado para este id {id}!");
            }

            usuarioPorId.nome = funcionario.nome;
            usuarioPorId.idade = funcionario.idade;
            usuarioPorId.funcao = funcionario.funcao;

            _Dbcontext.funcionario.Update(usuarioPorId);
            await _Dbcontext.SaveChangesAsync();

            return usuarioPorId;
        }

        async Task<bool> IfuncionarioRepositorio.Apagar(int id)
        {
            funcionarioModel funcionarioPorId = await _Dbcontext.funcionario.FirstOrDefaultAsync(x => x.id == id);
            if (funcionarioPorId == null)
            {
                throw new Exception($"Não encontrado funcionario para o id {id}"!);
            }

            _Dbcontext.funcionario.Remove(funcionarioPorId);
            await _Dbcontext.SaveChangesAsync();



            return true;

        }
    }
}
