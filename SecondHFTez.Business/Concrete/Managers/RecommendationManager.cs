using SecondHFTez.Business.Abstracts;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class RecommendationManager : IRecommendationService
    {
        private readonly IRecommentationDal _recommentationDal;

        public RecommendationManager(IRecommentationDal recommentationDal)
        {
            _recommentationDal = recommentationDal;
        }

        public Recommentation Get(int id)
        {
            return _recommentationDal.Get(r => r.Id == id);
        }

        public Recommentation Add(Recommentation recommentation)
        {
            return _recommentationDal.Add(recommentation);
        }

        public Recommentation Update(Recommentation recommentation)
        {
            return _recommentationDal.Update(recommentation);
        }

        public void Delete(int id)
        {
            _recommentationDal.Delete(Get(id));
        }
    }
}