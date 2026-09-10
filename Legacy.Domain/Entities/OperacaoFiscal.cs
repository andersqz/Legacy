namespace Legacy.Domain.Entities;

public class OperacaoFiscal
{
    public int EmpresaId { get; set; }
    public int OperacaoId { get; set; }
    public string Descricao { get; set; } = string.Empty;
}