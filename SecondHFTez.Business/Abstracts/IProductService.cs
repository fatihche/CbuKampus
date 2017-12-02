using System.Collections.Generic;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product Get(int id);

        Product Add(Product product);

        Product Update(Product product);

        void Delete(int id);

        List<Product> SortByViewCount();//sil

        List<Product> SortByPrice();




    }
}