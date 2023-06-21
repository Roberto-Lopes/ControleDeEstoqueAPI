using ControleDeEstoqueAPI.Data;
using ControleDeEstoqueAPI.Models;
using ControleDeEstoqueAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoqueAPI.Repositories
{
    public class ProdutoRepositorie : IProdutoRepositorie
    {
        private readonly ControleEstoqueDBContext _DBContex;
        public ProdutoRepositorie(ControleEstoqueDBContext controleEstoqueDBContex)
        {
            _DBContex = controleEstoqueDBContex;   
        }
        public async Task<ProdutoModel> BuscarPorId(int id)
        {
            return await _DBContex.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ProdutoModel>> BuscarTodosProdutos()
        {
            return await _DBContex.Produtos.ToListAsync();
        }

        public async Task<ProdutoModel> AdicionarProduto(ProdutoModel produto)
        {
            await _DBContex.Produtos.AddAsync(produto);
            await _DBContex.SaveChangesAsync();

            return produto;
        }

        public async Task<ProdutoModel> AtualizarProdtuo(ProdutoModel produto, int id)
        {
            ProdutoModel produtoPorId = await BuscarPorId(id);

            if(produtoPorId == null)
            {
                throw new Exception($"O produto com id {id} não existe no banco de dados!");
            }

            produtoPorId.Codigo = produto.Codigo;
            produtoPorId.Nome = produto.Nome;
            produtoPorId.Tipo = produto.Tipo;
            produtoPorId.Descrição = produto.Descrição;
            produtoPorId.ValorCompra = produto.ValorCompra;
            produtoPorId.ValorVenda = produto.ValorVenda;

            _DBContex.Produtos.Update(produtoPorId);
            await _DBContex.SaveChangesAsync();

            return produtoPorId;


        }

        public async Task<bool> DeletarProduto(int id)
        {
            ProdutoModel produtoPorId = await BuscarPorId(id);

            if (produtoPorId == null)
            {
                throw new Exception($"O produto com id {id} não existe no banco de dados!");
            }

            _DBContex.Remove(produtoPorId);
            await _DBContex.SaveChangesAsync();

            return true;
        }
    }
}
