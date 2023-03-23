using System.ComponentModel.DataAnnotations;

namespace Formation.MVC.Models
{
    public class Cuisin
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
