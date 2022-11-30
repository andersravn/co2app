using co2app.Models;
using co2app.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace co2app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemsController : ControllerBase
    {
        private readonly ILogger<FoodItemsController> _logger;
        private readonly FoodService _foodService;

        public FoodItemsController(ILogger<FoodItemsController> logger, FoodService foodService)
        {
            _logger = logger;
            _foodService = foodService;
        }

        [HttpGet]
        public IEnumerable<Food> Get()
        {
            return _foodService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Food> GetFoodItem(int id)
        {
            var foodItem = _foodService.Get(id);

            if (foodItem == null)
            {
                return NotFound();
            }
            return foodItem;
        }
    }
}
