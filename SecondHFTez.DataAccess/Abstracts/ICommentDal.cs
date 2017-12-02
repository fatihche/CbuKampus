using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
        //TEntitye özgü db iþlemleri 
    }
}