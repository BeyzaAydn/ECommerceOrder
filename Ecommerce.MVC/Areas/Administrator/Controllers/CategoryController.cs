using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        //todo: ICategoryService içerisinde bulunan GetActiveCategories isimli metot tarafından iletilen veriler index sayfasında gösterilecek.

        public CategoryController(ICategoryService categoryService,IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService
                .GetAllCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryListViewModel
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }


        //todo: Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {

            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    CategoryName = categoryViewModel.CategoryName,
                    Description = categoryViewModel.Description,
                };

             string result=await _categoryService.CreateCategory(category);
                TempData["Result"] = result;
                return RedirectToAction("Index", "Home");

            }
            else
            {
           
                return View(categoryViewModel);
            }
        }


        //todo: Update
        public IActionResult Update(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                IsActive = category.IsActive,
                Status = category.Status
            };
            if (categoryListViewModel != null)
            {
                return View(categoryListViewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryListViewModel category)
        {
            if (ModelState.IsValid)
            {
                Category updated = new Category
                {
                    ID = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                    IsActive = category.IsActive,
                    Status = category.Status
                };

              var result=await  _categoryService.UpdateCategory(updated);
                TempData["Result"] = result;
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
           
        }

        //todo: Details / Details içerisinde o category'e bağlı ürünler listelensin.
        public IActionResult Details(int id)
        
        {
            //var category = _categoryService.GetCategoryById(id);

            /// var products = new List<CategoryProductsViewModel>();
            /// 
            var products = _productService.GetProductByCategoryId(id);

            if (products.Count > 0)
            {
                return View();
            }
            return View();
            //if (category != null)
            //{
            //    //var products = category.Products.Where(x => x.CategoryId == id).Select(x => new CategoryProductsViewModel()
            //    //{
            //    //    Id = x.ID,
            //    //    UnitPrice = x.UnitPrice,
            //    //    UnitsInStock = x.UnitsInStock,
            //    //    ImagePath = x.ImagePath,
            //    //    Status = x.Status,
            //    //    IsActive = x.IsActive,
            //    //    ProductName=x.ProductName,

            //    //}).ToList();

            //    var products = category.Products.ToList();
            //    return View(products);
            //}
            //else
            //{
            //    return View();
            //}

            
        }

        //todo: GetPassiveCategories

        //todo: Destroy

        //todo: Delete

    }
}
