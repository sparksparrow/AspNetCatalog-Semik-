using GnomShop.Domain;
using GnomShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index(Guid id, string sortOrder, string currentFilter, string searchString, ushort minValue, ushort maxValue, ushort[] sizeValues, ushort pageIndex = 0)
        {
            if (id != default)
            {
                return View("Show", dataManager.ProductItems.GetProductById(id));
            }

            ViewBag.PageTitle = dataManager.Pages.GetPageTitleByCodeWord("PageCatalog");

            if (searchString != null)
            {
                pageIndex = 0;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;
            var products = dataManager.ProductItems.GetProducts().Select(p => p);

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString));           
            }
             
            if (maxValue != default && maxValue>minValue)
            {
                var selectedProducts = products.Where(p => p.TotalPrice >= minValue && p.TotalPrice <= maxValue);
                if (selectedProducts.Any())
                {
                    products = selectedProducts;
                    @ViewData["MinValue"] = minValue;
                    @ViewData["MaxValue"] = maxValue;

                }
                else
                {
                    @ViewData["MinValue"] = minValue;
                    @ViewData["MaxValue"] = null;
                }                
            }

            ViewData["SizeValues"] = dataManager.Sizes.GetSizes().Select(p=>p.SizeValue).Distinct().OrderBy(p => p).ToList();
            
                foreach (double value in sizeValues)
                {
                    products = products.Where(p => p.Sizes.Contains(new Size(value)));
                }

            products = dataManager.ProductItems.GetProducts().Select(p => p);

            return View(await CatalogViewModel.CreateAsync(products.AsNoTracking(), pageIndex, sortOrder));
        }
    }
}
