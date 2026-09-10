using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface ISerieFiscalRepository
{
    Task<IEnumerable<SerieFiscal>> SelecionarTodos();
    Task<SerieFiscal?> SelecionarPorSerie(string serie);
}