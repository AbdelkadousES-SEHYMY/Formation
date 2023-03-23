using Microsoft.Build.Framework;

namespace Formation.MVC.Models
{
    public class Restaurant
    {
        public string? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

        public List<Cuisin>? Cuisins { get; set; }
    }
}
