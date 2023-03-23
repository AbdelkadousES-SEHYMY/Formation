using Formation.MVC.Models;

namespace Formation.MVC.Services
{
    public interface ICuisineService
    {
        public List<Cuisin> GetAllCuisin();
        public Cuisin GetCuisin(string Name);
    }
}
