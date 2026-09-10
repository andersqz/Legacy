namespace Legacy.Domain.Interfaces;

public class IClienteRepository
{
    Task<IEnumerable<Cliente>> SelecionarTodos(int pagina, int tamanhoPagina);
    Task<Cliente?> SelecionarPorId(int id);
    Task<int> ContarTodos();
}