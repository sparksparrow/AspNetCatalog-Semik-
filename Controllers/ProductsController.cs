using GnomShop.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataManager dataManager;

        public ProductsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ProductItems.GetProductById(id));
            }
            ViewBag.PageTitle = dataManager.Pages.GetPageTitleByCodeWord("PageCatalog");
            return View(dataManager.ProductItems.GetProducts());
        }
    }
}
