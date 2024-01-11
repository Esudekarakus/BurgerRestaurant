﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstract
{
	internal interface IProductRepository : IRepository<Product>
	{
		Product GetByIdIncludeCategory(int id);
		IEnumerable<Product> GetAllIncludeCategory();
		Product GetByIdIncludeMenu(int id);
		IEnumerable<Product> GetAllIncludeMenu();
		Product GetByIdIncludeAll(int id);
		IEnumerable<Product> GetAllIncludeAll();
		Product GetByIdIncludeMenuThenIncludeOrder(int id);
		IEnumerable<Product> GetAllIncludeMenuThenIncludeOrder();
		Product GetByIdIncludeMenuThenIncludeOrderThenIncludeUser(int id);
		IEnumerable<Product> GetAllIncludeMenuThenIncludeOrderThenIncludeUser();
	}
}