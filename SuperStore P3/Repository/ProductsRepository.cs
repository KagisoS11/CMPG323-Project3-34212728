﻿using Data;
using Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public ProductsRepository(SuperStoreContext context): base(context)
        {
            _context = context;   
        }

        public Product GetMostRecentProduct()
        {
            return _context.Products.OrderByDescending(Product => Product.CreatedDate).FirstOrDefault();
        }

        public Product GetProductById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return GetAllProducts().ToList();
        }

        public void AddProduct(Product entity)
        {
            Add(entity);
        }

        public void RemoveProduct(Product entity)
        {
            Remove(entity);
        }

        public void UpdateProduct(Product entity)
        {
            Update(entity);
        }
    }
}
