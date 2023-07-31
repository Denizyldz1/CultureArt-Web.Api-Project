using CultureArt.Core.DTOs.EventDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Service.Validations.EventValidators
{
	public class UpdateEventValidator:AbstractValidator<UpdateEventDto>
	{
        public UpdateEventValidator()
        {
			RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} alanı zorunludur");

			RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} gereklidir.")
								  .NotEmpty().WithMessage("{PropertyName} gereklidir.");
			RuleFor(x => x.EventStartDate).InclusiveBetween(DateTime.Now, DateTime.MaxValue).WithMessage("{PropertyName} Geçmiş tarihli olamaz");
			RuleFor(x => x.EventEndDate).InclusiveBetween(DateTime.Now, DateTime.MaxValue).WithMessage("{PropertyName} Geçmiş tarihli olamaz");
			RuleFor(x => x.ImageUrl).NotNull().WithMessage("{PropertyName} gereklidir.")
								  .NotEmpty().WithMessage("{PropertyName} gereklidir.");
			RuleFor(x => x.CompanyId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} alanı zorunludur");
			RuleFor(x => x.AddressDetailId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} alanı zorunludur");
			RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} alanı zorunludur");
			RuleFor(x => x.CityId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} alanı zorunludur");

			// EventFeature
			RuleFor(x => x.EventFeature.Title).NotNull().WithMessage("{PropertyName} gereklidir.")
								  .NotEmpty().WithMessage("{PropertyName} gereklidir.");
			RuleFor(x => x.EventFeature.Description).NotNull().WithMessage("{PropertyName} gereklidir.")
					  .NotEmpty().WithMessage("{PropertyName} gereklidir.");

		}
    }
}
