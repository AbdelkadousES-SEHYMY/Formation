namespace Formation.MVC.Models
{
    public class RestaurantViewModel
    {
        public Restaurant Restaurant { get; set; } 
        public List<Cuisin>? Cuisins { get; set; }
        public RestaurantViewModel(List<Cuisin> cuisins, Restaurant restaurant)
        {
            Cuisins = cuisins;
            Restaurant = restaurant;
        }

        public RestaurantViewModel()
        {
        }

    }
}
