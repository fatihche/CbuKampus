using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface ICommentService
    {
        //getList comment by product Id yapmıyorum çünkü productta var.
        Comment Get(int id);
        Comment Add(Comment comment);
        Comment Update(Comment comment);
        void Delete(int id);
    }
}