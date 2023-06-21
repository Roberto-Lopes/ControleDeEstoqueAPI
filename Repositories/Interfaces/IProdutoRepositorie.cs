using ControleDeEstoqueAPI.Models;

namespace ControleDeEstoqueAPI.Repositories.Interfaces
{
    public interface IProdutoRepositorie
    {

        Task<List<ProdutoModel>> BuscarTodosProdutos();

        Task<ProdutoModel> BuscarPorId(int id);

        Task<ProdutoModel> AdicionarProduto(ProdutoModel produto);

        Task<ProdutoModel> AtualizarProdtuo(ProdutoModel produto, int id);

        Task<bool> DeletarProduto(int id);

    }
}
