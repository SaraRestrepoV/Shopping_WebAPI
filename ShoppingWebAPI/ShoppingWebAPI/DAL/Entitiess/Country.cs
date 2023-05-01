using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entitiess
{
    public class Country : Entity
    {

        [Display(Name = "País")] 
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] 
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }
    }
}
