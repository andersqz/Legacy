using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> SelecionarTodos(int pagina, int tamanhoPagina);
    Task<Produto?> SelecionarPorId(string id);
    Task<int> ContarTodos();
}