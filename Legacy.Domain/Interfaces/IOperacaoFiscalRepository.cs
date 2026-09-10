using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface IOperacaoFiscalRepository
{
    Task<IEnumerable<OperacaoFiscal>> SelecionarTodos();
    Task<OperacaoFiscal?> SelecionarPorId(int id);
}