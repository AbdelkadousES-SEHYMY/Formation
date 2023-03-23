
using Formation.MVC.Models;
using Formation.MVC.Repository;

namespace Formation.Services
{
    public class RestaurantService : IRestaurantService
    {
        List<Restaurant> restaurants =Repository.GetInstance().Restaurants;
        public Restaurant Add(Restaurant restaurant)
        {
 
            restaurant.Id= Guid.NewGuid().ToString();
            restaurants.Add(restaurant);
            return Get(restaurant.Id);
        }


        public Restaurant Get(string id) => restaurants.FirstOrDefault(r => r.Id == id);

        public List<Restaurant> GetAll()=> restaurants;

        
        public Restaurant Update(Restaurant newRestaurant)
        {
            var restaurant = Get(newRestaurant.Id);

            if (restaurant != null)
            {
                restaurant.Name = newRestaurant.Name;
                restaurant.Address = newRestaurant.Address;
                restaurant.PhoneNumber = newRestaurant.PhoneNumber;
            }
            return restaurant;
        }
        public void Delete(string id)
        {
            var restaurant = Get(id);
                restaurants.Remove(restaurant);
           
        }
    }
}

