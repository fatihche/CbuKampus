using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface ICountyDal : IEntityRepository<County>
    {
        //TEntitye özgü db işlemleri 
    }
}