using GnomShop.Domain;
using GnomShop.Models;
using GnomShop.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GnomShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly string[] permittedExtensions = { ".png", ".jpg", ".jpeg" };
        private readonly DataManager dataManager;

        public string GetImagesDirectory { get; private set; }

        public ProductsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ProductItem() : dataManager.ProductItems.GetProductById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(ProductItem model, IEnumerable<IFormFile> titleImageFiles, List<double?> sizeValues)
        {            
            if (ModelState.IsValid)
            {
                if(sizeValues != null)
                {
                    sizeValues = sizeValues.Distinct().Where(x => x != null && x>=0 && x<=300).ToList();
                    sizeValues.Sort();

                    foreach ( var size in sizeValues)
                    {                        
                            model.Sizes.Add(new Size(size.GetValueOrDefault()));                        
                    }
                }
                if (titleImageFiles != null && titleImageFiles.Any())
                {
                    foreach (var img in titleImageFiles)
                    {
                        var ext = Path.GetExtension(img.FileName).ToLowerInvariant();

                        if (img.Length > Config.FileSizeLimit || string.IsNullOrEmpty(ext) || !permittedExtensions.Contains(ext))
                            continue;

                        model.Images.Add(new Image(img.FileName));  

                        using (var stream = new FileStream(
                                Path.Combine
                                    (
                                    FileSystemApi.CreateTempDirectory(),
                                    img.FileName
                                    ),
                                FileMode.Create))
                            {
                                img.CopyTo(stream);
                            }                        
                    }
                }
                dataManager.ProductItems.SaveProductItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ProductItems.DeleteProduct(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
