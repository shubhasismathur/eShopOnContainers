using Microsoft.AspNetCore.Mvc;

namespace ProductInfo.Controllers
{
    [Route("api/[controller]")]
    public class ProductDetailsController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Content("This is a dummy string.");
        }

    }
}
