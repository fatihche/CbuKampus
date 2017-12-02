using System.Collections.Generic;
using System.Linq;
using SecondHFTez.Business.Abstracts;
using SecondHFTez.Business.ValidationRules.FluentValidation;
using SecondHFTez.Core.Aspects.PostSharp;
using SecondHFTez.Core.CrossCuttingConcerns.Validation.FluentValidation;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product Get(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Add(Product product)
        {
            //ValidatorTool.FluentValidate(new ProductValidatior(), product); //Single Responsibility durumu nedeniyle aspect yazıcaz.
            return _productDal.Add(product);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        public void Delete(int id)
        {
            _productDal.Delete(Get(id));
        }

        public List<Product> SortByViewCount()
        {
            return _productDal.GetList().OrderBy(p => p.ViewCount).ToList();
        }

        public List<Product> SortByPrice()
        {
            return _productDal.GetList().OrderBy(p => p.Price).ToList();
        }




        //public int GetVoteSelectedProduct(int id) //bunun Single responsibility durumunu araştır
        //{
        //    List<Vote> votes = _productDal.Get(p => p.Id == id).Votes;
        //    int deger = 0;
        //    foreach (var item in votes)
        //    {
        //        deger += item.Value;
        //    }
        //    deger = deger / votes.Count;
        //    return deger;
        //}

        
    }
}