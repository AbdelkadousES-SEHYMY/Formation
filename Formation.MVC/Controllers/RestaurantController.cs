using Formation.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Formation.MVC.Repository;
using Formation.Services;

namespace Formation.MVC.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;
         List<Restaurant> restaurants;


        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
            restaurants= _restaurantService.GetAll();
        }
        public IActionResult Index()
        {

            var model = restaurants;
            return View(model);
        }
      

        public IActionResult Details(string id)
        {
            var model = _restaurantService.Get(id);
            if (model == null)
                return NotFound();

            return View(model);
        }
        [HttpGet]
        public IActionResult Create() { 
        return View();
                }
        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _restaurantService.Add(restaurant);
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var model = _restaurantService.Get(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _restaurantService.Update(restaurant);
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            _restaurantService.Delete(id);
            return RedirectToAction("Index");

        }

    }
}
