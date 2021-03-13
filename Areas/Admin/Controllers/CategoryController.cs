using GnomShop.Domain;
using GnomShop.Models.DbEntities;
using GnomShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GnomShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly DataManager dataManager;
        public CategoryController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(Guid id)
        {
            return View( dataManager.Category.GetCategoryById(id));
        }
        [HttpPost]
        public IActionResult Edit(Category model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                var tupleExtImg = ImageValidator.ValidateImg(titleImageFile);

                if (tupleExtImg != default)
                {
                    model.Extension = tupleExtImg.Item1;
                    model.Image = tupleExtImg.Item2;
                }

                dataManager.Category.SaveCategory(model);
                return RedirectToAction(nameof(CategoriesOfTheMonthController.Edit), nameof(CategoriesOfTheMonthController).CutController());
            }
            return View(model);
        }
    }
}
