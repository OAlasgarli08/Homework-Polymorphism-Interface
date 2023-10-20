using Service.Services;
using Service.Services.Interfaces;

namespace Classwork.Controllers
{
    public class ProductController
    {
        private readonly IProductService _productService;
        
        public ProductController()
        {
            _productService = new ProductService();
        }
        public void CountOfProduct()
        {
            var products = _productService.GetAll().Length;
            Console.WriteLine(products);
        }

        public void SearchOfProducts()
        {

            Console.WriteLine("Search up the product:");
            var result = Console.ReadLine();

            var products = _productService.SearchOfProduct(result);

            if (products.Name == result)
            {
                Console.WriteLine(result);
            }
            else{ Console.WriteLine("Product does not exist"); }
            
            if (products.Name == null)
            {
                Console.WriteLine("Write in something");
            }

        }

        public void InformationOfProducts()
        {
            Console.WriteLine("Type in name of product:");
            var result = Console.ReadLine();

            var products = _productService.ShowInformationOfProduct(result);

            if (products.Name == result)
            {
                Console.WriteLine(products.Name + "---" + products.Price + "---" + products.CreatedDate + "---" + products.Category);
            }
            else { Console.WriteLine("Product does not exist"); }

            if (result == null)
            {
                Console.WriteLine("Type in Something");
            }
        }

        public void AveragePrice()
        {
            var products = _productService.GetAll();
            
            var SumOfProducts = products.Sum(m => m.Price);

            Console.WriteLine(SumOfProducts/products.Length);
        }

        public void SortByDate()
        {
            Console.WriteLine("Write sort Text:");
            string sortDate = Console.ReadLine();
            
            var result = _productService.OrderByDate(sortDate);

            foreach(var product in result)
            {
                Console.WriteLine($"{product.Name} --- {product.Category} --- {product.Price} --- {product.CreatedDate}");
            }
        }

        public void ProductsOfCategory()
        {
            Console.WriteLine("Write a category:");
            var category = Console.ReadLine();

            var result = _productService.ProductOfCategory(category);

            foreach (var product in result.Category)
            {
                Console.WriteLine($"{result.Name} + {result.Price} + {result.CreatedDate} + {result.Category}");
                break;
            }
        }

        public void ShowAllCategories()
        {
            var categories = _productService.GetAll();
            foreach (var category in categories)
            {
                Console.WriteLine(category.Category);
            }
        }

       // I didnt understand what I should do in 6
    }
}
