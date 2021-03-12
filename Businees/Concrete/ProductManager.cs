using Example.Businees.Abstract;
using Example.DataAccess.Abstract;
using Example.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Example.Businees.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);

        }

        public Product GetById(int productId)
        {
           return  _productDal.Get(x=>x.ProductId== productId);

        }

        public List<Product> GetList()
        {
            return _productDal.GetList().ToList();

        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(x=>x.CategoryId== categoryId).ToList();

        }

        public void Update(Product product)
        {
            _productDal.Update(product);

        }
    }
}
