using SecondHFTez.Business.Abstracts;
using SecondHFTez.Business.ValidationRules.FluentValidation;
using SecondHFTez.Core.Aspects.PostSharp;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Comment Get(int id)
        {
            return _commentDal.Get(c => c.Id == id);
        }
        [FluentValidationAspect(typeof(CommentValidatior))]
        public Comment Add(Comment comment)
        {
            return _commentDal.Add(comment);
        }

        public Comment Update(Comment comment)
        {
            return _commentDal.Update(comment);
        }

        public void Delete(int id)
        {
            _commentDal.Delete(Get(id));
        }
    }
}