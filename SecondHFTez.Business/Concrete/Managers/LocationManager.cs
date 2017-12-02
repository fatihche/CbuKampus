using SecondHFTez.Business.Abstracts;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class LocationManager : ILocationService
    {
        private readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public Location Get(int id)
        {
            return _locationDal.Get(l => l.Product_Id == id);
        }

        public Location Add(Location location)
        {
            return _locationDal.Add(location);
        }

        public Location Update(Location location)
        {
            return _locationDal.Update(location);
        }

        public void Delete(int id)
        {
            _locationDal.Delete(Get(id));
        }
    }
}