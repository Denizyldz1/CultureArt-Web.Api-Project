using CultureArt.Core.DTOs.CategoryDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Service.Validations.CategoryValidators
{
	public class CreateCategoryValidator:AbstractValidator<CreateCategoryDto>
	{
        public CreateCategoryValidator()
        {
			RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} gereklidir.")
								.NotEmpty().WithMessage("{PropertyName} gereklidir.");
		}
    }
}
