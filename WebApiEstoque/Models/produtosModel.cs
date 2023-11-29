using CoPilot;
namespace WebApiEstoque.Models
{
    public class produtosModel
    {
        public int id { get; }
        public string? nome{ get; set; }
        public string? descricao { get; set; }
        public int quantidade { get; set; }
        public int valor { get; set; }

   
       

    }
}
