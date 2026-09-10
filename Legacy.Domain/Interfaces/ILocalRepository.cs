using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface ILocalRepository
{
    Task<IEnumerable<Local>> SelecionarTodos();
    Task<Local?> SelecionarPorId(int id);
}