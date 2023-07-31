using System.Text.Json.Serialization;

namespace CultureArt.WEB.Models
{
    public class NoContentDto
    {
        [JsonIgnore] 
        public int StatusCode { get; set; }
        public List<String>? Errors { get; set; }
        public static NoContentDto Success(int statusCode)
        {
            return new NoContentDto { StatusCode = statusCode };
        }
        public static NoContentDto Failure(int statusCode, List<String> errors)
        {
            return new NoContentDto { StatusCode = statusCode, Errors = errors };
        }
        public static NoContentDto Failure(int statusCode, string errors)
        {
            return new NoContentDto { StatusCode = statusCode, Errors = new List<string> { errors } };
        }
    }
}
