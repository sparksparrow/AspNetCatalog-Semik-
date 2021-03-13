using GnomShop.Domain;
using GnomShop.Models.DbEntities;
using GnomShop.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            ViewBag.dataManager = dataManager;
            ViewBag.Products = dataManager.ProductItems.GetProducts();
            return View(await dataManager.DisplayedProducts.GetDisplayedProductsAsync());
        }
        [HttpPost]
        public IActionResult Edit(DisplayedProducts model)
        {
            if (ModelState.IsValid)
            {
                var existingModel = dataManager.DisplayedProducts.GetDisplayedProducts();
                var arrayProducts = existingModel != null ? JsonConvert.DeserializeObject<List<Guid>>(existingModel) : new List<Guid>();
                model.Products = JsonConvert.SerializeObject(arrayProducts);

                dataManager.DisplayedProducts.SaveDisplayedProducts(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddToDisplayed(Guid guid)
        {
            var model = await dataManager.DisplayedProducts.GetDisplayedProductsAsync();

            var arrayProducts = model.Products != null ? JsonConvert.DeserializeObject<List<Guid>>(model.Products) : new List<Guid>();

            if (!arrayProducts.Contains(guid))
            {
                arrayProducts.Add(guid);
            }
            model.Products = JsonConvert.SerializeObject(arrayProducts);
            dataManager.DisplayedProducts.SaveDisplayedProducts(model);

            ViewBag.Products = dataManager.ProductItems.GetProducts();
            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteDisplayed(Guid guid)
        {
            var model = await dataManager.DisplayedProducts.GetDisplayedProductsAsync();

            var arrayProducts = model.Products != null ? JsonConvert.DeserializeObject<List<Guid>>(model.Products) : new List<Guid>();

            arrayProducts.Remove(guid);
            model.Products = JsonConvert.SerializeObject(arrayProducts);
            dataManager.DisplayedProducts.SaveDisplayedProducts(model);

            ViewBag.Products = dataManager.ProductItems.GetProducts();
            return View("Edit", model);
        }       
        
    }
}
