using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Interfaces.Services;
using WebSupplier.Domain.Models;
using WebSupplier.WebApp.Extensions;
using WebSupplier.WebApp.Models;
using WebSupplier.WebApp.Models.Category;
using WebSupplier.WebApp.Models.Product;
using WebSupplier.WebApp.Models.Supplier;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSupplier.WebApp.Controllers
{
    [Route("products")]
    public class ProductController : MainController
    {
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        private readonly ICategoryService _categoryService;
        private readonly IImageService _imageService;
        public ProductController(INotificationService notificationService,
                                    IMapper mapper,
                                    IProductService productService,
                                    ISupplierService supplierService,
                                    ICategoryService categoryService, 
                                    IImageService imageService)
                                    : base(notificationService, mapper)
        {
            _productService = productService;
            _supplierService = supplierService;
            _categoryService = categoryService;
            _imageService = imageService;
        }

        [AllowAnonymous]
        [HttpGet("all-products")]
        public async Task<IActionResult> Index(int pageSize = 10, int pageIndex = 1, string query = null)
        {
            var result = await _productService.Pagination(pageIndex, pageSize, query);

            result.Query = query;
            result.ReferenceAction = "Index";

            return View(_mapper.Map<PaginationViewModel<ProductViewModel>>(result));
        }

        [ClaimsAuthorizeAttribute("Product", "New")]
        [HttpGet("new-product")]
        public async Task<IActionResult> New()
        {

            return View(await PopulationSupplierAndCategory(new NewProductViewModel()));
        }

        [ClaimsAuthorizeAttribute("Product", "New")]
        [HttpPost("new-product")]
        public async Task<IActionResult> New(NewProductViewModel viewModel)
        {
            if (viewModel.Images.Count == 0)
                _imageService.StoreImageTemporary(viewModel.ImageOne, viewModel.ImageTwo, viewModel.ImageTree, viewModel.ImageFor, viewModel.ImageFive)
                    .ForEach(x => viewModel.Images.Add(new NewImageViewModel() { ImagePath = x }));

            if (!ModelState.IsValid) return View(await PopulationSupplierAndCategory(viewModel));

            await _productService.Insert(_mapper.Map<Product>(viewModel));

            if (OperationValid()) return View(await PopulationSupplierAndCategory(viewModel));

            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        [HttpGet("new-product/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var result = await _productService.FindById(id);

            if (OperationValid())
            {
                TempData["Error"] = "Product not found.";
                return RedirectToAction(nameof(Index));
            }

            return View(_mapper.Map<ProductViewModel>(result));
        }

        [ClaimsAuthorizeAttribute("Product", "Edit")]
        [HttpGet("edit-product/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var result = await _productService.FindById(id);

            if (OperationValid())
            {
                TempData["Error"] = "Product not found.";
                return RedirectToAction(nameof(Index));
            }

            return View(await PopulationSupplierAndCategory(_mapper.Map<EditProductViewModel>(result)));
        }

        [ClaimsAuthorizeAttribute("Product", "Edit")]
        [HttpPost("edit-product/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id, EditProductViewModel viewModel)
        {
            if (id != viewModel.Id) return BadRequest();
            if (viewModel.Images.Count == 0)
                _imageService.StoreImageTemporary(viewModel.ImageOne, viewModel.ImageTwo, viewModel.ImageTree, viewModel.ImageFor, viewModel.ImageFive)
                    .ForEach(x => viewModel.Images.Add(new EditImageViewModel() { ImagePath = x }));

            if (!ModelState.IsValid) return View(await PopulationSupplierAndCategory(viewModel));

            await _productService.Update(_mapper.Map<Product>(viewModel));

            if (OperationValid()) return View(await PopulationSupplierAndCategory(viewModel));

            TempData["Success"] = "Product edited successfully.";
            return RedirectToAction(nameof(Edit), _mapper.Map<EditProductViewModel>(await _productService.FindById(id)));
        }

        [ClaimsAuthorizeAttribute("Product", "Delete")]
        [HttpGet("delete-product/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var result = await _productService.FindById(id);

            if (OperationValid())
            {
                TempData["Error"] = "Product not found.";
                return RedirectToAction(nameof(Index));
            }

            return View(_mapper.Map<ProductViewModel>(result));
        }

        [ClaimsAuthorizeAttribute("Product", "Delete")]
        [HttpPost("delete-product")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            await _productService.Delete(id);

            if (OperationValid())
            {                
                return View(nameof(Delete), _mapper.Map<ProductViewModel>(await _productService.FindById(id)));
            }

            TempData["Success"] = "Registration excluded with success.";
            return RedirectToAction(nameof(Index));
        }

        private async Task<NewProductViewModel> PopulationSupplierAndCategory(NewProductViewModel viewModel)
        {
            viewModel.ListSupplier = _mapper.Map<IEnumerable<SupplierViewModel>>(await _supplierService.ToList());
            viewModel.ListCategory = _mapper.Map<IEnumerable<CategoryViewModel>>(await _categoryService.ToList());

            return viewModel;
        }

        private async Task<EditProductViewModel> PopulationSupplierAndCategory(EditProductViewModel viewModel)
        {
            viewModel.ListSupplier = _mapper.Map<IEnumerable<SupplierViewModel>>(await _supplierService.ToList());
            viewModel.ListCategory = _mapper.Map<IEnumerable<CategoryViewModel>>(await _categoryService.ToList());

            return viewModel;
        }
    }
}
