using Microsoft.AspNetCore.Mvc;
using AttributeRouting_MVC_App.Models;

namespace AttributeRouting_MVC_App.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){Id=1,Name="Laptop",Price=80000,Stock=10},
            new Product(){Id=2,Name="Tablet",Price=45000,Stock=15},
            new Product(){Id=3,Name="Smartphone",Price=30000,Stock=25},
            new Product(){Id=4,Name="Smartwatch",Price=15000,Stock=30},
        };
        [Route("ShowProducts")]
        public IActionResult Index()
        {
            return View(products);
        }
        [Route("AddProduct")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Route("AddProduct")]
        public IActionResult Create(Product product)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }
            products.Add(product);
            return RedirectToAction("Index");
        }
        [Route("ProductDetails/{id}")]
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        [Route("EditProduct/{id}")]
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        [Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

    }
}
