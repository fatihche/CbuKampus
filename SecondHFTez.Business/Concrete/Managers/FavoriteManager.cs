using SecondHFTez.Business.Abstracts;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class FavoriteManager : IFavoriteService
    {
        private readonly IFavoriteDal _favoriteDal;

        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }

        public Favorite Get(int id)
        {
            return _favoriteDal.Get(f => f.Id == id);
        }

        public Favorite Add(Favorite favorite)
        {
            return _favoriteDal.Add(favorite);
        }

        public void Delete(int id)
        {
            _favoriteDal.Delete(Get(id));
        }
    }
}