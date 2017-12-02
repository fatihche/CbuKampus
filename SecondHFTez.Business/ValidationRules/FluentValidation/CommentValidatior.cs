using FluentValidation;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.ValidationRules.FluentValidation
{
    public class CommentValidatior:AbstractValidator<Comment>
    {
        public CommentValidatior()
        {
            RuleFor(c => c.CContent).NotEmpty().Length(3, 300);
            RuleFor(c => c.ModifiedUserName).NotEmpty().Length(3, 30);
            RuleFor(c => c.Owner_Id).NotEmpty();
            RuleFor(c => c.Product_Id).NotEmpty();
        }
    }
}
