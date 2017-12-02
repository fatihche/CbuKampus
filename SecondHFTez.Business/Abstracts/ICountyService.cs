using System.Collections.Generic;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface ICountyService
    {
        County Get(int id);
        County GetWithName(string name);

    }
}