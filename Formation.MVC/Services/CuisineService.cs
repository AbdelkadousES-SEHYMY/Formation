using Formation.MVC.Models;

namespace Formation.MVC.Services
{
    public class CuisineService:ICuisineService
    {
        private List<Cuisin> cuisins = Repository.Repository.GetInstance().Cuisins;
       
       

        public List<Cuisin> GetAllCuisin()
        {
            return cuisins;
        }

        public Cuisin GetCuisin(string Name)
        {
            return cuisins.FirstOrDefault(r => r.Name == Name);
        }
    }
}
