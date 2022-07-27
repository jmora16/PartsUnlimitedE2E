using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Manufacturer
    {
        //Ejemplo de git
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}