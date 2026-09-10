using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface IVendedorRepository
{
    Task<IEnumerable<Vendedor>> SelecionarTodos();
    Task<Vendedor?> SelecionarPorId(int id);
}