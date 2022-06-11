using FluentValidation;
using ProductApp.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Business.Validations
{
    public class CreateProductValidator : AbstractValidator<ProductCreateDto>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.ProductCode).NotNull().NotEmpty().WithMessage("ProductCode alanı boş bırakılamaz");
            RuleFor(x => x.ProductPrice).GreaterThanOrEqualTo(1).WithMessage("ProductPrice alanı 1'den küçük olamaz");
            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("ProductName alanı boş bırakılamaz");
        }


    }
}
