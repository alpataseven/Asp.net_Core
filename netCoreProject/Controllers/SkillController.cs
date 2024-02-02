using Microsoft.AspNetCore.Mvc;

namespace netCoreProject.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
