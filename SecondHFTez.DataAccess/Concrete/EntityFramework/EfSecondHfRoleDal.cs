using SecondHFTez.Core.DataAccess.EntityFramework;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Concrete.EntityFramework
{
    public class EfSecondHfRoleDal : EfEntityRepositoryBase<SecondHfRole, DatabaseContext>, ISecondHfRoleDal
    {
    }
}