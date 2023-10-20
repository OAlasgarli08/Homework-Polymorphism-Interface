using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        public Product[] GetAll()
        {
            return new Product[]
            {
                new Product { Id = 1, Name ="Product 1", Price = 10, CreatedDate = new DateTime(2020,10,18), Category = "Fruit"},
                new Product { Id = 2, Name ="Product 2", Price = 30, CreatedDate = new DateTime(2010,08,28), Category = "Vegetable"},
                new Product { Id = 3, Name ="Product 3", Price = 20, CreatedDate = new DateTime(2018,05,30), Category = "Meat"},
                new Product { Id = 4, Name ="Product 4", Price = 30, CreatedDate = new DateTime(2018,05,30), Category = "Fish"},
            };
        }

        Product[] IProductService.OrderByDate(string sortDate)
        {
            return sortDate == "descending" ? GetAll().OrderByDescending(m => m.CreatedDate).ToArray() : GetAll().OrderBy(m => m.CreatedDate).ToArray();
        }

        Product IProductService.ProductOfCategory(string categoryName)
        {
            return GetAll().Where(m => m.Category == categoryName).FirstOrDefault();
        }

        Product IProductService.SearchOfProduct(string search)
        {
            return GetAll().Where(m => m.Name == search).FirstOrDefault();
                       
        }

        Product IProductService.ShowInformationOfProduct(string search)
        {
            return GetAll().FirstOrDefault(m => m.Name == search);
        }

        
    }
}
