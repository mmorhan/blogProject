using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("You have to enter a name");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("You have to enter an email");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("You have to enter a password ");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("You have to enter at least 2 characters");
            RuleFor(x => x.WriterName).MaximumLength(40).WithMessage("You can enter at most 40 characters");
        }
    }
}
