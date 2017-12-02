using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface IFavoriteService
    {
        Favorite Get(int id);
        Favorite Add(Favorite favorite);
        void Delete(int id);
    }
}