﻿using DAL.Context;
using DAL.Repositories.Abstract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
		private readonly AppDbContext dbContext;

		public ProductRepository(AppDbContext dbContext) : base(dbContext)
		{
			this.dbContext = dbContext;
		}

		public IEnumerable<Product> GetAllIncludeAll()
		{
			return dbContext.Products.Include(a => a.Menu).Include(a => a.Category).ToList();
		}

		public IEnumerable<Product> GetAllIncludeCategory()
		{
			return dbContext.Products.Include(a => a.Category).ToList();
		}

		public IEnumerable<Product> GetAllIncludeMenu()
		{
			return dbContext.Products.Include(a => a.Menu).ToList();
		}

		public IEnumerable<Product> GetAllIncludeMenuThenIncludeOrder()
		{
			return dbContext.Products.Include(a => a.Menu).ThenInclude(a => a.Order).ToList();
		}

		public IEnumerable<Product> GetAllIncludeMenuThenIncludeOrderThenIncludeUser()
		{
			return dbContext.Products.Include(a => a.Menu).ThenInclude(a => a.Order).ThenInclude(a => a.AppUser).ToList();
		}

		public Product GetByIdIncludeAll(int id)
		{
			return dbContext.Products.Include(a => a.Menu).Include(a => a.Category).FirstOrDefault(a => a.Id == id);
		}

		public Product GetByIdIncludeCategory(int id)
		{
			return dbContext.Products.Include(a => a.Category).FirstOrDefault(a => a.Id == id);
		}

		public Product GetByIdIncludeMenu(int id)
		{
			return dbContext.Products.Include(a => a.Menu).FirstOrDefault(a => a.Id == id);
		}

		public Product GetByIdIncludeMenuThenIncludeOrder(int id)
		{
			return dbContext.Products.Include(a => a.Menu).ThenInclude(a => a.Order).FirstOrDefault(a => a.Id == id);
		}

		public Product GetByIdIncludeMenuThenIncludeOrderThenIncludeUser(int id)
		{
			return dbContext.Products.Include(a => a.Menu).ThenInclude(a => a.Order).ThenInclude(a => a.AppUser).FirstOrDefault(a => a.Id == id);
		}
	}
}