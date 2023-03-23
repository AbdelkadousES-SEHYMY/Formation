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
                new Restaurant{Id= Guid.NewGuid().ToString(),Name="R1",PhoneNumber="066665555",Address="Casa",
                     },
                new Restaurant{Id= Guid.NewGuid().ToString(),Name="R2",PhoneNumber="066665555",Address="Casa",
         },
                new Restaurant{Id=Guid.NewGuid().ToString(),Name="R3",PhoneNumber="066665555",Address="Casa",},
            };
        public List<Cuisin> Cuisins { get; set; } = new List<Cuisin>()
        {
            new Cuisin { Name = "French", Description = "French cuisine", Country = "France" },
        new Cuisin { Name = "Italian", Description = "Italian cuisine", Country = "Italy" },
        new Cuisin { Name = "Japanese", Description = "Japanese cuisine", Country = "Japan" },
        new Cuisin { Name = "Mexican", Description = "Mexican cuisine", Country = "Mexico" }
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
