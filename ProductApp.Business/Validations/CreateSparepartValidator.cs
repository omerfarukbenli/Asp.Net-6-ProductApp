using FluentValidation;
using ProductApp.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Business.Validations
{
    public class CreateSparepartValidator : AbstractValidator<CreateSparepartDto>
    {
        public CreateSparepartValidator()
        {
            RuleFor(x => x.SparepartCode).NotNull().NotEmpty().WithMessage("SparepartCode alanı boş bırakılamaz");
            RuleFor(x => x.SparepartPrice).GreaterThanOrEqualTo(1).WithMessage("SparepartPrice alanı 1'den küçük olamaz");
            RuleFor(x => x.SparepartName).NotNull().NotEmpty().WithMessage("SparepartName alanı boş bırakılamaz");
           
        }
    }
}
