using lr8.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr8.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var products = GenerateProductList();
            return View(products);
        }

        private List<Product> GenerateProductList()
        {
            var productList = new List<Product>();

            var random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                var name = "Product " + i;
                var price = Math.Round((decimal)(random.NextDouble() * 100), 2);
                var createdDate = DateTime.Now.AddDays(-random.Next(1, 30)).Date;

                productList.Add(new Product { ProductID = i, ProductName = name, ProductPrice = price, ProductCreatedDate = createdDate });
            }

            return productList;
        }

    }
}

