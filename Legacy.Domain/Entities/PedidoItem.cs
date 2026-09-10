namespace Legacy.Domain.Entities;

public class PedidoItem
{
    public int EmpresaId { get; set; }
    public int LocalId { get; set; }
    public string Serie { get; set; }
    public int DataEmissao { get; set; }
    public int Documento { get; set; }
    public string ProdutoId { get; set; }
    public int SequenciaItem { get; set; }
    public int TipoProduto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public double PercDesconto { get; set; }
    public decimal ValorDesconto { get; set; }
    public double PercAcrescimo { get; set; }
    public decimal ValorAcrescimo { get; set; }
}