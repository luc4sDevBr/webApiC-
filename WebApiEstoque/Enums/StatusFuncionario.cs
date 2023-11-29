using System.ComponentModel;

namespace WebApiEstoque.Enums
{
    public enum StatusFuncionario
    {
        [Description("Vendedor")]
        vendedor = 1,
        [Description("Caixa")]
        caixa = 2,
        [Description("Gerente")]
        gerente = 3,
        [Description("Presidente")]
        presidente = 4
    }
}
