
using Formation.MVC.Models;

namespace Formation.Services
{
    public interface IRestaurantService
    {
        Restaurant Get(string id);
        List<Restaurant> GetAll();
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant newRestaurant);
        void Delete(string id);
    }
}
