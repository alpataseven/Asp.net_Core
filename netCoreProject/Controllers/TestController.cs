using Microsoft.AspNetCore.Mvc;

namespace netCoreProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
