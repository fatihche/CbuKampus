using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Get(int id);
        Category Add(Category category);
        Category Update(Category category);
        void Delete(int id);
    }
}
