using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface IRecommendationService
    {
        Recommentation Get(int id);
        Recommentation Add(Recommentation recommentation);
        Recommentation Update(Recommentation recommentation);
        void Delete(int id);
    }
}