using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface IVoteDal : IEntityRepository<Vote>
    {
        //TEntitye özgü db işlemleri 
    }
}