using System.Collections.Generic;
using System.IO;
using BilseTech.Webshop2021.Core.IServices;
using BilseTech.Webshop2021.Core.Models;
using BilseTech.Webshop2021.Domain.IRepositories;
using Moq;

namespace BilseTech.Webshop2021.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            if (productRepository == null)
            {
                throw new InvalidDataException("Product Repository can not be null");
            }

            _productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _productRepository.ReadAll();
            
        }
    }
}