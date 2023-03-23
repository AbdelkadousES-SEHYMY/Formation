using Formation.MVC.Models;

namespace Formation.MVC.Repository
{
    public class Repository
    {
        public static Repository? _instance;
        private Repository()
        {

        }
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>(){
                new Restaurant{Id= Guid.NewGuid().ToString(),Name="R1",PhoneNumber="066665555",Address="Casa"},
                new Restaurant{Id= Guid.NewGuid().ToString(),Name="R2",PhoneNumber="066665555",Address="Casa"},
                new Restaurant{Id=Guid.NewGuid().ToString(),Name="R3",PhoneNumber="066665555",Address="Casa"},
            };

        public static Repository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Repository();
            }
            return _instance;
        }
    }
}
