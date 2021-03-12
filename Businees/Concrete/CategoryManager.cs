using Example.Businees.Abstract;
using Example.DataAccess.Abstract;
using Example.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Example.Businees.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetList()
        {
            return _categoryDal.GetList().ToList();
        }
    }
}
