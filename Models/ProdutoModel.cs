using ControleDeEstoqueAPI.Enums;

namespace ControleDeEstoqueAPI.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descrição { get; set; }
        public TipoProduto Tipo { get; set; }
        public double? ValorCompra { get; set; }
        public double? ValorVenda { get; set; }

    }
}
