using Legacy.Domain.Entities;

namespace Legacy.Domain.Interfaces;

public interface IPedidoItemRepository
{
    Task<IEnumerable<PedidoItem>> SelecionarPorInfo(int empresa, int local, string serie, int data, int doc);
}