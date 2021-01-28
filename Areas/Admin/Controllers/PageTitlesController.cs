using GnomShop.Domain;
using GnomShop.Models;
using GnomShop.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageTitlesController : Controller
    {        
        private readonly DataManager dataManager;
        public PageTitlesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.Pages.GetPageTitleByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(PageTitle model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Pages.SavePageTitle(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
