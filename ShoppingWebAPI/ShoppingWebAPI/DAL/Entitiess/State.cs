using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entitiess
{
    public class State : Entity
    {

        [Display(Name = "País")] 
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] 
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "País")]
        public Country country { get; set; }

        [Display(Name = "Id País")]
        public Guid CountryId { get; set; }

        [Display(Name = "Ciudades")]
        public ICollection<City> Cities { get; set; } //Un estado puede tener N ciudades

        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
