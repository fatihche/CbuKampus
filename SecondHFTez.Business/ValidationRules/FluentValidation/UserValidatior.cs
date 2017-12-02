using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.ValidationRules.FluentValidation
{
    public class UserValidatior:AbstractValidator<SecondHfUser>
    {
        public UserValidatior()
        {
            RuleFor(u => u.Username).NotEmpty().Length(5, 50).NotEqual("Admin").NotEqual("admin");
            RuleFor(u => u.Username).Matches(u => u.Username).WithMessage("Farklı bir username kullanınız");
            //RuleFor(u => u.Password).Equal(u=>u.Repassword).WithMessage("Şifre Eşleşmiyor");
            RuleFor(u => u.Password).NotEmpty().Length(3, 50);
            RuleFor(u => u.Name).Length(3, 25).NotEqual(u => u.Lastname);
            RuleFor(u => u.Lastname).Length(3, 25);
            RuleFor(u => u.TelNumber).Length(10);
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(u => u.Role_Id).Equal(2);
        }

    }
}
