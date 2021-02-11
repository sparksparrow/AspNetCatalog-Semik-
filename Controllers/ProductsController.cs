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
        public async Task<IActionResult> Index(Guid id, string sortOrder, string currentFilter, string searchString, ushort minValue, ushort maxValue, double[] sizeValues = default, string currentSizeValues = default, ushort pageIndex = 0)
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

            ViewData["CurrentSort"] = sortOrder;            

            Dictionary<double, bool> sizes = dataManager.Sizes.GetSizes().Select(p => p.SizeValue).Distinct().OrderBy(p => p).ToDictionary(k => k, v => false);

            if (sizeValues.Any())
            {
                sizes = sizes.Select(s => sizeValues.Contains(s.Key) ? new KeyValuePair<double, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
            else
            {
                if (currentSizeValues != default)
                {
                    List<double> listOfSizes = new List<double>();
                    foreach(var size in currentSizeValues.Split(","))
                    {
                        double result = default;
                        if(double.TryParse(size,out result))
                        {
                            listOfSizes.Add(result);
                        }
                    }
                    sizes = sizes.Select(s => listOfSizes.Contains(s.Key) ? new KeyValuePair<double, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
                }
            }

            var products = dataManager.ProductItems.GetProducts().Select(p => p);

            return View(await CatalogViewModel.CreateAsync
                (
                new ViewFilter<ProductItem>
                    (
                    searchString, 
                    minValue, 
                    maxValue,
                    sizes
                    ),
                products.AsNoTracking(), 
                pageIndex, 
                sortOrder
                ));
        }
    }
    
}
