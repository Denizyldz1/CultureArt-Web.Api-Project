using CultureArt.Core.Dto.CustomResponseDto;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomBaseController : ControllerBase
	{
		[NonAction] // Bu Method bir endpoint değil swagger bunu algılamaması için NonAction attirbute kullanıyoruz.
		public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
		{
			if (response.StatusCode == 204)
			{
				return new ObjectResult(null)
				{
					StatusCode = response.StatusCode,
				};
			}
			return new ObjectResult(response)
			{
				StatusCode = response.StatusCode,
			};
		}
	}
}
