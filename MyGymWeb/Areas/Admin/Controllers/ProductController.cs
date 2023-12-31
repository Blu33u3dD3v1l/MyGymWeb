﻿using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;

namespace MyGymWeb.Areas.Admin.Controllers
{
       
    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
            => productService = _productService;

        [HttpGet]

        public async Task<IActionResult> ManageProduct()
        {
            var p = await productService.GetAllProductsAsync();           
            return View(p);

        }

        [HttpGet]
        public IActionResult Add()
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                var model = new AddProductValidationModel();
                return View(model);
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductValidationModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.productService.AddProductsAsync(model);
                TempData[SuccessMessage] = "You Successfuly added a product!";

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("ManageProduct", "Product", "Admin");


        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                var model = await productService.GetEditProductAsync(id);
                return View(model);
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TestViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.productService.EditByIdAsync(id, model);
                TempData[SuccessMessage] = "You Successfuly edited a product!";

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }

            return RedirectToAction("ManageProduct", "Product", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                await productService.DeleteProductAsync(id);
                TempData[WarningMessage] = "You Successfuly deleted a product!";
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }
         
            return RedirectToAction("ManageProduct", "Product", "Admin");
        }
    }
}
