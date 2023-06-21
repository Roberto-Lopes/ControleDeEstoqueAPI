using System.ComponentModel;

namespace ControleDeEstoqueAPI.Enums
{
    public enum TipoProduto
    {
        [Description("Acessário")]
        Acessorio = 1,
        [Description("Peças")]
        Peca = 2,
        [Description("Lubrificantes")]
        Lubrificantes = 3,
        [Description("Químicos")]
        Quimicos = 4
    }
}
