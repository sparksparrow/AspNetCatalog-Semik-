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
        public IActionResult EditMainSliderContent()
        {
            return View(dataManager.MainSliderContent.GetMainSliderContents());
        }
        public IActionResult Edit(Guid id)
        {
            return View(dataManager.MainSliderContent.GetMainSliderContentByIdAsNoTracking(id));
        }
        [HttpPost]
        public IActionResult Edit(MainSliderContent model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                var tupleExtImg = ImageValidator.ValidateImg(titleImageFile);

                if(tupleExtImg!=default)
                {
                    model.Extension = tupleExtImg.Item1;
                    model.Image = tupleExtImg.Item2; 
                }    

                dataManager.MainSliderContent.SaveMainSliderContent(model);
                return RedirectToAction(nameof(MainSliderContentController.EditMainSliderContent), nameof(MainSliderContentController).CutController());
            }
            return View(model);
        }
    }
}
