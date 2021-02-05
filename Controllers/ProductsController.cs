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
        public async Task<IActionResult> Index(Guid id, string sortOrder, string currentFilter, string searchString, ushort pageIndex = 0)
        {
            if (id != default)
            {
                return View("Show", dataManager.ProductItems.GetProductById(id));
            }          

            if (searchString != null)
            {
                pageIndex = 0;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var products = dataManager.ProductItems.GetProducts().Select(p => p);

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString));           
            }
           
            switch (sortOrder)
            {
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price * (1 - p.Discount * 0.01));
                    break;
                case "price_asc":
                    products = products.OrderBy(p => p.Price * (1 - p.Discount * 0.01));
                    break;
                case "discount_desc":
                    products = products.OrderByDescending(p => p.Discount);
                    break;
                default:
                    products = products.OrderByDescending(p => p.DateAdded);                    
                    break;
            }
          
            ViewBag.PageTitle = dataManager.Pages.GetPageTitleByCodeWord("PageCatalog");

            int pageSize = 4;
            
            return View(await PaginatedList<ProductItem>.CreateAsync(products.AsNoTracking(), pageIndex, pageSize));
        }
    }
}
