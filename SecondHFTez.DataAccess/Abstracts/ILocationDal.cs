using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface ILocationDal : IEntityRepository<Location>
    {
        //TEntitye özgü db işlemleri 
    }
}