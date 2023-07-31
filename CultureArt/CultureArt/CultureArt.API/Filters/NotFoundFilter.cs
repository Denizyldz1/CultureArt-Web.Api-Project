using CultureArt.Core.Dto;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.Entities;
using CultureArt.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CultureArt.API.Filters
{
	public class NotFoundFilter<T> : IAsyncActionFilter where T : IEntity
	{
		private readonly IBaseService<T> _baseService;

		public NotFoundFilter(IBaseService<T> baseService)
		{
			_baseService = baseService;
		}

		public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			// Controller'da NotFound düzenlemek için
			var idValue = context.ActionArguments.Values.FirstOrDefault();
			if (idValue == null) 
			{
				await next.Invoke();
				return;
			}
			var id =(int)idValue;
			var anyEntity=await _baseService.AnyAsync(x=>x.Id==id);
			if (anyEntity)
			{
				await next.Invoke();
				return;
			}
			context.Result = new NotFoundObjectResult(CustomResponseDto<NoContentDto>.Failure(404, $"{typeof(T).Name}({id}) not found"));
		}
	}
}
