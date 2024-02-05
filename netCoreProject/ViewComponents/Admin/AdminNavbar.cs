using Microsoft.AspNetCore.Mvc;

namespace netCoreProject.ViewComponents.Admin
{
    public class AdminNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
