namespace Legacy.Domain.Entities;

public class SerieFiscal
{
    public int EmpresaId { get; set; } // empresa
    public int LocalId { get; set; } //ser001
    public string Serie { get; set; } = string.Empty; // ser002
    public int UltimoDocEmitido { get; set; } // ser004 int date time
}