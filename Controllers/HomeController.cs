using GnomShop.Domain;
using GnomShop.Models;
using GnomShop.Models.DbEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager dataManager;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager )
        {
            _logger = logger;
            this.dataManager = dataManager;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.PageTitle = dataManager.Pages.GetPageTitleByCodeWord("PageIndex");
            return View(new IndexViewModel(
                dataManager.MainSliderContent.GetMainSliderContents(),
                await dataManager.CategoriesOfTheMonth.GetCategoriesOfTheMonthAsync(),
                await dataManager.DisplayedProducts.GetDisplayedProductsAsync()
                ));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
