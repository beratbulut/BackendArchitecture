using Example.Core.DataAccess.EntityFramework;
using Example.DataAccess.Abstract;
using Example.DataAccess.Concrete.EntityFramework.Contexts;
using Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
