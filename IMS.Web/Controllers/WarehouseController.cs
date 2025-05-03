using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
