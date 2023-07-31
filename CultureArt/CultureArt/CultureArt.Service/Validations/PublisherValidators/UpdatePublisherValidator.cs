using CultureArt.Core.DTOs.PublisherDtos;
using FluentValidation;

namespace CultureArt.Service.Validations.PublisherValidators
{
	internal class UpdatePublisherValidator:AbstractValidator<UpdatePublisherDto>
	{
        public UpdatePublisherValidator()
        {
			RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} gereklidir.")
					.NotEmpty().WithMessage("{PropertyName} gereklidir.");
			RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} alanı zorunludur");
			RuleFor(x => x.WebSiteHomePageUrl).NotNull().WithMessage("{PropertyName} gereklidir.")
					 .NotEmpty().WithMessage("{PropertyName} gereklidir.");
		}
    }
}
