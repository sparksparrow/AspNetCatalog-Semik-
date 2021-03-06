﻿using GnomShop.Domain;
using GnomShop.Models;
using GnomShop.Services;
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
        public async Task<IActionResult> Index(
            Guid id, 
            string sortOrder, 
            string currentFilter, 
            string searchString, 
            ushort minValue, 
            ushort maxValue, 
            double[] sizeValues = default, 
            string currentSizeValues = default, 
            ProductItemType[] productItemTypeValues = default,
            string currentproductItemTypeValues = default,
            string[] colorValues = default,
            string currentColorValues = default,
            ushort pageIndex = 0)
        {
            if (id != default)
            {                
                ProductItem productItem = dataManager.ProductItems.GetProductById(id);

                ViewBag.PageTitle = productItem;

                IQueryable<ProductItem> productItems = dataManager.ProductItems.GetProducts();
                return View("Show", await ShowViewModel.CreateAsync(productItem, productItems.AsNoTracking()));
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

            Dictionary<ProductItemType, bool> productItemTypes = dataManager.ProductItems.GetProducts().Select(p => p.ProductItemType).Distinct().OrderBy(p => p).ToDictionary(k => k, v => false);

            Dictionary<string, bool> colors = dataManager.ProductItems.GetProducts().Select(p => p.Color).Distinct().OrderBy(p => p).ToDictionary(k => k, v => false);

            var products = dataManager.ProductItems.GetProducts().Select(p => p);

            return View(await CatalogViewModel.CreateAsync
                (
                new ViewFilter<ProductItem>
                    (
                    searchString, 
                    minValue, 
                    maxValue,
                    CollectionProcessor.GetSelectedProductItemTypeValues(
                        productItemTypes,
                        productItemTypeValues,
                        currentproductItemTypeValues),
                    CollectionProcessor.GetSelectedSizeValues(
                        sizes, 
                        sizeValues, 
                        currentSizeValues),
                    CollectionProcessor.GetSelectedColorValues(
                        colors,
                        colorValues,
                        currentColorValues)                   
                    ),                
                products.AsNoTracking(), 
                pageIndex, 
                sortOrder
                ));
        }
    }
    
}
