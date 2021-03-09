using GnomShop.Domain;
using GnomShop.Models;
using GnomShop.Models.DbEntities;
using GnomShop.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GnomShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IndexMainController : Controller
    {
        private readonly DataManager dataManager;
        public IndexMainController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult EditMainSliderContent()
        {
            return View(dataManager.MainSliderContent.GetMainSliderContents());
        }

        public async Task<IActionResult> EditCategoriesOfTheMonth()
        {
            return View(await dataManager.CategoriesOfTheMonth.GetCategoriesOfTheMonthAsync());
        }

        [HttpPost]
        public IActionResult EditCategoriesOfTheMonth(CategoriesOfTheMonth model)
        {
            if (ModelState.IsValid)
            {
                dataManager.CategoriesOfTheMonth.SaveCategoriesOfTheMonth(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        public async Task<IActionResult> EditDisplayedProducts()
        {
            return View(await dataManager.DisplayedProducts.GetDisplayedProductsAsync());
        }

        [HttpPost]
        public IActionResult EditDisplayedProducts(DisplayedProducts model)
        {
            if (ModelState.IsValid)
            {
                dataManager.DisplayedProducts.SaveDisplayedProducts(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
