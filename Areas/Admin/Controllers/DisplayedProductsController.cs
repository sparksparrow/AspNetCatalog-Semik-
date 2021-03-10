using GnomShop.Domain;
using GnomShop.Models.DbEntities;
using GnomShop.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DisplayedProductsController : Controller
    {
        private readonly DataManager dataManager;
        public DisplayedProductsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public async Task<IActionResult> Edit()
        {
            return View(await dataManager.DisplayedProducts.GetDisplayedProductsAsync());
        }
        [HttpPost]
        public IActionResult Edit(DisplayedProducts model)
        {
            if (ModelState.IsValid)
            {               
                dataManager.DisplayedProducts.SaveDisplayedProducts(model);
                return RedirectToAction(nameof(MainSliderContentController.EditMainSliderContent), nameof(MainSliderContentController).CutController());
            }
            return View(model);
        }
    }
}
