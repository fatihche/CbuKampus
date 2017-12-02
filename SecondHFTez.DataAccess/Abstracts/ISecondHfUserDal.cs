using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface ISecondHfUserDal : IEntityRepository<SecondHfUser>
    {
        //TEntitye özgü db işlemleri 
    }
}