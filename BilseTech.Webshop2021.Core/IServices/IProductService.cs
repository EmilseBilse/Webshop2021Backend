using System.Collections.Generic;
using BilseTech.Webshop2021.Core.Models;

namespace BilseTech.Webshop2021.Core.IServices
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}