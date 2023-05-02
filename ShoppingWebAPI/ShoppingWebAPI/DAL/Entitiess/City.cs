using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entitiess
{
    public class City : Entity
    {

        [Display(Name = "Ciudad")] 
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] 
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "Estado")]
        public State state { get; set; }

        //FK
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public Guid StateId { get; set; }
    }
}
