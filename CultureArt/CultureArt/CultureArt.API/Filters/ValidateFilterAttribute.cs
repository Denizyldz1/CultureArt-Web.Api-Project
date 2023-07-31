using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CultureArt.API.Filters
{
	public class ValidateFilterAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			// Fluent validation direk olarak ModelState ile entegre
			if(!context.ModelState.IsValid)
			{
				var errors = context.ModelState.Values
					.SelectMany (x => x.Errors)
					.Select (x => x.ErrorMessage)
					.ToList ();
				// Object seçilmesi sebebi body içerisinin dolu gönderililmesi.
				context.Result = new BadRequestObjectResult
					(CustomResponseDto<NoContentDto>
					.Failure(400, errors));
			}
		}
	}
}
