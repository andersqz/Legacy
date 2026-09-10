using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface IProdutoFiscalRepository
{
    Task<ProdutoFiscal?> SelecionarPorId(string id);
}