using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.Entitiess
{
    public class Entitycs
    {
        [Key] //DataAnnotations - decoradores
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; } //? Puede ser nulo
        public DateTime? ModifiedDate { get; set; }
    }
}
