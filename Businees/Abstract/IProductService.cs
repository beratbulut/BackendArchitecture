﻿using Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Businees.Abstract
{
    public interface IProductService
    {
        Product GetById(int productId);
        List<Product> GetList();
        List<Product> GetListByCategory(int categoryId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
