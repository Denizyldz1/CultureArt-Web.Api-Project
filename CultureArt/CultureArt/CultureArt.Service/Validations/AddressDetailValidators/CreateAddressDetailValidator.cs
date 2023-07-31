using CultureArt.Core.DTOs.AddressDetailDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Service.Validations.AddressDetailValidator
{
    public class CreateAddressDetailValidator : AbstractValidator<CreateAddressDetailDto>
    {
        public CreateAddressDetailValidator()
        {
            RuleFor(x=>x.CityId).InclusiveBetween(1,int.MaxValue).WithMessage("{PropertyName} 0 dan büyük olmalıdır.");
            RuleFor(x => x.StreetAddress).NotNull().WithMessage("{PropertyName} gereklidir.")
                                .NotEmpty().WithMessage("{PropertyName} gereklidir.");
            RuleFor(x => x.EventAreaName).NotNull().WithMessage("{PropertyName} gereklidir.")
                                .NotEmpty().WithMessage("{PropertyName} gereklidir.");
        }
    }
}
