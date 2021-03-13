using GnomShop.Domain;
using Microsoft.AspNetCore.Mvc;

namespace GnomShop.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataManager dataManager;
        public AboutController(DataManager dataManager)
        {
            this.dataManager = dataManager;        }

        public IActionResult Index()
        {
            ViewBag.PageTitle = dataManager.Pages.GetPageTitleByCodeWord("PageAbout");
            return View();
        }
    }
}
