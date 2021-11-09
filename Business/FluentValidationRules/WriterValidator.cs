using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {


            RuleFor(x => x.WriterName).NotEmpty().WithMessage("BU ALAN BOŞ GEÇİLEMEZ");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("BU ALAN BOŞ GEÇİLEMEZ");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("BU ALAN BOŞ GEÇİLEMEZ");

            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapabilirsiniz");
            RuleFor(x => x.WriterMail).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapabilirsiniz");
            RuleFor(x => x.WriterPassword).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapabilirsiniz");

            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapabilirsiniz");
            RuleFor(x => x.WriterMail).MinimumLength(2).WithMessage("En az 2 karakter girişi yapabilirsiniz");
            RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Şifreniz en az 6 karakterden oluşmalıdır");

            RuleFor(x => x).Custom((x, context) =>
              {
                  if (x.WriterPassword != x.WriterConfirmPassword)
                  {
                      context.AddFailure(nameof(x.WriterPassword), "Şifreler Aynı Değil");
                  }
              });

        }
    }
}
