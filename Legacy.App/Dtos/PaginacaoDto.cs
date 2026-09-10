namespace Legacy.App.Dtos;

public class PaginacaoDto
{
    public IEnumerable<T> Itens { get; set; } = Enumerable.Empty<T>();
    public int PaginaAtual { get; set; }
    public int TamanhoPagina { get; set; }
    public int TotalRegistros { get; set; }
    public int TotalPaginas => (int)Math.Ceiling(TotalRegistros / (double)TamanhoPagina);
}