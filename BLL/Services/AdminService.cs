using DAL.Repositories.Abstract;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        private readonly IOrderRepository orderRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IMenuRepository menuRepository;
        private readonly IProductRepository productRepository;
        private readonly UserManager<AppUser> userManager;

        public AdminService(IOrderRepository orderRepository, ICategoryRepository categoryRepository, IMenuRepository menuRepository, IProductRepository productRepository, UserManager<AppUser> userManager)
        {
            this.orderRepository = orderRepository;
            this.categoryRepository = categoryRepository;
            this.menuRepository = menuRepository;
            this.productRepository = productRepository;
            this.userManager = userManager;
        }

        public List<AppUser> GetAllUsers()
        {
            return userManager.Users.ToList();
        }

        public async Task<IList<AppUser>> GetAllStandartUsers()
        {
            return await userManager.GetUsersInRoleAsync("Standard User");
        }

        public async Task<AppUser> GetUserByEmail(string email)
        {
            return await userManager.FindByEmailAsync(email);
        }

        public async Task<IdentityResult> UpdateUser(AppUser user)
        {
             return await userManager.UpdateAsync(user);
        }

        public decimal GetTotalPaymentFromProducts()
        {
            return orderRepository.GetTotalPaymentFromProducts();
        }

        public decimal GetTotalPayment()
        {
            return orderRepository.GetTotalPayment();
        }

        public int GetTotalOrderCount()
        {
            return orderRepository.GetTotalOrderCount();
        }

        public int GetTotalMenuCount()
        {
            return menuRepository.GetTotalMenuCount();
        }

        public int GetTotalProductCount()
        {
            return productRepository.GetTotalProductCount();
        }

        public IEnumerable<Menu> GetAllMenus() 
        {
            return menuRepository.GetAll();
        }

        public Menu GetMenuById(int id)
        {
           return menuRepository.GetById(id);
        }
        public void AddMenu(Menu menu)
        {
            menuRepository.Add(menu);
        }
        public void UpdateMenu(Menu menu)
        {
            menuRepository.Update(menu);
        }
        public void DeleteMenu(Menu menu)
        {
            menuRepository.Delete(menu);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return productRepository.GetAll();
        }
        public Product GetProductById(int id)
        {
            return productRepository.GetById(id);
        }
        public bool AddProduct(Product product)
        {
            return productRepository.Add(product);
        }
        public bool UpdateProduct(Product product)
        {
            return productRepository.Update(product);
        }
        public bool DeleteProduct(Product product)
        {
            return productRepository.Delete(product);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }
        public Category GetCategoryById(int id)
        {
            return categoryRepository.GetById(id);
        }
        public void AddCategory(Category category)
        {
            categoryRepository.Add(category);
        }
        public void UpdateCategory(Category category)
        {
            categoryRepository.Update(category);
        }
        public void DeleteCategory(Category category)
        {
            categoryRepository.Delete(category);
        }

        public IEnumerable<Order> GetAllOrdersWithUsers()
        {
            return orderRepository.GetAllIncludeMenusIncludeUsers();
        }

    }
}
