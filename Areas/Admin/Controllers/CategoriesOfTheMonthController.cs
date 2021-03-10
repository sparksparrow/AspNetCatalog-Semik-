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
    public class CategoriesOfTheMonthController : Controller
    {
        private readonly DataManager dataManager;
        public CategoriesOfTheMonthController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public async Task<IActionResult> Edit()
        {
            return View(await dataManager.CategoriesOfTheMonth.GetCategoriesOfTheMonthAsync());
        }
        [HttpPost]
        public IActionResult Edit(CategoriesOfTheMonth model)
        {
            if (ModelState.IsValid)
            {                
                dataManager.CategoriesOfTheMonth.SaveCategoriesOfTheMonthAsync(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }

}
