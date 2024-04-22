using BP.Data.Model;
using FluentValidation;

namespace BP.Api.Validations
{
    public class ContactValidations:AbstractValidator<ContactDVO>
    {
        public ContactValidations()
        {
            RuleFor(x=>x.Id).LessThan(100).WithMessage("100 den büyük Id olamaz").NotEmpty().NotNull().WithMessage("Boş dönülemez");
            
        }
    }
}
