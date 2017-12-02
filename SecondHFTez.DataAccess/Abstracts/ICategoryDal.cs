using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondHFTez.Core.DataAccess;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Abstracts
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //TEntitye özgü db işlemleri 
    }
}
