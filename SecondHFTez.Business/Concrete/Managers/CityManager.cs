using System.Collections.Generic;
using System.Linq;
using SecondHFTez.Business.Abstracts;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        //public List<City> GetList()
        //{
        //    return _cityDal.GetList().OrderBy(c => c.Products.Count).Take(5).ToList();
        //    //toList() olmazsı nedeni IOrderdEnumarable dönüyor.Take ilk 5 tane elemanı getirdik.
        //}

        public City Get(int id)
        {
            return _cityDal.Get(c => c.Id == id);
        }

        public City GetWithPostCode(int code)
        {
            return _cityDal.Get(c => c.PostCode == code);
        }

        public City GetWithName(string name)
        {
            return _cityDal.Get(c => c.Name.Contains("name"));
        }

    }
}