using System.Collections.Generic;
using BilseTech.Webshop2021.Core.Models;

namespace BilseTech.Webshop2021.Domain.IRepositories
{
    public interface IProductRepository
    {
        List<Product> ReadAll();
    }
}