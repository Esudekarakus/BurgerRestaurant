using DAL.Repositories.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public List<Product>GetProducts()
        {
            return productRepository.GetAll().ToList();
        }


        //get burgers

        public List<Product>GetBurgers()
        {
            return productRepository.GetAll().Where(p=>p.CategoryId==1).ToList();
        }
        public List<Product> GetBeverages()
        {
            return productRepository.GetAll().Where(p => p.CategoryId == 2).ToList();
        }
        public List<Product> GetCondiments()
        {
            return productRepository.GetAll().Where(p => p.CategoryId == 3).ToList();
        }
        public List<Product> GetSnacks()
        {
            return productRepository.GetAll().Where(p => p.CategoryId == 4).ToList();
        }
        public List<Product> GetDesserts()
        {
            return productRepository.GetAll().Where(p => p.CategoryId == 5).ToList();
        }
        
        

    }
}
