using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class coin
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int? MonedaId { get; set; }
    public string? Descripcion { get; set; }
    public double? Valor { get; set; }
    public string? ImageUrl { get; set; }
    
    public coin (){}
}