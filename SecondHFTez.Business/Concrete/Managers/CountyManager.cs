using System.Collections.Generic;
using SecondHFTez.Business.Abstracts;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class CountyManager : ICountyService
    {
        private readonly ICountyDal _countyDal;

        public CountyManager(ICountyDal countyDal)
        {
            _countyDal = countyDal;
        }

        public County Get(int id)
        {
            return _countyDal.Get(c => c.Id == id);
        }

        public County GetWithName(string name)
        {
            return _countyDal.Get(c => c.Name.Contains("name"));
        }

    }
}