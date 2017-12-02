using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface ILocationService
    {
        Location Get(int id);//sil
        Location Add(Location location);
        Location Update(Location location);
        void Delete(int id);
    }
}