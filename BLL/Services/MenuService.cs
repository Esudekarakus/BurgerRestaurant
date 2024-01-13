using DAL.Repositories.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MenuService
    {
        private readonly IMenuRepository menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;



        }

        public List<Menu>GetMenusIncludeProducts()
        {
            return menuRepository.GetAllIncludeProducts().ToList();
        }
    }
}
