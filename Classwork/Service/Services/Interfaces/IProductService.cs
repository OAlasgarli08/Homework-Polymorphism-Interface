using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        Product[] GetAll();
        Product SearchOfProduct(string search);
        Product ShowInformationOfProduct(string search);
        Product[] OrderByDate(string sortDate);

        Product ProductOfCategory(string categoryName);
    }
}
