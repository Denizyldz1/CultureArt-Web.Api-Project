using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Service.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;

namespace CultureArt.API.Middlewares
{
	public static class UseCustomExceptionHandler
	{
		public static void UseCustomException(this IApplicationBuilder app)
		{
			app.UseExceptionHandler(config =>
			{
				// Run sonlandırı bir middleware'dır.
				config.Run(async context =>
				{
					// Json dönüşler ile çalıştığımızdan dolayı Type json verdik
					context.Response.ContentType = "application/json";

					// Burada uygulamadan fırlatılan hatayı alıyoruz.
					var expceptionFeature = context.Features.Get<IExceptionHandlerFeature>();

					// Burada iki farklı hata olabilir Client hatası veya uygulamanın hatası
					// Bu yüzden Services katmanında exceptions klasörü içerisinde mesaj döndürüyoruz.
					// Error içerisine giriyoruz tipe göre hata kodunu veriyoruz.
					var statusCode = expceptionFeature.Error switch
					{
						ClientSideException => 400,
						NotFoundException => 404,
						_ => 500
					};
					context.Response.StatusCode = statusCode;
					string errorMessage = expceptionFeature.Error.Message;
					var response = CustomResponseDto<NoContentDto>.Failure(statusCode, errorMessage);

					await context.Response.WriteAsync(JsonSerializer.Serialize(response));
				});
			});






		}
	}
}
