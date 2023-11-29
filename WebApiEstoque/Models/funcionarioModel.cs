using WebApiEstoque.Enums;

namespace WebApiEstoque.Models
{
    public class funcionarioModel
    {
        public int id { get;}
        public string? nome { get; set; }
        public int idade { get; set; }
        public StatusFuncionario funcao { get; set; }
    }
}
