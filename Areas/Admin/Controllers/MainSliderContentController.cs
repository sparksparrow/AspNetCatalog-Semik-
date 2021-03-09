using GnomShop.Domain;
using GnomShop.Models.DbEntities;
using GnomShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainSliderContentController : Controller
    {
        private readonly DataManager dataManager;
        public MainSliderContentController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(Guid id)
        {
            return View(dataManager.MainSliderContent.GetMainSliderContentById(id));
        }
        [HttpPost]
        public IActionResult Edit(MainSliderContent model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    var ext = Path.GetExtension(titleImageFile.FileName).ToLowerInvariant();

                    if (titleImageFile.Length <= Config.FileSizeLimit && !string.IsNullOrEmpty(ext) && Config.PermittedExtensions.Contains(ext))
                    {
                        model.Extension = ext.Replace(".","");
                        byte[] imageData = null;

                        using (var binaryReader = new BinaryReader(titleImageFile.OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)titleImageFile.Length);
                        }

                        model.Image = imageData;
                    }
                }

                dataManager.MainSliderContent.SaveMainSliderContent(model);
                return RedirectToAction(nameof(IndexMainController.EditMainSliderContent), nameof(IndexMainController).CutController());
            }
            return View(model);
        }
    }
}
