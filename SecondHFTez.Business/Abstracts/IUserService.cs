using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface IUserService
    {
        SecondHfUser Get(int id);

        SecondHfUser Add(SecondHfUser user);

        SecondHfUser Update(SecondHfUser user);

        void Delete(int id);
    }
}