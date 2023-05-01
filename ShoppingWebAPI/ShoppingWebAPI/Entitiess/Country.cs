using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.Entitiess
{
    public class Country
    {
        [Display(Name = "País")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] // not null
        public string Name { get; set; }
    }
}
