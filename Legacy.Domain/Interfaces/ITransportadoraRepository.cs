using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface ITransportadoraRepository
{
    Task<IEnumerable<Transportadora>> SelecionarTodos();
    Task<Transportadora> SelecionarPorId(int id);
}