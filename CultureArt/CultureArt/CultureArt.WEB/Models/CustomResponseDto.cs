using System.Text.Json.Serialization;

namespace CultureArt.WEB.Models
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore] // Bu veriyi json dönüştürürken Ignore(Yok say) et demek
        public int StatusCode { get; set; }
        public List<String>? Errors { get; set; }
        // New lemek yerine static nesneler oluşturuyoruz.

        // İşlem başarılı ve geriye data döndürmek için
        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
        }
        // İşlem başarılı ve geriye sadece durum kodu döndürmek için
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode };
        }
        // Birde fazla error mesaj için
        public static CustomResponseDto<T> Failure(int statusCode, List<String> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }
        public static CustomResponseDto<T> Failure(int statusCode, string errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { errors } };
        }
    }
}
