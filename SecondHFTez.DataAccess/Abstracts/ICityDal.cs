using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface ICityDal : IEntityRepository<City>
    {
        //TEntitye özgü db işlemleri 
    }
}