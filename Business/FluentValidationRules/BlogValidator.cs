using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık 150 Karakterden Fazla Olamaz");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("Başlık 2 Karakterden Az Olamaz");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz");
            RuleFor(x => x.BlogContent).MaximumLength(10000).WithMessage("İçerik 10 Bin Karakterden Fazla Olamaz");
            RuleFor(x => x.BlogContent).MinimumLength(30).WithMessage("İçerik 30 Karakterden Az Olamaz");

            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz");

        }
    }
}
