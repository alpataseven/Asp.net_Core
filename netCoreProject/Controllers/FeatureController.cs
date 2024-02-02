using Microsoft.AspNetCore.Mvc;

namespace netCoreProject.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
