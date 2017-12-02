using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.ValidationRules.FluentValidation
{
    public class ProductValidatior:AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(p => p.Category_Id).NotEmpty();
            RuleFor(p => p.Owner_Id).NotEmpty();
            RuleFor(p => p.City_Id).NotEmpty();
            RuleFor(p => p.County_Id).NotEmpty();
            RuleFor(p => p.Details).NotEmpty().Length(5, 500);
            RuleFor(p => p.Image).NotEmpty();
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Title).NotEmpty().Length(3, 50);
            RuleFor(p => p.ModifiedUserName).NotEmpty().Length(2, 30);
        }
    }
}
