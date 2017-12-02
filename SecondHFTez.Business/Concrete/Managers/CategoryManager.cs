using System.Collections.Generic;
using SecondHFTez.Business.Abstracts;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(c => c.Id == id);
        }


        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(Get(id));
        }
    }
}
