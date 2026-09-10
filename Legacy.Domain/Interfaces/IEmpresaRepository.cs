using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface IEmpresaRepository
{
    Task<IEnumerable<Empresa>> SelecionarTodos();
    Task<Empresa?> SelecionarPorId(int id);
}