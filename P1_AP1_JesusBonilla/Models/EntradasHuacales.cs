using System.ComponentModel.DataAnnotations;

namespace P1_AP1_JesusBonilla.Models;

public class EntradasHuacales
{
    [Key]
    public int EntradaId { get; set; }
    [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
    [MaxLength(100)]
    public string NombreCliente { get; set; }
    [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
    [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser menor a 0")]
    public int Cantidad { get; set; }
    [Required(ErrorMessage = "El campo Precio es obligatorio")]
    [Range(0, int.MaxValue, ErrorMessage = "El precio no puede ser menor a 0")]
    public double Precio { get; set; }
    [Required(ErrorMessage = "La fecha es obligatoria")]
    public DateTime Fecha { get; set; }
}
