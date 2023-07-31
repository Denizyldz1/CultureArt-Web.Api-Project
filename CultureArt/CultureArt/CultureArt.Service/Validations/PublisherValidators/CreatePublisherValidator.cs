using CultureArt.Core.DTOs.PublisherDtos;
using FluentValidation;

namespace CultureArt.Service.Validations.PublisherValidators
{
	public class CreatePublisherValidator : AbstractValidator<CreatePublisherDto>
	{
        public CreatePublisherValidator()
        {
			RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} gereklidir.")
								 .NotEmpty().WithMessage("{PropertyName} gereklidir.");
			RuleFor(x => x.WebSiteHomePageUrl).NotNull().WithMessage("{PropertyName} gereklidir.")
					 .NotEmpty().WithMessage("{PropertyName} gereklidir.");

		}
    }
}
