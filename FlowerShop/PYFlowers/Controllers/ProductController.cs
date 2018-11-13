using Microsoft.AspNetCore.Mvc;
using PYFlowers.Models;
using System.Linq;
using PYFlowers.Models.ViewModels;

namespace PYFlowers.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult List(string category, int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.Category)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                },
                CurrentCategory = category
            });

        [HttpGet]
        public IActionResult FormFill()
        {
            return View();
        }
        [HttpPost]
        public ViewResult FormFill(Product product)
        {
            if (ModelState.IsValid)
            {
                Product prod = new Product();
                prod.Name = product.Name;
                prod.Category = product.Category;
                prod.Price = product.Price;
                prod.Description = product.Description;
                prod.Stock = product.Stock;
                prod.Wrap = product.Wrap;
                prod.Gift = product.Gift;
                ProductRepository.AddProduct(prod);
                return View("FormFillSuccess", prod);
            }
            else
            {
                return View();
            }
        }

    }
}