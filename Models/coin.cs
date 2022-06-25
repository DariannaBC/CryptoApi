using System.ComponentModel.DataAnnotations;

public class coin
{
    [Key]
    public int MonedaId { get; set; }
    public string? Descripcion { get; set; }
    public double? Valor { get; set; }
    public string? ImageUrl { get; set; }
    
    public coin (){}
}