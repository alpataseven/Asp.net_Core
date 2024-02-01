using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace netCoreProject.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
