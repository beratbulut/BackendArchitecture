using Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Businees.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();

    }
}
