using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator:AbstractValidator<Guide>
    { 
        public GuideValidator()
        {
            RuleFor(x=>x.GuideName).NotEmpty().WithMessage("Please Enter Guide Name");
            RuleFor(x => x.GuideDescription).NotEmpty().WithMessage("Please Enter Guide Description");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please Add Guide Image");
            RuleFor(x => x.GuideName).MaximumLength(30).WithMessage("Please Enter a Name Shorter Then 30 Character");
        }
    }
}
