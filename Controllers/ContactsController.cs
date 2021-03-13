using GnomShop.Domain;
using Microsoft.AspNetCore.Mvc;

namespace GnomShop.Controllers
{
    public class ContactsController : Controller
    {
        private readonly DataManager dataManager;

        public ContactsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            ViewBag.PageTitle = dataManager.Pages.GetPageTitleByCodeWord("PageContacts");
            return View();
        }
    }
}
