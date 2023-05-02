using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entitiess
{
    public class Category : Entity
    {

        [Display(Name = "Categoría")] 
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] 
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string? Description { get; set; }
    }
}
