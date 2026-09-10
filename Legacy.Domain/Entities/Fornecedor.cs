namespace Legacy.Domain.Entities;

public class Fornecedor
{
    public int EmpresaId { get; set; }
    public int FornecedorId { get; set; }
    public string Nome { get; set; }
    public string CpfCnpj { get; set; }
    public string InscricaoEstadual { get; set; }
    public string Telefone { get; set; }    
    public string Email { get; set; }
}