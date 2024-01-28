using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace netCoreProject.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
