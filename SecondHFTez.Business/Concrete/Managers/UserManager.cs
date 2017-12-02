using SecondHFTez.Business.Abstracts;
using SecondHFTez.Business.ValidationRules.FluentValidation;
using SecondHFTez.Core.Aspects.PostSharp;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private readonly ISecondHfUserDal _secondHfUserDal;

        public UserManager(ISecondHfUserDal secondHfUserDal)
        {
            _secondHfUserDal = secondHfUserDal;
        }

        public SecondHfUser Get(int id)
        {
            return _secondHfUserDal.Get(u => u.Id == id);
        }
        [FluentValidationAspect(typeof(UserValidatior))]
        public SecondHfUser Add(SecondHfUser user)
        {
            //ValidatorTool.FluentValidate(new UserValidatior(), user);
            return _secondHfUserDal.Add(user);
        }

        public SecondHfUser Update(SecondHfUser user)
        {
            return _secondHfUserDal.Update(user);
        }

        public void Delete(int id)
        {
            _secondHfUserDal.Delete(Get(id));
        }
    }
}