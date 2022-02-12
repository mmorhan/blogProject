using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("You have to enter a title");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("You have to enter an Contentemail");
            RuleFor(x => x.BlogContent).MinimumLength(1000).WithMessage("Too Short!");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("You have to select a photo");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("You have to enter select a category");
            RuleFor(x => x.BlogTitle).MaximumLength(250).WithMessage("You can enter at most 250 characters");
            RuleFor(x => x.BlogTitle).MinimumLength(10).WithMessage("You can enter at least 10 characters");
        }
    }
}
