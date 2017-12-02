using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //producta özgü metodlar mesela joinli bir product detail
    }
}