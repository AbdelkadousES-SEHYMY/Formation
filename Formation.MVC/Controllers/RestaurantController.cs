using Formation.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Formation.MVC.Repository;
using Formation.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Formation.MVC.Services;

namespace Formation.MVC.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        private readonly ICuisineService _cuisineService;
        List<Restaurant> restaurants;


        public RestaurantController(IRestaurantService restaurantService,ICuisineService cuisineService)
        {
            _restaurantService = restaurantService;
            _cuisineService = cuisineService;
            restaurants = _restaurantService.GetAll();
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
            var cuisins = _cuisineService.GetAllCuisin();

            var model = new RestaurantViewModel(cuisins, new Restaurant());
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(RestaurantViewModel restaurantVM)
        {

            if (ModelState.IsValid)
            {

                _restaurantService.Add(restaurantVM.Restaurant);
                return RedirectToAction("Index");
            }
            return View();
            //var cuisin = _cuisineService.GetCuisin(Request.Form["Restaurant.Cuisines"].FirstOrDefault());
            //restaurantVM.Cuisins = _cuisineService.GetAllCuisin();
            //restaurantVM.Restaurant.Cuisins.Add(cuisin);
            //_restaurantService.Add(restaurantVM.Restaurant);
            //TempData["message"] = "Created Succesfully";
            //return RedirectToAction("Details", new { id = restaurantVM.Restaurant.Id });


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
